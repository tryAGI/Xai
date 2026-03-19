#nullable enable

namespace Xai
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Get video generation status<br/>
        /// Polls the status of a video generation request.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.VideoStatusResponse> GetVideoStatusAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}