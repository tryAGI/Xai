
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public long? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// Model fingerprint for versioning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }

        /// <summary>
        /// Model version string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Supported input modalities (e.g. text, image).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        public global::System.Collections.Generic.IList<string>? InputModalities { get; set; }

        /// <summary>
        /// Supported output modalities (e.g. text, image, video).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<string>? OutputModalities { get; set; }

        /// <summary>
        /// Price per input text token in billionths of a dollar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_text_token_price")]
        public long? PromptTextTokenPrice { get; set; }

        /// <summary>
        /// Price per cached input text token in billionths of a dollar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_prompt_text_token_price")]
        public long? CachedPromptTextTokenPrice { get; set; }

        /// <summary>
        /// Price per input image token in billionths of a dollar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_image_token_price")]
        public long? PromptImageTokenPrice { get; set; }

        /// <summary>
        /// Price per output text token in billionths of a dollar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_text_token_price")]
        public long? CompletionTextTokenPrice { get; set; }

        /// <summary>
        /// Price per search query in billionths of a dollar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_price")]
        public long? SearchPrice { get; set; }

        /// <summary>
        /// Price per image generation in billionths of a dollar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_price")]
        public long? ImagePrice { get; set; }

        /// <summary>
        /// Maximum prompt length in characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_length")]
        public int? MaxPromptLength { get; set; }

        /// <summary>
        /// Alternative model identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="created"></param>
        /// <param name="ownedBy"></param>
        /// <param name="fingerprint">
        /// Model fingerprint for versioning.
        /// </param>
        /// <param name="version">
        /// Model version string.
        /// </param>
        /// <param name="inputModalities">
        /// Supported input modalities (e.g. text, image).
        /// </param>
        /// <param name="outputModalities">
        /// Supported output modalities (e.g. text, image, video).
        /// </param>
        /// <param name="promptTextTokenPrice">
        /// Price per input text token in billionths of a dollar.
        /// </param>
        /// <param name="cachedPromptTextTokenPrice">
        /// Price per cached input text token in billionths of a dollar.
        /// </param>
        /// <param name="promptImageTokenPrice">
        /// Price per input image token in billionths of a dollar.
        /// </param>
        /// <param name="completionTextTokenPrice">
        /// Price per output text token in billionths of a dollar.
        /// </param>
        /// <param name="searchPrice">
        /// Price per search query in billionths of a dollar.
        /// </param>
        /// <param name="imagePrice">
        /// Price per image generation in billionths of a dollar.
        /// </param>
        /// <param name="maxPromptLength">
        /// Maximum prompt length in characters.
        /// </param>
        /// <param name="aliases">
        /// Alternative model identifiers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string? id,
            string? @object,
            long? created,
            string? ownedBy,
            string? fingerprint,
            string? version,
            global::System.Collections.Generic.IList<string>? inputModalities,
            global::System.Collections.Generic.IList<string>? outputModalities,
            long? promptTextTokenPrice,
            long? cachedPromptTextTokenPrice,
            long? promptImageTokenPrice,
            long? completionTextTokenPrice,
            long? searchPrice,
            long? imagePrice,
            int? maxPromptLength,
            global::System.Collections.Generic.IList<string>? aliases)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.OwnedBy = ownedBy;
            this.Fingerprint = fingerprint;
            this.Version = version;
            this.InputModalities = inputModalities;
            this.OutputModalities = outputModalities;
            this.PromptTextTokenPrice = promptTextTokenPrice;
            this.CachedPromptTextTokenPrice = cachedPromptTextTokenPrice;
            this.PromptImageTokenPrice = promptImageTokenPrice;
            this.CompletionTextTokenPrice = completionTextTokenPrice;
            this.SearchPrice = searchPrice;
            this.ImagePrice = imagePrice;
            this.MaxPromptLength = maxPromptLength;
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }

    }
}