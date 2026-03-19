
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public long? Bytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileObject" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="bytes"></param>
        /// <param name="createdAt"></param>
        /// <param name="filename"></param>
        /// <param name="purpose"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileObject(
            string? id,
            string? @object,
            long? bytes,
            long? createdAt,
            string? filename,
            string? purpose)
        {
            this.Id = id;
            this.Object = @object;
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileObject" /> class.
        /// </summary>
        public FileObject()
        {
        }
    }
}