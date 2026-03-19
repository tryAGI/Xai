#nullable enable

using System.Text.Json.Serialization;

namespace Xai;

/// <summary>
/// A server-to-client event from the xAI Realtime Voice Agent API.
/// Inspect the <see cref="Type"/> property to determine the event kind,
/// then read the corresponding property for event-specific data.
/// </summary>
public sealed class RealtimeServerEvent
{
    /// <summary>
    /// The event type (e.g. "session.updated", "response.done").
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Unique event identifier.
    /// </summary>
    [JsonPropertyName("event_id")]
    public string? EventId { get; set; }

    // ─── Session ─────────────────────────────────────

    /// <summary>
    /// Session configuration (for session.created / session.updated events).
    /// </summary>
    [JsonPropertyName("session")]
    public RealtimeSessionInfo? Session { get; set; }

    // ─── Conversation ────────────────────────────────

    /// <summary>
    /// Conversation info (for conversation.created events).
    /// </summary>
    [JsonPropertyName("conversation")]
    public RealtimeConversationInfo? Conversation { get; set; }

    /// <summary>
    /// Conversation item (for conversation.item.added events).
    /// </summary>
    [JsonPropertyName("item")]
    public RealtimeConversationItem? Item { get; set; }

    /// <summary>
    /// Item ID for item-specific events.
    /// </summary>
    [JsonPropertyName("item_id")]
    public string? ItemId { get; set; }

    /// <summary>
    /// Previous item ID (for input_audio_buffer.committed).
    /// </summary>
    [JsonPropertyName("previous_item_id")]
    public string? PreviousItemId { get; set; }

    // ─── Transcription ───────────────────────────────

    /// <summary>
    /// Transcript text (for transcription.completed and audio_transcript events).
    /// </summary>
    [JsonPropertyName("transcript")]
    public string? Transcript { get; set; }

    // ─── Response ────────────────────────────────────

    /// <summary>
    /// Response info (for response.created / response.done events).
    /// </summary>
    [JsonPropertyName("response")]
    public RealtimeResponseInfo? Response { get; set; }

    /// <summary>
    /// Response ID for response-specific events.
    /// </summary>
    [JsonPropertyName("response_id")]
    public string? ResponseId { get; set; }

    /// <summary>
    /// Output index (for output_item and audio events).
    /// </summary>
    [JsonPropertyName("output_index")]
    public int? OutputIndex { get; set; }

    /// <summary>
    /// Content index (for audio delta events).
    /// </summary>
    [JsonPropertyName("content_index")]
    public int? ContentIndex { get; set; }

    /// <summary>
    /// Incremental text or audio delta.
    /// </summary>
    [JsonPropertyName("delta")]
    public string? Delta { get; set; }

    // ─── Function call ───────────────────────────────

    /// <summary>
    /// Function call ID.
    /// </summary>
    [JsonPropertyName("call_id")]
    public string? CallId { get; set; }

    /// <summary>
    /// Function or MCP tool name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Function call arguments (JSON string).
    /// </summary>
    [JsonPropertyName("arguments")]
    public string? Arguments { get; set; }

    // ─── Error ───────────────────────────────────────

    /// <summary>
    /// Error details (for error events).
    /// </summary>
    [JsonPropertyName("error")]
    public RealtimeError? Error { get; set; }

    // ─── Helper properties for event type checking ───

    /// <summary>Whether this is a session.created event.</summary>
    [JsonIgnore] public bool IsSessionCreated => Type == "session.created";

    /// <summary>Whether this is a session.updated event.</summary>
    [JsonIgnore] public bool IsSessionUpdated => Type == "session.updated";

    /// <summary>Whether this is a conversation.created event.</summary>
    [JsonIgnore] public bool IsConversationCreated => Type == "conversation.created";

    /// <summary>Whether this is a conversation.item.added event.</summary>
    [JsonIgnore] public bool IsConversationItemAdded => Type == "conversation.item.added";

    /// <summary>Whether this is an input_audio_buffer.speech_started event.</summary>
    [JsonIgnore] public bool IsSpeechStarted => Type == "input_audio_buffer.speech_started";

    /// <summary>Whether this is an input_audio_buffer.speech_stopped event.</summary>
    [JsonIgnore] public bool IsSpeechStopped => Type == "input_audio_buffer.speech_stopped";

    /// <summary>Whether this is an input_audio_buffer.committed event.</summary>
    [JsonIgnore] public bool IsAudioBufferCommitted => Type == "input_audio_buffer.committed";

    /// <summary>Whether this is an input_audio_transcription.completed event.</summary>
    [JsonIgnore] public bool IsTranscriptionCompleted => Type == "input_audio_transcription.completed";

    /// <summary>Whether this is a response.created event.</summary>
    [JsonIgnore] public bool IsResponseCreated => Type == "response.created";

    /// <summary>Whether this is a response.done event.</summary>
    [JsonIgnore] public bool IsResponseDone => Type == "response.done";

    /// <summary>Whether this is a response.output_item.added event.</summary>
    [JsonIgnore] public bool IsOutputItemAdded => Type == "response.output_item.added";

    /// <summary>Whether this is a response.output_audio_transcript.delta event.</summary>
    [JsonIgnore] public bool IsAudioTranscriptDelta => Type == "response.output_audio_transcript.delta";

    /// <summary>Whether this is a response.output_audio_transcript.done event.</summary>
    [JsonIgnore] public bool IsAudioTranscriptDone => Type == "response.output_audio_transcript.done";

    /// <summary>Whether this is a response.output_audio.delta event.</summary>
    [JsonIgnore] public bool IsAudioDelta => Type == "response.output_audio.delta";

    /// <summary>Whether this is a response.output_audio.done event.</summary>
    [JsonIgnore] public bool IsAudioDone => Type == "response.output_audio.done";

    /// <summary>Whether this is a response.function_call_arguments.done event.</summary>
    [JsonIgnore] public bool IsFunctionCallArgumentsDone => Type == "response.function_call_arguments.done";

    /// <summary>Whether this is an error event.</summary>
    [JsonIgnore] public bool IsError => Type == "error";

    /// <summary>Whether this is a mcp_list_tools.completed event.</summary>
    [JsonIgnore] public bool IsMcpListToolsCompleted => Type == "mcp_list_tools.completed";

    /// <summary>Whether this is a response.mcp_call_arguments.done event.</summary>
    [JsonIgnore] public bool IsMcpCallArgumentsDone => Type == "response.mcp_call_arguments.done";

    /// <summary>Whether this is a response.mcp_call.completed event.</summary>
    [JsonIgnore] public bool IsMcpCallCompleted => Type == "response.mcp_call.completed";

    /// <summary>Whether this is a response.mcp_call.failed event.</summary>
    [JsonIgnore] public bool IsMcpCallFailed => Type == "response.mcp_call.failed";
}

/// <summary>
/// Session information returned in session.created and session.updated events.
/// </summary>
public sealed class RealtimeSessionInfo
{
    /// <summary>Session ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Object type (e.g. "realtime.session").</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Model being used.</summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Session voice.</summary>
    [JsonPropertyName("voice")]
    public string? Voice { get; set; }

    /// <summary>Session instructions.</summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }
}

/// <summary>
/// Conversation info returned in conversation.created events.
/// </summary>
public sealed class RealtimeConversationInfo
{
    /// <summary>Conversation ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Object type (e.g. "realtime.conversation").</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Response info returned in response.created and response.done events.
/// </summary>
public sealed class RealtimeResponseInfo
{
    /// <summary>Response ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Object type.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Response status (e.g. "in_progress", "completed").</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Error details from an error event.
/// </summary>
public sealed class RealtimeError
{
    /// <summary>Error type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Human-readable error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Parameter that caused the error.</summary>
    [JsonPropertyName("param")]
    public string? Param { get; set; }
}
