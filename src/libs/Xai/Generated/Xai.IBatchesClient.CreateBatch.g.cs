#nullable enable

namespace Xai
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Create a batch<br/>
        /// Creates a new batch for processing multiple requests.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.BatchObject> CreateBatchAsync(

            global::Xai.CreateBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Creates a new batch for processing multiple requests.
        /// </summary>
        /// <param name="name">
        /// A name for the batch.
        /// </param>
        /// <param name="inputFileId">
        /// Optional file ID containing batch requests (uploaded via /files).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.BatchObject> CreateBatchAsync(
            string name,
            string? inputFileId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}