#nullable enable

namespace Xai
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Xai.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(

            global::Xai.CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a model response for the given chat conversation.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Xai.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
            string model,
            global::System.Collections.Generic.IList<global::Xai.ChatCompletionMessage> messages,
            double? temperature = default,
            double? topP = default,
            int? n = default,
            global::Xai.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            int? maxTokens = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            string? user = default,
            global::System.Collections.Generic.IList<global::Xai.ChatCompletionTool>? tools = default,
            global::Xai.OneOf<global::Xai.CreateChatCompletionRequestToolChoice?, global::Xai.ChatCompletionNamedToolChoice>? toolChoice = default,
            bool? parallelToolCalls = default,
            global::Xai.ResponseFormat? responseFormat = default,
            int? seed = default,
            bool? deferred = default,
            global::Xai.CreateChatCompletionRequestReasoningEffort? reasoningEffort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}