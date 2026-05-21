#nullable enable

namespace Xai
{
    public partial interface ICustomVoicesClient
    {
        /// <summary>
        /// Download custom voice reference audio<br/>
        /// Downloads the original reference audio for a custom voice.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetCustomVoiceAudioAsync(
            string voiceId,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download custom voice reference audio<br/>
        /// Downloads the original reference audio for a custom voice.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetCustomVoiceAudioAsStreamAsync(
            string voiceId,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download custom voice reference audio<br/>
        /// Downloads the original reference audio for a custom voice.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.AutoSDKHttpResponse<byte[]>> GetCustomVoiceAudioAsResponseAsync(
            string voiceId,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}