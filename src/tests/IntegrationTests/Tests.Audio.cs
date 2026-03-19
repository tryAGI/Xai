namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateSpeech()
    {
        var client = GetAuthenticatedClient();

        var audioBytes = await client.Audio.CreateSpeechAsync(
            model: "tts-1",
            input: "Hello from xAI!",
            voice: CreateSpeechRequestVoice.Eve);

        audioBytes.Should().NotBeNullOrEmpty();
        audioBytes.Length.Should().BeGreaterThan(100,
            "audio output should contain meaningful data");
    }
}
