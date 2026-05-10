
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoStatusResponse
    {
        /// <summary>
        /// Current status of the video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.VideoStatusResponseStatusJsonConverter))]
        public global::Xai.VideoStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::Xai.VideoData? Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoStatusResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Current status of the video generation.
        /// </param>
        /// <param name="video"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoStatusResponse(
            global::Xai.VideoStatusResponseStatus? status,
            global::Xai.VideoData? video,
            string? model)
        {
            this.Status = status;
            this.Video = video;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoStatusResponse" /> class.
        /// </summary>
        public VideoStatusResponse()
        {
        }

    }
}