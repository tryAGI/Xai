#nullable enable

namespace Xai;

/// <summary>
/// Extension methods for polling deferred chat completion results.
/// </summary>
public static class DeferredCompletionPoller
{
    /// <summary>
    /// Creates a deferred chat completion and polls until the result is ready.
    /// </summary>
    /// <param name="client">The xAI client.</param>
    /// <param name="request">The chat completion request (deferred flag is set automatically).</param>
    /// <param name="pollingInterval">Interval between status polls. Defaults to 5 seconds.</param>
    /// <param name="timeout">Maximum total wait time. Defaults to 10 minutes.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The completed chat completion response.</returns>
    /// <exception cref="TimeoutException">Thrown if the deferred completion exceeds the timeout.</exception>
    /// <exception cref="InvalidOperationException">Thrown if no request ID is returned.</exception>
    public static async Task<CreateChatCompletionResponse> CreateDeferredAndWaitAsync(
        this XaiClient client,
        CreateChatCompletionRequest request,
        TimeSpan? pollingInterval = null,
        TimeSpan? timeout = null,
        CancellationToken cancellationToken = default)
    {
        var interval = pollingInterval ?? TimeSpan.FromSeconds(5);
        var maxWait = timeout ?? TimeSpan.FromMinutes(10);

        // Ensure deferred flag is set
        request.Deferred = true;

        var submitResponse = await client.Chat.CreateChatCompletionAsync(request, cancellationToken).ConfigureAwait(false);
        var requestId = submitResponse.Id ??
            throw new InvalidOperationException("Deferred completion did not return a request ID.");

        using var timeoutCts = new CancellationTokenSource(maxWait);
        using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutCts.Token);

        while (true)
        {
            linkedCts.Token.ThrowIfCancellationRequested();

            await Task.Delay(interval, linkedCts.Token).ConfigureAwait(false);

            var result = await client.Chat.GetDeferredCompletionAsync(requestId, linkedCts.Token).ConfigureAwait(false);

            // If choices are populated, the result is ready
            if (result.Choices is { Count: > 0 })
            {
                return result;
            }
        }
    }
}
