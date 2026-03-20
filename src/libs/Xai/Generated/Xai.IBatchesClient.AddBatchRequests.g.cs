#nullable enable

namespace Xai
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Add requests to a batch<br/>
        /// Adds one or more requests to an existing batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.BatchObject> AddBatchRequestsAsync(
            string batchId,

            global::Xai.AddBatchRequestsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add requests to a batch<br/>
        /// Adds one or more requests to an existing batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="batchRequests"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.BatchObject> AddBatchRequestsAsync(
            string batchId,
            global::System.Collections.Generic.IList<global::Xai.BatchRequestItem> batchRequests,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}