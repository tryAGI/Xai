
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionUsageCompletionTokensDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsageCompletionTokensDetails" /> class.
        /// </summary>
        /// <param name="reasoningTokens"></param>
        /// <param name="textTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionUsageCompletionTokensDetails(
            int? reasoningTokens,
            int? textTokens)
        {
            this.ReasoningTokens = reasoningTokens;
            this.TextTokens = textTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsageCompletionTokensDetails" /> class.
        /// </summary>
        public CompletionUsageCompletionTokensDetails()
        {
        }
    }
}