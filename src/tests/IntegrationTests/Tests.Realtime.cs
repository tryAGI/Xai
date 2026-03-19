namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task RealtimeSessionUpdate()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

        using var client = new RealtimeVoiceClient(apiKey);
        await client.ConnectAsync();

        client.IsConnected.Should().BeTrue();

        // Send session update
        await client.SendEventAsync(RealtimeClientEvent.SessionUpdate(new RealtimeSessionConfig
        {
            Voice = "Eve",
            Instructions = "You are a helpful assistant. Respond briefly.",
            Modalities = ["text", "audio"],
            TurnDetection = new RealtimeTurnDetection
            {
                Type = "server_vad",
                Threshold = 0.85,
                SilenceDurationMs = 500,
            },
        }));

        // Send a text message and request response
        await client.SendEventAsync(RealtimeClientEvent.UserMessage("Say hello!"));
        await client.SendEventAsync(RealtimeClientEvent.CreateResponse(["text"]));

        // Receive events until response.done
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        var receivedSessionUpdated = false;
        var receivedResponseDone = false;
        string? transcriptText = null;

        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
        {
            if (serverEvent.IsSessionUpdated)
            {
                receivedSessionUpdated = true;
            }
            else if (serverEvent.IsAudioTranscriptDelta)
            {
                transcriptText = (transcriptText ?? "") + serverEvent.Delta;
            }
            else if (serverEvent.IsResponseDone)
            {
                receivedResponseDone = true;
                break;
            }
            else if (serverEvent.IsError)
            {
                Assert.Fail($"Received error: {serverEvent.Error?.Message}");
            }
        }

        receivedSessionUpdated.Should().BeTrue();
        receivedResponseDone.Should().BeTrue();
    }
}
