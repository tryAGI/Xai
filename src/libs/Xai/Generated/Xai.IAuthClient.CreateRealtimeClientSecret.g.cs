#nullable enable

namespace Xai
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create ephemeral token for Realtime API<br/>
        /// Creates a short-lived token for authenticating WebSocket connections to the Realtime API from client-side code.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ClientSecretResponse> CreateRealtimeClientSecretAsync(

            global::Xai.CreateClientSecretRequest request,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create ephemeral token for Realtime API<br/>
        /// Creates a short-lived token for authenticating WebSocket connections to the Realtime API from client-side code.
        /// </summary>
        /// <param name="expiresAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ClientSecretResponse> CreateRealtimeClientSecretAsync(
            global::Xai.CreateClientSecretRequestExpiresAfter? expiresAfter = default,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}