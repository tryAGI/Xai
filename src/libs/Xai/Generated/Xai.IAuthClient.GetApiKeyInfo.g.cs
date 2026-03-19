#nullable enable

namespace Xai
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get API key information<br/>
        /// Returns information about the API key used for authentication.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ApiKeyInfo> GetApiKeyInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}