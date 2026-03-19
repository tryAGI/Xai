#nullable enable

namespace Xai
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Cancel a batch<br/>
        /// Cancels a batch that is still processing.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.BatchObject> CancelBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}