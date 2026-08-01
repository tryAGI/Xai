using System.Net.WebSockets;

namespace Xai.Realtime;

/// <summary>
/// A complete text event or binary audio message received from the xAI Realtime WebSocket.
/// </summary>
public sealed class RealtimeServerMessage
{
    private RealtimeServerMessage(
        WebSocketMessageType messageType,
        ServerEvent? @event,
        string? rawText,
        ReadOnlyMemory<byte> binaryAudio)
    {
        MessageType = messageType;
        Event = @event;
        RawText = rawText;
        BinaryAudio = binaryAudio;
    }

    /// <summary>
    /// Gets the WebSocket message type.
    /// </summary>
    public WebSocketMessageType MessageType { get; }

    /// <summary>
    /// Gets whether this message contains raw binary audio.
    /// </summary>
    public bool IsBinaryAudio => MessageType == WebSocketMessageType.Binary;

    /// <summary>
    /// Gets whether this message contains a text event.
    /// </summary>
    public bool IsText => MessageType == WebSocketMessageType.Text;

    /// <summary>
    /// Gets the typed server event when a text message matched a known event type.
    /// </summary>
    public ServerEvent? Event { get; }

    /// <summary>
    /// Gets the original text for a text message.
    /// </summary>
    public string? RawText { get; }

    /// <summary>
    /// Gets the raw codec bytes from a complete binary audio message.
    /// </summary>
    public ReadOnlyMemory<byte> BinaryAudio { get; }

    internal static RealtimeServerMessage FromBinaryAudio(byte[] audio)
    {
        return new RealtimeServerMessage(
            WebSocketMessageType.Binary,
            @event: null,
            rawText: null,
            audio);
    }

    internal static RealtimeServerMessage FromText(string rawText, ServerEvent? @event)
    {
        return new RealtimeServerMessage(
            WebSocketMessageType.Text,
            @event,
            rawText,
            binaryAudio: ReadOnlyMemory<byte>.Empty);
    }
}
