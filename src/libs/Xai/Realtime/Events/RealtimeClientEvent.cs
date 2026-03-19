#nullable enable

using System.Text.Json.Serialization;

namespace Xai;

/// <summary>
/// A client-to-server event for the xAI Realtime Voice Agent API.
/// Set exactly one property to define the event type.
/// </summary>
public sealed class RealtimeClientEvent
{
    /// <summary>
    /// The event type string (e.g. "session.update", "input_audio_buffer.append").
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Optional event ID.
    /// </summary>
    [JsonPropertyName("event_id")]
    public string? EventId { get; set; }

    /// <summary>
    /// Session configuration for a session.update event.
    /// </summary>
    [JsonPropertyName("session")]
    public RealtimeSessionConfig? Session { get; set; }

    /// <summary>
    /// Conversation item for a conversation.item.create event.
    /// </summary>
    [JsonPropertyName("item")]
    public RealtimeConversationItem? Item { get; set; }

    /// <summary>
    /// Base64-encoded audio data for input_audio_buffer.append.
    /// </summary>
    [JsonPropertyName("audio")]
    public string? Audio { get; set; }

    /// <summary>
    /// Response configuration for response.create events.
    /// </summary>
    [JsonPropertyName("response")]
    public RealtimeResponseConfig? Response { get; set; }

    /// <summary>
    /// Creates a session.update event.
    /// </summary>
    public static RealtimeClientEvent SessionUpdate(RealtimeSessionConfig session) => new()
    {
        Type = "session.update",
        Session = session,
    };

    /// <summary>
    /// Creates a conversation.item.create event with a user text message.
    /// </summary>
    public static RealtimeClientEvent UserMessage(string text) => new()
    {
        Type = "conversation.item.create",
        Item = new RealtimeConversationItem
        {
            Type = "message",
            Role = "user",
            Content =
            [
                new RealtimeContentPart
                {
                    Type = "input_text",
                    Text = text,
                },
            ],
        },
    };

    /// <summary>
    /// Creates an input_audio_buffer.append event.
    /// </summary>
    public static RealtimeClientEvent AppendAudio(string base64Audio) => new()
    {
        Type = "input_audio_buffer.append",
        Audio = base64Audio,
    };

    /// <summary>
    /// Creates an input_audio_buffer.commit event.
    /// </summary>
    public static RealtimeClientEvent CommitAudio() => new()
    {
        Type = "input_audio_buffer.commit",
    };

    /// <summary>
    /// Creates a response.create event.
    /// </summary>
    public static RealtimeClientEvent CreateResponse(string[]? modalities = null) => new()
    {
        Type = "response.create",
        Response = modalities != null ? new RealtimeResponseConfig { Modalities = modalities } : null,
    };

    /// <summary>
    /// Creates a function call output event.
    /// </summary>
    public static RealtimeClientEvent FunctionCallOutput(string callId, string output) => new()
    {
        Type = "conversation.item.create",
        Item = new RealtimeConversationItem
        {
            Type = "function_call_output",
            CallId = callId,
            Output = output,
        },
    };
}

/// <summary>
/// Response configuration for response.create events.
/// </summary>
public sealed class RealtimeResponseConfig
{
    /// <summary>
    /// Response modalities (e.g. ["text", "audio"]).
    /// </summary>
    [JsonPropertyName("modalities")]
    public string[]? Modalities { get; set; }
}
