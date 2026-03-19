
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageRequest
    {
        /// <summary>
        /// The model to use for image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A text description of the desired image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Number of images to generate (max 10).<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Aspect ratio of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateImageRequestAspectRatioJsonConverter))]
        public global::Xai.CreateImageRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Resolution of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateImageRequestResolutionJsonConverter))]
        public global::Xai.CreateImageRequestResolution? Resolution { get; set; }

        /// <summary>
        /// The format of the generated image.<br/>
        /// Default Value: url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateImageRequestResponseFormatJsonConverter))]
        public global::Xai.CreateImageRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for image generation.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired image.
        /// </param>
        /// <param name="n">
        /// Number of images to generate (max 10).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the generated image.
        /// </param>
        /// <param name="resolution">
        /// Resolution of the generated image.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the generated image.<br/>
        /// Default Value: url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageRequest(
            string model,
            string prompt,
            int? n,
            global::Xai.CreateImageRequestAspectRatio? aspectRatio,
            global::Xai.CreateImageRequestResolution? resolution,
            global::Xai.CreateImageRequestResponseFormat? responseFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.N = n;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        public CreateImageRequest()
        {
        }
    }
}