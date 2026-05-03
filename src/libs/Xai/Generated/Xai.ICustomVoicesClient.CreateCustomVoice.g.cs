#nullable enable

namespace Xai
{
    public partial interface ICustomVoicesClient
    {
        /// <summary>
        /// Create a custom voice<br/>
        /// Creates a custom voice from a reference audio clip. This endpoint is gated to teams on an Enterprise plan.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CustomVoice> CreateCustomVoiceAsync(

            global::Xai.CreateCustomVoiceRequest request,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a custom voice<br/>
        /// Creates a custom voice from a reference audio clip. This endpoint is gated to teams on an Enterprise plan.
        /// </summary>
        /// <param name="file">
        /// Reference audio file. Maximum duration is 120 seconds.
        /// </param>
        /// <param name="filename">
        /// Reference audio file. Maximum duration is 120 seconds.
        /// </param>
        /// <param name="name">
        /// Display name for the voice.
        /// </param>
        /// <param name="description">
        /// Free-text description of the voice.
        /// </param>
        /// <param name="gender">
        /// Voice gender label.
        /// </param>
        /// <param name="accent">
        /// Free-text accent label.
        /// </param>
        /// <param name="age">
        /// Voice age label.
        /// </param>
        /// <param name="language">
        /// ISO 639 or BCP-47-style language code.
        /// </param>
        /// <param name="useCase">
        /// Intended use case label.
        /// </param>
        /// <param name="tone">
        /// Tonal label.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CustomVoice> CreateCustomVoiceAsync(
            byte[] file,
            string filename,
            string? name = default,
            string? description = default,
            global::Xai.CreateCustomVoiceRequestGender? gender = default,
            string? accent = default,
            global::Xai.CreateCustomVoiceRequestAge? age = default,
            string? language = default,
            global::Xai.CreateCustomVoiceRequestUseCase? useCase = default,
            global::Xai.CreateCustomVoiceRequestTone? tone = default,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}