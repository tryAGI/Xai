
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionStreamChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::Xai.ChatCompletionStreamDelta? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.ChatCompletionStreamChoiceFinishReasonJsonConverter))]
        public global::Xai.ChatCompletionStreamChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamChoice" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionStreamChoice(
            int? index,
            global::Xai.ChatCompletionStreamDelta? delta,
            global::Xai.ChatCompletionStreamChoiceFinishReason? finishReason)
        {
            this.Index = index;
            this.Delta = delta;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamChoice" /> class.
        /// </summary>
        public ChatCompletionStreamChoice()
        {
        }
    }
}