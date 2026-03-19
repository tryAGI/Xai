/*
order: 130
title: Realtime Voice
slug: realtime-voice

Connect to the Realtime Voice Agent WebSocket API for bidirectional text/audio streaming.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task Example_RealtimeVoice()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

        //// Create a WebSocket client and connect to the xAI Realtime API.
        using var client = new RealtimeVoiceClient(apiKey);
        await client.ConnectAsync();

        client.IsConnected.Should().BeTrue();

        //// Configure the session with voice, instructions, and turn detection.
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

        //// Send a text message and request a text response.
        await client.SendEventAsync(RealtimeClientEvent.UserMessage("Say hello!"));
        await client.SendEventAsync(RealtimeClientEvent.CreateResponse(["text"]));

        //// Receive server events until the response is complete.
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
                Console.Write(serverEvent.Delta);
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
