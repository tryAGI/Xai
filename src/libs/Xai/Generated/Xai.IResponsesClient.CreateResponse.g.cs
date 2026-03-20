#nullable enable

namespace Xai
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Create a model response<br/>
        /// Creates a new model response. Can store the response for later retrieval.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ResponseObject> CreateResponseAsync(

            global::Xai.CreateResponseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model response<br/>
        /// Creates a new model response. Can store the response for later retrieval.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ResponseObject> CreateResponseAsync(
            string model,
            global::Xai.OneOf<string, global::System.Collections.Generic.IList<global::Xai.ResponseInputMessage>> input,
            string? instructions = default,
            double? temperature = default,
            double? topP = default,
            int? maxOutputTokens = default,
            bool? store = default,
            global::Xai.CreateResponseRequestReasoning? reasoning = default,
            global::System.Collections.Generic.IList<global::Xai.ChatCompletionTool>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}