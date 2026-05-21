#nullable enable

namespace Xai
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// List batches<br/>
        /// Lists all batches.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="paginationToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ListBatchesResponse> ListBatchesAsync(
            int? pageSize = default,
            string? paginationToken = default,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List batches<br/>
        /// Lists all batches.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="paginationToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.AutoSDKHttpResponse<global::Xai.ListBatchesResponse>> ListBatchesAsResponseAsync(
            int? pageSize = default,
            string? paginationToken = default,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}