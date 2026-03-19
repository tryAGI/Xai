
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingData" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="index"></param>
        /// <param name="embedding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingData(
            string? @object,
            int? index,
            global::System.Collections.Generic.IList<double>? embedding)
        {
            this.Object = @object;
            this.Index = index;
            this.Embedding = embedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingData" /> class.
        /// </summary>
        public EmbeddingData()
        {
        }
    }
}