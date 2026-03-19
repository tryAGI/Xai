
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchRequestMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_request_id")]
        public string? BatchRequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.BatchRequestMetadataStateJsonConverter))]
        public global::Xai.BatchRequestMetadataState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestMetadata" /> class.
        /// </summary>
        /// <param name="batchRequestId"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRequestMetadata(
            string? batchRequestId,
            global::Xai.BatchRequestMetadataState? state)
        {
            this.BatchRequestId = batchRequestId;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestMetadata" /> class.
        /// </summary>
        public BatchRequestMetadata()
        {
        }
    }
}