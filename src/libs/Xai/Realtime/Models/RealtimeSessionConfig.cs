#nullable enable

using System.Text.Json.Serialization;

namespace Xai;

/// <summary>
/// Configuration for an xAI Realtime session, sent via session.update client events.
/// </summary>
public sealed class RealtimeSessionConfig
{
    /// <summary>
    /// System-level instructions for the agent.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    /// <summary>
    /// Voice to use for audio output: Eve, Ara, Rex, Sal, or Leo.
    /// </summary>
    [JsonPropertyName("voice")]
    public string? Voice { get; set; }

    /// <summary>
    /// Turn detection configuration, or null for manual mode.
    /// </summary>
    [JsonPropertyName("turn_detection")]
    public RealtimeTurnDetection? TurnDetection { get; set; }

    /// <summary>
    /// Audio format configuration.
    /// </summary>
    [JsonPropertyName("audio")]
    public RealtimeAudioConfig? Audio { get; set; }

    /// <summary>
    /// Tools available to the agent.
    /// </summary>
    [JsonPropertyName("tools")]
    public RealtimeTool[]? Tools { get; set; }

    /// <summary>
    /// Response modalities (e.g. ["text", "audio"]).
    /// </summary>
    [JsonPropertyName("modalities")]
    public string[]? Modalities { get; set; }
}
