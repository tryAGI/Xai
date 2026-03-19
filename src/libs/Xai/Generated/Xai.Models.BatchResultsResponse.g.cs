
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchResultsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        public global::System.Collections.Generic.IList<global::Xai.BatchResultSuccess>? Succeeded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public global::System.Collections.Generic.IList<global::Xai.BatchResultFailure>? Failed { get; set; }

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
        /// Initializes a new instance of the <see cref="BatchResultsResponse" /> class.
        /// </summary>
        /// <param name="succeeded"></param>
        /// <param name="failed"></param>
        /// <param name="paginationToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchResultsResponse(
            global::System.Collections.Generic.IList<global::Xai.BatchResultSuccess>? succeeded,
            global::System.Collections.Generic.IList<global::Xai.BatchResultFailure>? failed,
            string? paginationToken)
        {
            this.Succeeded = succeeded;
            this.Failed = failed;
            this.PaginationToken = paginationToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResultsResponse" /> class.
        /// </summary>
        public BatchResultsResponse()
        {
        }
    }
}