
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddBatchRequestsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Xai.BatchRequestItem> BatchRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBatchRequestsRequest" /> class.
        /// </summary>
        /// <param name="batchRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddBatchRequestsRequest(
            global::System.Collections.Generic.IList<global::Xai.BatchRequestItem> batchRequests)
        {
            this.BatchRequests = batchRequests ?? throw new global::System.ArgumentNullException(nameof(batchRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBatchRequestsRequest" /> class.
        /// </summary>
        public AddBatchRequestsRequest()
        {
        }
    }
}