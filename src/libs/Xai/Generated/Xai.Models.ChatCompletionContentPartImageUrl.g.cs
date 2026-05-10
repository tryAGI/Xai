
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartImageUrl
    {
        /// <summary>
        /// The URL of the image or a base64 data URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.ChatCompletionContentPartImageUrlDetailJsonConverter))]
        public global::Xai.ChatCompletionContentPartImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the image or a base64 data URI.
        /// </param>
        /// <param name="detail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartImageUrl(
            string? url,
            global::Xai.ChatCompletionContentPartImageUrlDetail? detail)
        {
            this.Url = url;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageUrl" /> class.
        /// </summary>
        public ChatCompletionContentPartImageUrl()
        {
        }

    }
}