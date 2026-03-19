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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.DeleteResponseResult> DeleteResponseAsync(
            string responseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}