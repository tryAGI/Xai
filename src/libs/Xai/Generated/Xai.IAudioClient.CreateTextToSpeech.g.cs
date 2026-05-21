#nullable enable

namespace Xai
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create text-to-speech audio<br/>
        /// Converts text into speech audio. The voice_id can be a built-in TTS voice or a custom voice ID.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateTextToSpeechAsync(

            global::Xai.CreateTextToSpeechRequest request,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create text-to-speech audio<br/>
        /// Converts text into speech audio. The voice_id can be a built-in TTS voice or a custom voice ID.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateTextToSpeechAsStreamAsync(

            global::Xai.CreateTextToSpeechRequest request,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create text-to-speech audio<br/>
        /// Converts text into speech audio. The voice_id can be a built-in TTS voice or a custom voice ID.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.AutoSDKHttpResponse<byte[]>> CreateTextToSpeechAsResponseAsync(

            global::Xai.CreateTextToSpeechRequest request,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create text-to-speech audio<br/>
        /// Converts text into speech audio. The voice_id can be a built-in TTS voice or a custom voice ID.
        /// </summary>
        /// <param name="text">
        /// The text to convert to speech.
        /// </param>
        /// <param name="voiceId">
        /// Built-in voice ID or custom voice ID. Defaults to eve.
        /// </param>
        /// <param name="language">
        /// BCP-47 language code or auto for automatic language detection.
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="optimizeStreamingLatency">
        /// Latency optimization level for synthesis.
        /// </param>
        /// <param name="textNormalization">
        /// Whether to normalize written-form text into spoken-form before synthesis.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateTextToSpeechAsync(
            string text,
            string language,
            string? voiceId = default,
            global::Xai.TextToSpeechOutputFormat? outputFormat = default,
            int? optimizeStreamingLatency = default,
            bool? textNormalization = default,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}