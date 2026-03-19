#nullable enable

using System.Text.Json.Serialization;

namespace Xai;

/// <summary>
/// Audio format configuration for the Realtime session.
/// </summary>
public sealed class RealtimeAudioConfig
{
    /// <summary>
    /// Input audio format configuration.
    /// </summary>
    [JsonPropertyName("input")]
    public RealtimeAudioDirectionConfig? Input { get; set; }

    /// <summary>
    /// Output audio format configuration.
    /// </summary>
    [JsonPropertyName("output")]
    public RealtimeAudioDirectionConfig? Output { get; set; }
}

/// <summary>
/// Audio direction (input or output) configuration.
/// </summary>
public sealed class RealtimeAudioDirectionConfig
{
    /// <summary>
    /// Audio format specification.
    /// </summary>
    [JsonPropertyName("format")]
    public RealtimeAudioFormatConfig? Format { get; set; }
}

/// <summary>
/// Audio format specification.
/// </summary>
public sealed class RealtimeAudioFormatConfig
{
    /// <summary>
    /// Audio format type: "audio/pcm" (Linear16 little-endian), "audio/pcmu" (G.711 µ-law, 8kHz only), or "audio/pcma" (G.711 A-law, 8kHz only).
    /// Default is "audio/pcm".
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Sample rate in Hz. Supported: 8000, 16000, 22050, 24000, 32000, 44100, 48000.
    /// Default is 24000. Only 8000 is supported for pcmu/pcma.
    /// </summary>
    [JsonPropertyName("rate")]
    public int? Rate { get; set; }
}
