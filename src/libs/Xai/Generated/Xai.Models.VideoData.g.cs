
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoData
    {
        /// <summary>
        /// Temporary URL of the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Duration of the video in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Whether the video was flagged by content moderation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respect_moderation")]
        public bool? RespectModeration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoData" /> class.
        /// </summary>
        /// <param name="url">
        /// Temporary URL of the generated video.
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.
        /// </param>
        /// <param name="respectModeration">
        /// Whether the video was flagged by content moderation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoData(
            string? url,
            int? duration,
            bool? respectModeration)
        {
            this.Url = url;
            this.Duration = duration;
            this.RespectModeration = respectModeration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoData" /> class.
        /// </summary>
        public VideoData()
        {
        }

    }
}