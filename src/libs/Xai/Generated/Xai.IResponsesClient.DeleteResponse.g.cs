#nullable enable

namespace Xai
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Delete a stored response<br/>
        /// Deletes a previously stored model response.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.DeleteResponseResult> DeleteResponseAsync(
            string responseId,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a stored response<br/>
        /// Deletes a previously stored model response.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.AutoSDKHttpResponse<global::Xai.DeleteResponseResult>> DeleteResponseAsResponseAsync(
            string responseId,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}