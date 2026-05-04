# Text to Speech Streaming

Stream text deltas into the xAI Text to Speech WebSocket API and receive audio chunks as they are generated.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var apiKey =
    Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
        ? apiKeyValue
        : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

// Create a WebSocket client and connect with the TTS voice, language, and audio format.
using var client = new Xai.TextToSpeech.XaiTextToSpeechStreamingClient(apiKey);
await client.ConnectAsync(
    language: "en",
    voice: "eve",
    codec: "mp3");

// Stream text as one or more deltas, then flush the utterance with text.done.
await client.SendTextDeltaAsync(new Xai.TextToSpeech.TextDeltaPayload
{
    Delta = "Hello from xAI streaming text to speech.",
});
await client.SendTextDoneAsync(new Xai.TextToSpeech.TextDonePayload());

// Receive base64 audio chunks until the utterance is complete.
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
using var audio = new MemoryStream();
var receivedAudioDone = false;

await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
{
    if (serverEvent.IsAudioDelta)
    {
        audio.Write(serverEvent.AudioDelta.DeltaBytes.Span);
    }
    else if (serverEvent.IsAudioDone)
    {
        receivedAudioDone = true;
        break;
    }
    else if (serverEvent.IsError)
    {
        throw new InvalidOperationException($"Received error: {serverEvent.Error?.Message}");
    }
}

Console.WriteLine($"Generated {audio.Length} streaming audio bytes.");
```