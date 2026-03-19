
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPart
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.ChatCompletionContentPartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Xai.ChatCompletionContentPartType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::Xai.ChatCompletionContentPartImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPart" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPart(
            global::Xai.ChatCompletionContentPartType type,
            string? text,
            global::Xai.ChatCompletionContentPartImageUrl? imageUrl)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPart" /> class.
        /// </summary>
        public ChatCompletionContentPart()
        {
        }
    }
}