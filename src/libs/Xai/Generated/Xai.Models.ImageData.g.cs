
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageData
    {
        /// <summary>
        /// Temporary URL of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Base64-encoded image data (if b64_json response_format was requested).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        public string? B64Json { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        /// <param name="url">
        /// Temporary URL of the generated image.
        /// </param>
        /// <param name="b64Json">
        /// Base64-encoded image data (if b64_json response_format was requested).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageData(
            string? url,
            string? b64Json)
        {
            this.Url = url;
            this.B64Json = b64Json;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        public ImageData()
        {
        }

    }
}