# Realtime Voice

Connect to the Realtime Voice Agent WebSocket API for bidirectional text/audio streaming.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var apiKey =
    Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
        ? apiKeyValue
        : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

// Create a WebSocket client and connect to the xAI Realtime API.
using var client = new XaiRealtimeClient(apiKey);
await client.ConnectAsync();

// Configure the session with voice, instructions, and turn detection.
await client.SendSessionUpdateAsync(new SessionUpdatePayload
{
    Session = new SessionConfig
    {
        Voice = SessionConfigVoice.Eve,
        Instructions = "You are a helpful assistant. Respond briefly.",
        Modalities = ["text", "audio"],
        TurnDetection = new TurnDetection
        {
            Type = "server_vad",
            Threshold = 0.85,
            SilenceDurationMs = 500,
        },
    },
});

// Send a text message and request a text response.
await client.SendConversationItemCreateAsync(new ConversationItemCreatePayload
{
    Item = new ConversationItem
    {
        Type = "message",
        Role = "user",
        Content = [new ContentPart { Type = "input_text", Text = "Say hello!" }],
    },
});
await client.SendResponseCreateAsync(new ResponseCreatePayload
{
    Response = new ResponseConfig
    {
        Modalities = ["text"],
    },
});

// Receive server events until the response is complete.
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
    else if (serverEvent.IsResponseOutputAudioTranscriptDelta)
    {
        transcriptText = (transcriptText ?? "") + serverEvent.ResponseOutputAudioTranscriptDelta?.Delta;
        Console.Write(serverEvent.ResponseOutputAudioTranscriptDelta?.Delta);
    }
    else if (serverEvent.IsResponseDone)
    {
        receivedResponseDone = true;
        break;
    }
    else if (serverEvent.IsError)
    {
    }
}
```