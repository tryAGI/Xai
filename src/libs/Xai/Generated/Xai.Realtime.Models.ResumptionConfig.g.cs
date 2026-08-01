
#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// Conversation resumption configuration.
    /// </summary>
    public sealed partial class ResumptionConfig
    {
        /// <summary>
        /// Whether the conversation can be resumed after reconnecting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumptionConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the conversation can be resumed after reconnecting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumptionConfig(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumptionConfig" /> class.
        /// </summary>
        public ResumptionConfig()
        {
        }

    }
}