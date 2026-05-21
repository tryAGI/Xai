
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadFileRequest
    {
        /// <summary>
        /// The file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The intended purpose of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadFileRequest(
            byte[] file,
            string filename,
            string purpose)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest" /> class.
        /// </summary>
        public UploadFileRequest()
        {
        }

    }
}