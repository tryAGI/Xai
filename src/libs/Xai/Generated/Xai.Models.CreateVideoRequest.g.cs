
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoRequest
    {
        /// <summary>
        /// The model to use for video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A text description of the desired video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Duration in seconds (1-15 for generation, max 8.7s source for editing).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Aspect ratio of the generated video. Defaults to 16:9.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateVideoRequestAspectRatioJsonConverter))]
        public global::Xai.CreateVideoRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Resolution of the generated video.<br/>
        /// Default Value: 480p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateVideoRequestResolutionJsonConverter))]
        public global::Xai.CreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Source video URL for editing operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Source image URL for image-to-video generation (public URL or base64 data URI).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for video generation.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired video.
        /// </param>
        /// <param name="duration">
        /// Duration in seconds (1-15 for generation, max 8.7s source for editing).
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the generated video. Defaults to 16:9.
        /// </param>
        /// <param name="resolution">
        /// Resolution of the generated video.<br/>
        /// Default Value: 480p
        /// </param>
        /// <param name="videoUrl">
        /// Source video URL for editing operations.
        /// </param>
        /// <param name="imageUrl">
        /// Source image URL for image-to-video generation (public URL or base64 data URI).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoRequest(
            string model,
            string prompt,
            int? duration,
            global::Xai.CreateVideoRequestAspectRatio? aspectRatio,
            global::Xai.CreateVideoRequestResolution? resolution,
            string? videoUrl,
            string? imageUrl)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Duration = duration;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.VideoUrl = videoUrl;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequest" /> class.
        /// </summary>
        public CreateVideoRequest()
        {
        }
    }
}