/*
order: 100
title: Text to Speech
slug: text-to-speech

Convert text to speech audio.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToSpeech()
    {
        var client = GetAuthenticatedClient();

        byte[] audioBytes = await client.Audio.CreateSpeechAsync(
            model: "tts-1",
            input: "Hello from xAI!",
            voice: CreateSpeechRequestVoice.Eve);

        Console.WriteLine($"Generated {audioBytes.Length} bytes of audio.");
    }
}
