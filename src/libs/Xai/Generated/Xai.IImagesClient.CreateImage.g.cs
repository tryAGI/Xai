#nullable enable

namespace Xai
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Generate images<br/>
        /// Creates an image given a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ImageResponse> CreateImageAsync(

            global::Xai.CreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate images<br/>
        /// Creates an image given a prompt.
        /// </summary>
        /// <param name="model">
        /// The model to use for image generation.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired image.
        /// </param>
        /// <param name="n">
        /// Number of images to generate (max 10).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the generated image.
        /// </param>
        /// <param name="resolution">
        /// Resolution of the generated image.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the generated image.<br/>
        /// Default Value: url
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.ImageResponse> CreateImageAsync(
            string model,
            string prompt,
            int? n = default,
            global::Xai.CreateImageRequestAspectRatio? aspectRatio = default,
            global::Xai.CreateImageRequestResolution? resolution = default,
            global::Xai.CreateImageRequestResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}