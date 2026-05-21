
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResult
    {
        /// <summary>
        /// The matching text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Relevance score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        public string? CollectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="content">
        /// The matching text content.
        /// </param>
        /// <param name="score">
        /// Relevance score.
        /// </param>
        /// <param name="fileId"></param>
        /// <param name="collectionId"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResult(
            string? content,
            double? score,
            string? fileId,
            string? collectionId,
            object? metadata)
        {
            this.Content = content;
            this.Score = score;
            this.FileId = fileId;
            this.CollectionId = collectionId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        public SearchResult()
        {
        }

    }
}