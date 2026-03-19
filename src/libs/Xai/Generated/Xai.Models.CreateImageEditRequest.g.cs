
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageEditRequest
    {
        /// <summary>
        /// The model to use for image editing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A text description of the desired edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::Xai.ImageInput? Image { get; set; }

        /// <summary>
        /// Source images (up to 5).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Xai.ImageInput>? Images { get; set; }

        /// <summary>
        /// Aspect ratio override for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateImageEditRequestAspectRatioJsonConverter))]
        public global::Xai.CreateImageEditRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateImageEditRequestResolutionJsonConverter))]
        public global::Xai.CreateImageEditRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Default Value: url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter))]
        public global::Xai.CreateImageEditRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageEditRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for image editing.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired edit.
        /// </param>
        /// <param name="image"></param>
        /// <param name="images">
        /// Source images (up to 5).
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio override for the output.
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="responseFormat">
        /// Default Value: url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageEditRequest(
            string model,
            string prompt,
            global::Xai.ImageInput? image,
            global::System.Collections.Generic.IList<global::Xai.ImageInput>? images,
            global::Xai.CreateImageEditRequestAspectRatio? aspectRatio,
            global::Xai.CreateImageEditRequestResolution? resolution,
            global::Xai.CreateImageEditRequestResponseFormat? responseFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Image = image;
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageEditRequest" /> class.
        /// </summary>
        public CreateImageEditRequest()
        {
        }
    }
}