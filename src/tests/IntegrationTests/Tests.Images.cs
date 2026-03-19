namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateImage()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Images.CreateImageAsync(
            model: "grok-imagine-image",
            prompt: "A simple red circle on a white background");

        response.Data.Should().NotBeNullOrEmpty();
        response.Data![0].Url.Should().NotBeNullOrEmpty();
    }
}
