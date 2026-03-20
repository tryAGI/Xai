#nullable enable

namespace Xai
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Edit an image<br/>
        /// Creates an edited or extended image given source image(s) and a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ImageResponse> CreateImageEditAsync(

            global::Xai.CreateImageEditRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image<br/>
        /// Creates an edited or extended image given source image(s) and a prompt.
        /// </summary>
        /// <param name="model">
        /// The model to use for image editing.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired edit.
        /// </param>
        /// <param name="image"></param>
        /// <param name="images">
        /// Source images (up to 5).
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio override for the output.
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="responseFormat">
        /// Default Value: url
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ImageResponse> CreateImageEditAsync(
            string model,
            string prompt,
            global::Xai.ImageInput? image = default,
            global::System.Collections.Generic.IList<global::Xai.ImageInput>? images = default,
            global::Xai.CreateImageEditRequestAspectRatio? aspectRatio = default,
            global::Xai.CreateImageEditRequestResolution? resolution = default,
            global::Xai.CreateImageEditRequestResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}