
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmbeddingResponseUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingResponseUsage" /> class.
        /// </summary>
        /// <param name="promptTokens"></param>
        /// <param name="totalTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingResponseUsage(
            int? promptTokens,
            int? totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingResponseUsage" /> class.
        /// </summary>
        public CreateEmbeddingResponseUsage()
        {
        }
    }
}