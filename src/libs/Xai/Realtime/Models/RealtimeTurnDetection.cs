#nullable enable

using System.Text.Json.Serialization;

namespace Xai;

/// <summary>
/// Server VAD turn detection configuration.
/// Set to null in <see cref="RealtimeSessionConfig.TurnDetection"/> for manual mode.
/// </summary>
public sealed class RealtimeTurnDetection
{
    /// <summary>
    /// Turn detection type. Use "server_vad" for automatic detection, or null for manual.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; } = "server_vad";

    /// <summary>
    /// VAD sensitivity threshold (0.1 - 0.9). Default is 0.85.
    /// </summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>
    /// Milliseconds of silence before ending a turn (0 - 10000).
    /// </summary>
    [JsonPropertyName("silence_duration_ms")]
    public int? SilenceDurationMs { get; set; }

    /// <summary>
    /// Milliseconds of audio to include before speech start (0 - 10000). Default is 333.
    /// </summary>
    [JsonPropertyName("prefix_padding_ms")]
    public int? PrefixPaddingMs { get; set; }
}
