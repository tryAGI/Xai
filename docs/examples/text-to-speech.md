# Text to Speech

Convert text to speech audio.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Generate speech audio from text. Available voices: Eve, Ara, Rex, Sal, Leo.
byte[] audioBytes = await client.Audio.CreateSpeechAsync(
    model: "tts-1",
    input: "Hello from xAI!",
    voice: CreateSpeechRequestVoice.Eve);

    "audio output should contain meaningful data");

Console.WriteLine($"Generated {audioBytes.Length} bytes of audio.");
```