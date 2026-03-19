#nullable enable

namespace Xai
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get deferred completion result<br/>
        /// Retrieves the result of a deferred chat completion request.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CreateChatCompletionResponse> GetDeferredCompletionAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}