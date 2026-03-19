#nullable enable

namespace Xai
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List embedding models<br/>
        /// Lists the currently available embedding models.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ListSpecificModelsResponse> ListEmbeddingModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}