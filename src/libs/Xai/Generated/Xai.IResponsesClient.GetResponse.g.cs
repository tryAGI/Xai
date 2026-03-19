#nullable enable

namespace Xai
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Get a stored response<br/>
        /// Retrieves a previously stored model response.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ResponseObject> GetResponseAsync(
            string responseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}