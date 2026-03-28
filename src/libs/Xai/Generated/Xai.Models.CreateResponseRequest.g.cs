
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponseRequest
    {
        /// <summary>
        /// ID of the model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The input messages for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Xai.ResponseInputMessage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Xai.OneOf<string, global::System.Collections.Generic.IList<global::Xai.ResponseInputMessage>> Input { get; set; }

        /// <summary>
        /// System instructions for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Whether to store the response for later retrieval.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Reasoning configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::Xai.CreateResponseRequestReasoning? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Xai.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="input">
        /// The input messages for the response.
        /// </param>
        /// <param name="instructions">
        /// System instructions for the response.
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="store">
        /// Whether to store the response for later retrieval.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration.
        /// </param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseRequest(
            string model,
            global::Xai.OneOf<string, global::System.Collections.Generic.IList<global::Xai.ResponseInputMessage>> input,
            string? instructions,
            double? temperature,
            double? topP,
            int? maxOutputTokens,
            bool? store,
            global::Xai.CreateResponseRequestReasoning? reasoning,
            global::System.Collections.Generic.IList<global::Xai.ChatCompletionTool>? tools)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Instructions = instructions;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxOutputTokens = maxOutputTokens;
            this.Store = store;
            this.Reasoning = reasoning;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequest" /> class.
        /// </summary>
        public CreateResponseRequest()
        {
        }
    }
}