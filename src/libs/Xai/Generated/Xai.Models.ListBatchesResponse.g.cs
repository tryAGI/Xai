
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBatchesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batches")]
        public global::System.Collections.Generic.IList<global::Xai.BatchObject>? Batches { get; set; }

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
        /// Initializes a new instance of the <see cref="ListBatchesResponse" /> class.
        /// </summary>
        /// <param name="batches"></param>
        /// <param name="paginationToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBatchesResponse(
            global::System.Collections.Generic.IList<global::Xai.BatchObject>? batches,
            string? paginationToken)
        {
            this.Batches = batches;
            this.PaginationToken = paginationToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchesResponse" /> class.
        /// </summary>
        public ListBatchesResponse()
        {
        }
    }
}