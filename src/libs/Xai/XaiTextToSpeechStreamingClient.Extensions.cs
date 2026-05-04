using System.Globalization;
using System.Text;

namespace Xai.TextToSpeech;

public sealed partial class XaiTextToSpeechStreamingClient
{
    /// <summary>
    /// Connects to the Streaming Text to Speech WebSocket endpoint with synthesis options encoded as query parameters.
    /// </summary>
    /// <param name="language">BCP-47 language code or auto.</param>
    /// <param name="voice">Built-in voice ID or custom voice ID.</param>
    /// <param name="codec">Audio codec: mp3, wav, pcm, mulaw, ulaw, or alaw.</param>
    /// <param name="sampleRate">Audio sample rate.</param>
    /// <param name="bitRate">MP3 bit rate.</param>
    /// <param name="optimizeStreamingLatency">Latency optimization level.</param>
    /// <param name="textNormalization">Whether to normalize text before synthesis.</param>
    /// <param name="additionalHeaders">Additional WebSocket request headers.</param>
    /// <param name="additionalSubProtocols">Additional WebSocket subprotocols.</param>
    /// <param name="keepAliveInterval">WebSocket keep-alive interval.</param>
    /// <param name="connectTimeout">Optional connection timeout.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    public global::System.Threading.Tasks.Task ConnectAsync(
        string language,
        string? voice = "eve",
        string? codec = "mp3",
        int? sampleRate = null,
        int? bitRate = null,
        int? optimizeStreamingLatency = null,
        bool? textNormalization = null,
        global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
        global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
        global::System.TimeSpan? keepAliveInterval = null,
        global::System.TimeSpan? connectTimeout = null,
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(language))
        {
            throw new global::System.ArgumentException("A language value is required.", nameof(language));
        }

        var uri = BuildStreamingUri(
            language,
            voice,
            codec,
            sampleRate,
            bitRate,
            optimizeStreamingLatency,
            textNormalization);

        return ConnectAsync(
            uri,
            additionalHeaders,
            additionalSubProtocols,
            keepAliveInterval,
            connectTimeout,
            cancellationToken);
    }

    private static global::System.Uri BuildStreamingUri(
        string language,
        string? voice,
        string? codec,
        int? sampleRate,
        int? bitRate,
        int? optimizeStreamingLatency,
        bool? textNormalization)
    {
        var query = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
        {
            new("language", language),
        };

        AddOptionalQueryParameter(query, "voice", voice);
        AddOptionalQueryParameter(query, "codec", codec);

        if (sampleRate is not null)
        {
            query.Add(new("sample_rate", sampleRate.Value.ToString(CultureInfo.InvariantCulture)));
        }

        if (bitRate is not null)
        {
            query.Add(new("bit_rate", bitRate.Value.ToString(CultureInfo.InvariantCulture)));
        }

        if (optimizeStreamingLatency is not null)
        {
            query.Add(new("optimize_streaming_latency", optimizeStreamingLatency.Value.ToString(CultureInfo.InvariantCulture)));
        }

        if (textNormalization is not null)
        {
            query.Add(new("text_normalization", textNormalization.Value ? "true" : "false"));
        }

        var builder = new StringBuilder(DefaultBaseUrl);
        builder.Append('?');
        builder.AppendJoin(
            '&',
            query.Select(static parameter =>
                $"{Uri.EscapeDataString(parameter.Key)}={Uri.EscapeDataString(parameter.Value)}"));

        return new global::System.Uri(builder.ToString(), global::System.UriKind.Absolute);
    }

    private static void AddOptionalQueryParameter(
        global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> query,
        string name,
        string? value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            query.Add(new(name, value));
        }
    }
}
