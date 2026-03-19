#nullable enable

using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Xai;

/// <summary>
/// WebSocket client for the xAI Realtime Voice Agent API.
/// Provides bidirectional audio/text streaming at wss://api.x.ai/v1/realtime.
/// </summary>
public sealed class RealtimeVoiceClient : IDisposable
{
    /// <summary>
    /// Default WebSocket endpoint for the xAI Realtime API.
    /// </summary>
    public const string BaseUrl = "wss://api.x.ai/v1/realtime";

    private readonly ClientWebSocket _clientWebSocket;

    /// <summary>
    /// JSON serializer context for AOT-compatible serialization of realtime events.
    /// </summary>
    public JsonSerializerContext JsonSerializerContext { get; set; } = RealtimeJsonSerializerContext.Default;

    /// <summary>
    /// Whether the WebSocket connection is currently open.
    /// </summary>
    public bool IsConnected => _clientWebSocket.State == WebSocketState.Open;

    /// <summary>
    /// Creates a new RealtimeVoiceClient with the given API key.
    /// </summary>
    /// <param name="apiKey">xAI API key or ephemeral client secret.</param>
    /// <param name="clientWebSocket">Optional pre-configured WebSocket instance.</param>
    public RealtimeVoiceClient(
        string apiKey,
        ClientWebSocket? clientWebSocket = null)
    {
        apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        _clientWebSocket = clientWebSocket ?? new ClientWebSocket();
        _clientWebSocket.Options.SetRequestHeader("Authorization", $"Bearer {apiKey}");
    }

    /// <summary>
    /// Connects to the xAI Realtime WebSocket endpoint.
    /// </summary>
    /// <param name="uri">Optional custom URI. Defaults to <see cref="BaseUrl"/>.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public async Task ConnectAsync(
        Uri? uri = null,
        CancellationToken cancellationToken = default)
    {
        uri ??= new Uri(BaseUrl);
        await _clientWebSocket.ConnectAsync(uri, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends raw bytes over the WebSocket.
    /// </summary>
    public async Task SendAsync(
        ArraySegment<byte> bytes,
        WebSocketMessageType messageType,
        bool endOfMessage,
        CancellationToken cancellationToken = default)
    {
        if (!IsConnected)
        {
            await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        await _clientWebSocket.SendAsync(bytes, messageType, endOfMessage, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends a text message over the WebSocket.
    /// </summary>
    public async Task SendAsync(
        string text,
        CancellationToken cancellationToken = default)
    {
        if (!IsConnected)
        {
            await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        await _clientWebSocket.SendAsync(
            buffer: new ArraySegment<byte>(Encoding.UTF8.GetBytes(text)),
            messageType: WebSocketMessageType.Text,
            endOfMessage: true,
            cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends a typed client event as JSON over the WebSocket.
    /// </summary>
    /// <param name="clientEvent">The client event to send.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public async Task SendEventAsync(
        RealtimeClientEvent clientEvent,
        CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(clientEvent, (JsonTypeInfo<RealtimeClientEvent>)JsonSerializerContext.GetTypeInfo(typeof(RealtimeClientEvent))!);
        await SendAsync(json, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Receives server events as an async stream.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>An async enumerable of server events.</returns>
    public async IAsyncEnumerable<RealtimeServerEvent> ReceiveUpdatesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (!IsConnected)
        {
            await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        var buffer = new byte[1024 * 1024]; // 1MB buffer
        var arraySegment = new ArraySegment<byte>(buffer);

        while (_clientWebSocket.State == WebSocketState.Open)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                yield break;
            }

            WebSocketReceiveResult result;

            try
            {
                result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
            }
            catch (WebSocketException)
            {
                yield break;
            }
            catch (OperationCanceledException)
            {
                yield break;
            }

            if (result.MessageType == WebSocketMessageType.Text)
            {
                var json = Encoding.UTF8.GetString(buffer, 0, result.Count);
                var serverEvent = JsonSerializer.Deserialize(json, (JsonTypeInfo<RealtimeServerEvent>)JsonSerializerContext.GetTypeInfo(typeof(RealtimeServerEvent))!);
                if (serverEvent != null)
                {
                    yield return serverEvent;
                }
            }
            else if (result.MessageType == WebSocketMessageType.Close)
            {
                await _clientWebSocket.CloseAsync(
                    closeStatus: WebSocketCloseStatus.NormalClosure,
                    statusDescription: "Closing",
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                yield break;
            }
        }
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        _clientWebSocket.Dispose();
    }
}
