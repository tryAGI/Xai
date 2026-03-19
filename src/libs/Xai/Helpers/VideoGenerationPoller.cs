#nullable enable

namespace Xai;

/// <summary>
/// Extension methods for polling video generation status.
/// </summary>
public static class VideoGenerationPoller
{
    /// <summary>
    /// Generates a video and polls until it is done, failed, or expired.
    /// </summary>
    /// <param name="client">The xAI client.</param>
    /// <param name="request">The video generation request.</param>
    /// <param name="pollingInterval">Interval between status polls. Defaults to 5 seconds.</param>
    /// <param name="timeout">Maximum total wait time. Defaults to 10 minutes.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The final video status response.</returns>
    /// <exception cref="TimeoutException">Thrown if the video generation exceeds the timeout.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the video generation fails or expires.</exception>
    public static async Task<VideoStatusResponse> GenerateAndWaitAsync(
        this XaiClient client,
        CreateVideoRequest request,
        TimeSpan? pollingInterval = null,
        TimeSpan? timeout = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(request);

        var interval = pollingInterval ?? TimeSpan.FromSeconds(5);
        var maxWait = timeout ?? TimeSpan.FromMinutes(10);

        var createResponse = await client.Videos.CreateVideoAsync(request, cancellationToken).ConfigureAwait(false);
        var requestId = createResponse.RequestId ??
            throw new InvalidOperationException("Video generation did not return a request_id.");

        using var timeoutCts = new CancellationTokenSource(maxWait);
        using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutCts.Token);

        while (true)
        {
            linkedCts.Token.ThrowIfCancellationRequested();

            await Task.Delay(interval, linkedCts.Token).ConfigureAwait(false);

            var status = await client.Videos.GetVideoStatusAsync(requestId, linkedCts.Token).ConfigureAwait(false);

            switch (status.Status)
            {
                case VideoStatusResponseStatus.Done:
                    return status;

                case VideoStatusResponseStatus.Failed:
                    throw new InvalidOperationException($"Video generation failed for request {requestId}.");

                case VideoStatusResponseStatus.Expired:
                    throw new InvalidOperationException($"Video generation expired for request {requestId}.");

                case VideoStatusResponseStatus.Pending:
                default:
                    continue;
            }
        }
    }
}
