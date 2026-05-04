# Text to Speech

Convert text to speech audio.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Generate speech audio from text. Built-in and custom voices are passed as voice IDs.
byte[] audioBytes = await client.Audio.CreateTextToSpeechAsync(
    text: "Hello from xAI!",
    language: "en",
    voiceId: "eve");

Console.WriteLine($"Generated {audioBytes.Length} bytes of audio.");
```