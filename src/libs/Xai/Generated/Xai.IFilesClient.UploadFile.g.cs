#nullable enable

namespace Xai
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file that can be used with collections.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.FileObject> UploadFileAsync(

            global::Xai.UploadFileRequest request,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file that can be used with collections.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.AutoSDKHttpResponse<global::Xai.FileObject>> UploadFileAsResponseAsync(

            global::Xai.UploadFileRequest request,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file that can be used with collections.
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.FileObject> UploadFileAsync(
            byte[] file,
            string filename,
            string purpose,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file that can be used with collections.
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.FileObject> UploadFileAsync(
            global::System.IO.Stream file,
            string filename,
            string purpose,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file that can be used with collections.
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.AutoSDKHttpResponse<global::Xai.FileObject>> UploadFileAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string purpose,
            global::Xai.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}