
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionRequest
    {
        /// <summary>
        /// ID of the model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Xai.ChatCompletionMessage> Messages { get; set; }

        /// <summary>
        /// Sampling temperature (0-2).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Number of completions to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Whether to stream back partial progress.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Xai.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Penalizes new tokens based on whether they appear in the text so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Penalizes new tokens based on their existing frequency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        /// A unique identifier representing the end-user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// A list of tools the model may call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Xai.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.OneOfJsonConverter<global::Xai.CreateChatCompletionRequestToolChoice?, global::Xai.ChatCompletionNamedToolChoice>))]
        public global::Xai.OneOf<global::Xai.CreateChatCompletionRequestToolChoice?, global::Xai.ChatCompletionNamedToolChoice>? ToolChoice { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Xai.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// A seed for deterministic sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// If true, the request is processed asynchronously. Poll with GET /chat/deferred-completion/{request_id}.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deferred")]
        public bool? Deferred { get; set; }

        /// <summary>
        /// Controls the amount of reasoning effort for reasoning models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateChatCompletionRequestReasoningEffortJsonConverter))]
        public global::Xai.CreateChatCompletionRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0-2).
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling probability.
        /// </param>
        /// <param name="n">
        /// Number of completions to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.
        /// </param>
        /// <param name="presencePenalty">
        /// Penalizes new tokens based on whether they appear in the text so far.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Penalizes new tokens based on their existing frequency.
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing the end-user.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="seed">
        /// A seed for deterministic sampling.
        /// </param>
        /// <param name="deferred">
        /// If true, the request is processed asynchronously. Poll with GET /chat/deferred-completion/{request_id}.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="reasoningEffort">
        /// Controls the amount of reasoning effort for reasoning models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::Xai.ChatCompletionMessage> messages,
            double? temperature,
            double? topP,
            int? n,
            bool? stream,
            global::Xai.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            int? maxTokens,
            double? presencePenalty,
            double? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            string? user,
            global::System.Collections.Generic.IList<global::Xai.ChatCompletionTool>? tools,
            global::Xai.OneOf<global::Xai.CreateChatCompletionRequestToolChoice?, global::Xai.ChatCompletionNamedToolChoice>? toolChoice,
            bool? parallelToolCalls,
            global::Xai.ResponseFormat? responseFormat,
            int? seed,
            bool? deferred,
            global::Xai.CreateChatCompletionRequestReasoningEffort? reasoningEffort)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.Stream = stream;
            this.Stop = stop;
            this.MaxTokens = maxTokens;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.User = user;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.Deferred = deferred;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }
    }
}