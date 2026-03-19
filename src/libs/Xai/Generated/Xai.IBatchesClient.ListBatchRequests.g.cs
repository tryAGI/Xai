#nullable enable

namespace Xai
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// List batch requests<br/>
        /// Lists the requests in a batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="pageSize"></param>
        /// <param name="paginationToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ListBatchRequestsResponse> ListBatchRequestsAsync(
            string batchId,
            int? pageSize = default,
            string? paginationToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}