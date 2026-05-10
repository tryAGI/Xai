
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::Xai.BatchState? State { get; set; }

        /// <summary>
        /// Timestamp when the batch expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_breakdown")]
        public global::Xai.BatchObjectCostBreakdown? CostBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObject" /> class.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="name"></param>
        /// <param name="state"></param>
        /// <param name="expiresAt">
        /// Timestamp when the batch expires.
        /// </param>
        /// <param name="costBreakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObject(
            string? batchId,
            string? name,
            global::Xai.BatchState? state,
            string? expiresAt,
            global::Xai.BatchObjectCostBreakdown? costBreakdown)
        {
            this.BatchId = batchId;
            this.Name = name;
            this.State = state;
            this.ExpiresAt = expiresAt;
            this.CostBreakdown = costBreakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObject" /> class.
        /// </summary>
        public BatchObject()
        {
        }

    }
}