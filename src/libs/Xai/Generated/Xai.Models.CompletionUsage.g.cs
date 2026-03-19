
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::Xai.CompletionUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        public global::Xai.CompletionUsageCompletionTokensDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsage" /> class.
        /// </summary>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="promptTokensDetails"></param>
        /// <param name="completionTokensDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionUsage(
            int? promptTokens,
            int? completionTokens,
            int? totalTokens,
            global::Xai.CompletionUsagePromptTokensDetails? promptTokensDetails,
            global::Xai.CompletionUsageCompletionTokensDetails? completionTokensDetails)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.CompletionTokensDetails = completionTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsage" /> class.
        /// </summary>
        public CompletionUsage()
        {
        }
    }
}