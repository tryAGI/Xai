#nullable enable

namespace Xai
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List video generation models<br/>
        /// Lists the currently available video generation models.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ListSpecificModelsResponse> ListVideoGenerationModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}