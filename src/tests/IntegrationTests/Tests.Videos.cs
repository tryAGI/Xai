namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task CreateVideoAndPoll()
    {
        var client = GetAuthenticatedClient();

        var status = await client.GenerateAndWaitAsync(
            new CreateVideoRequest
            {
                Model = "grok-imagine-video",
                Prompt = "A gentle ocean wave rolling onto a sandy beach at sunset",
                Duration = 3,
                Resolution = CreateVideoRequestResolution.x480p,
            },
            pollingInterval: TimeSpan.FromSeconds(10),
            timeout: TimeSpan.FromMinutes(5));

        status.Status.Should().Be(VideoStatusResponseStatus.Done);
        status.Video?.Url.Should().NotBeNullOrEmpty();
    }
}
