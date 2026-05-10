
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchObjectCostBreakdown
    {
        /// <summary>
        /// Total cost in billionths of a dollar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_usd_ticks")]
        public long? TotalCostUsdTicks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectCostBreakdown" /> class.
        /// </summary>
        /// <param name="totalCostUsdTicks">
        /// Total cost in billionths of a dollar.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectCostBreakdown(
            long? totalCostUsdTicks)
        {
            this.TotalCostUsdTicks = totalCostUsdTicks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectCostBreakdown" /> class.
        /// </summary>
        public BatchObjectCostBreakdown()
        {
        }

    }
}