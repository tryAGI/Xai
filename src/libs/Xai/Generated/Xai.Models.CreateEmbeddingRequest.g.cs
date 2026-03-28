
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmbeddingRequest
    {
        /// <summary>
        /// ID of the model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Input text to embed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Xai.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; }

        /// <summary>
        /// The format to return the embeddings in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter))]
        public global::Xai.CreateEmbeddingRequestEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="input">
        /// Input text to embed.
        /// </param>
        /// <param name="encodingFormat">
        /// The format to return the embeddings in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingRequest(
            string model,
            global::Xai.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::Xai.CreateEmbeddingRequestEncodingFormat? encodingFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.EncodingFormat = encodingFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingRequest" /> class.
        /// </summary>
        public CreateEmbeddingRequest()
        {
        }
    }
}