#nullable enable

namespace Xai
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Search documents<br/>
        /// Executes a query across collection documents using keyword, semantic, or hybrid search.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.SearchDocumentsResponse> SearchDocumentsAsync(

            global::Xai.SearchDocumentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search documents<br/>
        /// Executes a query across collection documents using keyword, semantic, or hybrid search.
        /// </summary>
        /// <param name="query">
        /// The search query.
        /// </param>
        /// <param name="collectionIds">
        /// Collection IDs to search across.
        /// </param>
        /// <param name="mode">
        /// Search mode.<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="maxNumResults">
        /// Maximum number of results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.SearchDocumentsResponse> SearchDocumentsAsync(
            string query,
            global::System.Collections.Generic.IList<string> collectionIds,
            global::Xai.SearchDocumentsRequestMode? mode = default,
            int? maxNumResults = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}