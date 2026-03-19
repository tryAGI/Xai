#nullable enable

namespace Xai
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Create embeddings<br/>
        /// Creates an embedding vector representing the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CreateEmbeddingResponse> CreateEmbeddingAsync(

            global::Xai.CreateEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create embeddings<br/>
        /// Creates an embedding vector representing the input text.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CreateEmbeddingResponse> CreateEmbeddingAsync(
            string model,
            global::Xai.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::Xai.CreateEmbeddingRequestEncodingFormat? encodingFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}