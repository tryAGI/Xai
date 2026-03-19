#nullable enable

using System.Text.Json.Serialization;

namespace Xai;

/// <summary>
/// A conversation item in the Realtime session (message or function output).
/// </summary>
public sealed class RealtimeConversationItem
{
    /// <summary>
    /// Item type: "message" or "function_call_output".
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Item ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Role: "user" or "assistant" (for message items).
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// Item status (e.g. "completed", "in_progress").
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Content parts (for message items).
    /// </summary>
    [JsonPropertyName("content")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1819")]
    public RealtimeContentPart[]? Content { get; set; }

    /// <summary>
    /// Function call ID (for function_call_output items).
    /// </summary>
    [JsonPropertyName("call_id")]
    public string? CallId { get; set; }

    /// <summary>
    /// Function output JSON string (for function_call_output items).
    /// </summary>
    [JsonPropertyName("output")]
    public string? Output { get; set; }
}

/// <summary>
/// A content part within a conversation item.
/// </summary>
public sealed class RealtimeContentPart
{
    /// <summary>
    /// Content type: "input_text", "text", "audio".
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Text content.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// Audio transcript.
    /// </summary>
    [JsonPropertyName("transcript")]
    public string? Transcript { get; set; }
}
