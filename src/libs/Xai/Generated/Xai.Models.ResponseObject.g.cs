
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseObject
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.ResponseObjectStatusJsonConverter))]
        public global::Xai.ResponseObjectStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::Xai.ResponseOutputItem>? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Xai.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseObject" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="model"></param>
        /// <param name="status"></param>
        /// <param name="output"></param>
        /// <param name="usage"></param>
        /// <param name="store"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseObject(
            string? id,
            string? @object,
            long? createdAt,
            string? model,
            global::Xai.ResponseObjectStatus? status,
            global::System.Collections.Generic.IList<global::Xai.ResponseOutputItem>? output,
            global::Xai.CompletionUsage? usage,
            bool? store)
        {
            this.Id = id;
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Model = model;
            this.Status = status;
            this.Output = output;
            this.Usage = usage;
            this.Store = store;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseObject" /> class.
        /// </summary>
        public ResponseObject()
        {
        }
    }
}