using System.Buffers;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace Xai.Realtime;

public sealed partial class XaiRealtimeClient
{
    /// <summary>
    /// Reconnects to a cached xAI conversation and enables resumption on the new session.
    /// </summary>
    /// <param name="conversationId">The ID from <c>conversation.created.conversation.id</c>.</param>
    /// <param name="session">Optional configuration to apply while enabling resumption.</param>
    /// <param name="model">The Grok Voice model to select.</param>
    /// <param name="reasoningEffort">The reasoning effort to select.</param>
    /// <param name="additionalHeaders">Additional WebSocket handshake headers.</param>
    /// <param name="additionalSubProtocols">Additional WebSocket subprotocols.</param>
    /// <param name="keepAliveInterval">Optional WebSocket keep-alive interval.</param>
    /// <param name="connectTimeout">Optional connection timeout.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    public async Task ResumeConversationAsync(
        string conversationId,
        SessionConfig? session = null,
        VoiceModel? model = default,
        VoiceReasoningEffort? reasoningEffort = default,
        IDictionary<string, string>? additionalHeaders = null,
        IEnumerable<string>? additionalSubProtocols = null,
        TimeSpan? keepAliveInterval = null,
        TimeSpan? connectTimeout = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(conversationId);
        if (IsConnected)
        {
            throw new InvalidOperationException(
                "Conversation resumption requires a new, disconnected XaiRealtimeClient instance.");
        }

        session ??= new SessionConfig();
        session.Resumption ??= new ResumptionConfig();
        session.Resumption.Enabled = true;
        session.Validate();

        var uri = new Uri(new PathBuilder(DefaultBaseUrl)
            .AddRequiredParameter("conversation_id", conversationId)
            .AddOptionalParameter("model", model?.ToValueString())
            .AddOptionalParameter("reasoning.effort", reasoningEffort?.ToValueString())
            .ToString());

        await ConnectAsync(
            uri: uri,
            additionalHeaders: additionalHeaders,
            additionalSubProtocols: additionalSubProtocols,
            keepAliveInterval: keepAliveInterval,
            connectTimeout: connectTimeout,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        await SendSessionUpdateAsync(
            new SessionUpdatePayload { Session = session },
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Receives typed JSON events and raw binary output audio from the same WebSocket stream.
    /// </summary>
    /// <remarks>
    /// Use this method instead of <see cref="ReceiveUpdatesAsync"/> when output transport is binary.
    /// A client must not run both receive enumerables concurrently.
    /// </remarks>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>Complete text events and binary audio messages in wire order.</returns>
    public async IAsyncEnumerable<RealtimeServerMessage> ReceiveMessagesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (!IsConnected)
        {
            await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        const int ReceiveBufferSize = 64 * 1024;
        var buffer = ArrayPool<byte>.Shared.Rent(ReceiveBufferSize);
        try
        {
            var arraySegment = new ArraySegment<byte>(buffer, 0, ReceiveBufferSize);

            while (_clientWebSocket.State == WebSocketState.Open)
            {
                using var messageBuffer = new MemoryStream();
                WebSocketMessageType? messageType = null;
                var reconnected = false;

                while (true)
                {
                    WebSocketReceiveResult result;

                    try
                    {
                        result = await _clientWebSocket
                            .ReceiveAsync(arraySegment, cancellationToken)
                            .ConfigureAwait(false);
                    }
                    catch (WebSocketException exception)
                    {
                        RaiseException(exception);
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (await TryReconnectAsync(exception, cancellationToken).ConfigureAwait(false))
                        {
                            reconnected = true;
                            break;
                        }

                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }
                    catch (OperationCanceledException exception)
                    {
                        if (!cancellationToken.IsCancellationRequested)
                        {
                            RaiseException(exception);
                        }

                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        RaiseClosed(result.CloseStatus, result.CloseStatusDescription);
                        await _clientWebSocket.CloseOutputAsync(
                            WebSocketCloseStatus.NormalClosure,
                            "Closing",
                            cancellationToken).ConfigureAwait(false);
                        yield break;
                    }

                    messageType ??= result.MessageType;
                    if (result.Count > 0)
                    {
                        await messageBuffer
                            .WriteAsync(buffer.AsMemory(0, result.Count), cancellationToken)
                            .ConfigureAwait(false);
                    }

                    if (result.EndOfMessage)
                    {
                        break;
                    }
                }

                if (reconnected)
                {
                    continue;
                }

                var payload = messageBuffer.ToArray();
                if (messageType == WebSocketMessageType.Binary)
                {
                    yield return RealtimeServerMessage.FromBinaryAudio(payload);
                    continue;
                }

                if (messageType != WebSocketMessageType.Text)
                {
                    continue;
                }

                var rawText = Encoding.UTF8.GetString(payload);
                var parsedJson = TryParseMessageJson(rawText);
                if (parsedJson is not { ValueKind: JsonValueKind.Object } json ||
                    !json.TryGetProperty("type", out var typeProperty) ||
                    typeProperty.ValueKind != JsonValueKind.String ||
                    typeProperty.GetString() is not { } typeValue ||
                    ServerEventDiscriminatorTypeExtensions.ToEnum(typeValue) is null)
                {
                    DispatchUnknownMessage(rawText);
                    yield return RealtimeServerMessage.FromText(rawText, @event: null);
                    continue;
                }

                ServerEvent? serverEvent = null;
                try
                {
                    var deserialized = JsonSerializer.Deserialize(
                        rawText,
                        typeof(ServerEvent),
                        JsonSerializerContext);
                    if (deserialized is ServerEvent parsedEvent)
                    {
                        serverEvent = parsedEvent;
                    }
                }
                catch (Exception exception) when (
                    exception is JsonException or
                    NotSupportedException or
                    InvalidOperationException)
                {
                    var rethrow = false;
                    OnReceiveException(exception, ref rethrow);
                    DispatchUnknownMessage(rawText);
                    if (rethrow)
                    {
                        throw;
                    }
                }

                if (serverEvent is { } knownEvent)
                {
                    DispatchReceivedMessage(knownEvent, rawText);
                }

                yield return RealtimeServerMessage.FromText(rawText, serverEvent);
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer, clearArray: true);
        }
    }
}
