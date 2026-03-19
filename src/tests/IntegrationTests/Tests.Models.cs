namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListModelsAsync();

        response.Data.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ListLanguageModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListLanguageModelsAsync();

        response.Data.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ListImageGenerationModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListImageGenerationModelsAsync();

        response.Data.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ListVideoGenerationModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListVideoGenerationModelsAsync();

        response.Data.Should().NotBeNullOrEmpty();
    }
}
