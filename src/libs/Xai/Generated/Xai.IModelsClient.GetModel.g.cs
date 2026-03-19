#nullable enable

namespace Xai
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get model details<br/>
        /// Retrieves a model instance, providing basic information about the model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.Model> GetModelAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}