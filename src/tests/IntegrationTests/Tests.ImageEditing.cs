namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateImageEdit()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Images.CreateImageEditAsync(
            model: "grok-2-image",
            prompt: "Add a red hat to the person in the image",
            image: new ImageInput
            {
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/PNG_transparency_demonstration_1.png/280px-PNG_transparency_demonstration_1.png",
            });

        response.Data.Should().NotBeNullOrEmpty();
        response.Data![0].Url.Should().NotBeNullOrEmpty();
    }
}
