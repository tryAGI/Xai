#nullable enable

namespace Xai
{
    public partial interface ICustomVoicesClient
    {
        /// <summary>
        /// Get custom voice<br/>
        /// Gets metadata for a single custom voice.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CustomVoice> GetCustomVoiceAsync(
            string voiceId,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}