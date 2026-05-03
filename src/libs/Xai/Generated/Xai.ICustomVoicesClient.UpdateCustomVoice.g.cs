#nullable enable

namespace Xai
{
    public partial interface ICustomVoicesClient
    {
        /// <summary>
        /// Update custom voice metadata<br/>
        /// Updates metadata for a custom voice. The underlying reference audio cannot be changed.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CustomVoice> UpdateCustomVoiceAsync(
            string voiceId,

            global::Xai.UpdateCustomVoiceRequest request,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update custom voice metadata<br/>
        /// Updates metadata for a custom voice. The underlying reference audio cannot be changed.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="gender"></param>
        /// <param name="accent"></param>
        /// <param name="age"></param>
        /// <param name="language"></param>
        /// <param name="useCase"></param>
        /// <param name="tone"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CustomVoice> UpdateCustomVoiceAsync(
            string voiceId,
            string? name = default,
            string? description = default,
            global::Xai.UpdateCustomVoiceRequestGender? gender = default,
            string? accent = default,
            global::Xai.UpdateCustomVoiceRequestAge? age = default,
            string? language = default,
            global::Xai.UpdateCustomVoiceRequestUseCase? useCase = default,
            global::Xai.UpdateCustomVoiceRequestTone? tone = default,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}