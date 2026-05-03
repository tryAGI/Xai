/*
order: 101
title: Custom Voices
slug: custom-voices

Use cloned voice IDs with text-to-speech.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CustomVoices()
    {
        var customVoiceId =
            Environment.GetEnvironmentVariable("XAI_CUSTOM_VOICE_ID") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException(
                    "XAI_CUSTOM_VOICE_ID environment variable is not found.");

        var client = GetAuthenticatedClient();

        //// Retrieve metadata for a custom voice owned by your team.
        var customVoice = await client.CustomVoices.GetCustomVoiceAsync(customVoiceId);

        customVoice.VoiceId.Should().Be(customVoiceId);

        //// Use the custom voice ID anywhere a built-in TTS voice ID is accepted.
        byte[] audioBytes = await client.Audio.CreateTextToSpeechAsync(
            text: "Hello from my custom xAI voice.",
            language: "en",
            voiceId: customVoice.VoiceId);

        audioBytes.Should().NotBeNullOrEmpty();
    }
}
