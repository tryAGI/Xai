
#nullable enable

namespace Xai
{
    /// <summary>
    /// Reasoning configuration.
    /// </summary>
    public sealed partial class CreateResponseRequestReasoning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateResponseRequestReasoningEffortJsonConverter))]
        public global::Xai.CreateResponseRequestReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequestReasoning" /> class.
        /// </summary>
        /// <param name="effort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseRequestReasoning(
            global::Xai.CreateResponseRequestReasoningEffort? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequestReasoning" /> class.
        /// </summary>
        public CreateResponseRequestReasoning()
        {
        }
    }
}