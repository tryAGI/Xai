#nullable enable

namespace Xai
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get language model details
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.Model> GetLanguageModelAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}