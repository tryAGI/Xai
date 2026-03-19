
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchDocumentsRequest
    {
        /// <summary>
        /// The search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Collection IDs to search across.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// Search mode.<br/>
        /// Default Value: hybrid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.SearchDocumentsRequestModeJsonConverter))]
        public global::Xai.SearchDocumentsRequestMode? Mode { get; set; }

        /// <summary>
        /// Maximum number of results to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDocumentsRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchDocumentsRequest(
            string query,
            global::System.Collections.Generic.IList<string> collectionIds,
            global::Xai.SearchDocumentsRequestMode? mode,
            int? maxNumResults)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.CollectionIds = collectionIds ?? throw new global::System.ArgumentNullException(nameof(collectionIds));
            this.Mode = mode;
            this.MaxNumResults = maxNumResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDocumentsRequest" /> class.
        /// </summary>
        public SearchDocumentsRequest()
        {
        }
    }
}