
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBatchRequestsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_request_metadata")]
        public global::System.Collections.Generic.IList<global::Xai.BatchRequestMetadata>? BatchRequestMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_token")]
        public string? PaginationToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchRequestsResponse" /> class.
        /// </summary>
        /// <param name="batchRequestMetadata"></param>
        /// <param name="paginationToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBatchRequestsResponse(
            global::System.Collections.Generic.IList<global::Xai.BatchRequestMetadata>? batchRequestMetadata,
            string? paginationToken)
        {
            this.BatchRequestMetadata = batchRequestMetadata;
            this.PaginationToken = paginationToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchRequestsResponse" /> class.
        /// </summary>
        public ListBatchRequestsResponse()
        {
        }
    }
}