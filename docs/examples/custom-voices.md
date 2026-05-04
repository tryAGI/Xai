# Custom Voices

Use cloned voice IDs with text-to-speech.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var customVoiceId =
    Environment.GetEnvironmentVariable("XAI_CUSTOM_VOICE_ID") is { Length: > 0 } value
        ? value
        : throw new AssertInconclusiveException(
            "XAI_CUSTOM_VOICE_ID environment variable is not found.");

var client = new XaiClient(apiKey);

// Retrieve metadata for a custom voice owned by your team.
var customVoice = await client.CustomVoices.GetCustomVoiceAsync(customVoiceId);

// Use the custom voice ID anywhere a built-in TTS voice ID is accepted.
byte[] audioBytes = await client.Audio.CreateTextToSpeechAsync(
    text: "Hello from my custom xAI voice.",
    language: "en",
    voiceId: customVoice.VoiceId);
```