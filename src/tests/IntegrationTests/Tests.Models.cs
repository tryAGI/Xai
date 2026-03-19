namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task ListModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListModelsAsync();

        response.Data.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("Smoke")]
    public async Task ListLanguageModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListLanguageModelsAsync();

        response.Models.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ListImageGenerationModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListImageGenerationModelsAsync();

        response.Models.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ListVideoGenerationModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListVideoGenerationModelsAsync();

        response.Models.Should().NotBeNullOrEmpty();
    }
}
