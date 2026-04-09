
#nullable enable

namespace Xai
{
    public partial class ChatClient
    {


        private static readonly global::Xai.EndPointSecurityRequirement s_CreateChatCompletionAsStreamSecurityRequirement0 =
            new global::Xai.EndPointSecurityRequirement
            {
                Authorizations = new global::Xai.EndPointAuthorizationRequirement[]
                {                    new global::Xai.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Xai.EndPointSecurityRequirement[] s_CreateChatCompletionAsStreamSecurityRequirements =
            new global::Xai.EndPointSecurityRequirement[]
            {                s_CreateChatCompletionAsStreamSecurityRequirement0,
            };
        partial void PrepareCreateChatCompletionAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Xai.CreateChatCompletionRequest request);
        partial void PrepareCreateChatCompletionAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Xai.CreateChatCompletionRequest request);
        partial void ProcessCreateChatCompletionAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Xai.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(

            global::Xai.CreateChatCompletionRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::Xai.CreateChatCompletionRequest
            {
                Model = request.Model,
                Messages = request.Messages,
                Temperature = request.Temperature,
                TopP = request.TopP,
                N = request.N,
                Stream = true,
                Stop = request.Stop,
                MaxTokens = request.MaxTokens,
                PresencePenalty = request.PresencePenalty,
                FrequencyPenalty = request.FrequencyPenalty,
                LogitBias = request.LogitBias,
                User = request.User,
                Tools = request.Tools,
                ToolChoice = request.ToolChoice,
                ParallelToolCalls = request.ParallelToolCalls,
                ResponseFormat = request.ResponseFormat,
                Seed = request.Seed,
                Deferred = request.Deferred,
                ReasoningEffort = request.ReasoningEffort,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Xai.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateChatCompletionAsStreamSecurityRequirements,
                operationName: "CreateChatCompletionAsStreamAsync");

            var __pathBuilder = new global::Xai.PathBuilder(
                path: "/chat/completions",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateChatCompletionAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateChatCompletionAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                string? __content = null;
                try
                {
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }
                catch (global::System.Exception)
                {
                }

                throw new global::Xai.ApiException(
                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::Xai.CreateChatCompletionStreamResponse.FromJson(__content, JsonSerializerContext) ??
                                       throw new global::Xai.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Xai.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
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
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Xai.CreateChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Temperature = temperature,
                TopP = topP,
                N = n,
                Stream = true,
                Stop = stop,
                MaxTokens = maxTokens,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                User = user,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                ResponseFormat = responseFormat,
                Seed = seed,
                Deferred = deferred,
                ReasoningEffort = reasoningEffort,
            };

            var __enumerable = CreateChatCompletionAsStreamAsync(
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}