
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoResponse
    {
        /// <summary>
        /// ID for polling the video generation status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// ID for polling the video generation status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoResponse(
            string? requestId)
        {
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoResponse" /> class.
        /// </summary>
        public CreateVideoResponse()
        {
        }
    }
}