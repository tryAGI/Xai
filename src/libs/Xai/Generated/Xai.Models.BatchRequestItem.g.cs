
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchRequestItem
    {
        /// <summary>
        /// A unique identifier for this request within the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BatchRequestId { get; set; }

        /// <summary>
        /// The request payload (e.g. chat_get_completion).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object BatchRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestItem" /> class.
        /// </summary>
        /// <param name="batchRequestId">
        /// A unique identifier for this request within the batch.
        /// </param>
        /// <param name="batchRequest">
        /// The request payload (e.g. chat_get_completion).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRequestItem(
            string batchRequestId,
            object batchRequest)
        {
            this.BatchRequestId = batchRequestId ?? throw new global::System.ArgumentNullException(nameof(batchRequestId));
            this.BatchRequest = batchRequest ?? throw new global::System.ArgumentNullException(nameof(batchRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestItem" /> class.
        /// </summary>
        public BatchRequestItem()
        {
        }

    }
}