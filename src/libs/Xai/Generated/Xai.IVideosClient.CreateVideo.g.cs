#nullable enable

namespace Xai
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Generate a video<br/>
        /// Creates a video given a prompt. Returns a request_id for polling.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CreateVideoResponse> CreateVideoAsync(

            global::Xai.CreateVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate a video<br/>
        /// Creates a video given a prompt. Returns a request_id for polling.
        /// </summary>
        /// <param name="model">
        /// The model to use for video generation.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired video.
        /// </param>
        /// <param name="duration">
        /// Duration in seconds (1-15 for generation, max 8.7s source for editing).
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the generated video. Defaults to 16:9.
        /// </param>
        /// <param name="resolution">
        /// Resolution of the generated video.<br/>
        /// Default Value: 480p
        /// </param>
        /// <param name="videoUrl">
        /// Source video URL for editing operations.
        /// </param>
        /// <param name="imageUrl">
        /// Source image URL for image-to-video generation (public URL or base64 data URI).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Xai.CreateVideoResponse> CreateVideoAsync(
            string model,
            string prompt,
            int? duration = default,
            global::Xai.CreateVideoRequestAspectRatio? aspectRatio = default,
            global::Xai.CreateVideoRequestResolution? resolution = default,
            string? videoUrl = default,
            string? imageUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}