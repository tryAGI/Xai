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

        //// Generate speech audio from text. Built-in and custom voices are passed as voice IDs.
        byte[] audioBytes = await client.Audio.CreateTextToSpeechAsync(
            text: "Hello from xAI!",
            language: "en",
            voiceId: "eve");

        audioBytes.Should().NotBeNullOrEmpty();
        audioBytes.Length.Should().BeGreaterThan(100, "audio output should contain meaningful data");

        Console.WriteLine($"Generated {audioBytes.Length} bytes of audio.");
    }
}
