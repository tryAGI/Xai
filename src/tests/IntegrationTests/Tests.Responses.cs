namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task CreateAndGetResponse()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var response = await client.Responses.CreateResponseAsync(
            model: modelId,
            input: "What is 2+2? Answer with just the number.");

        response.Id.Should().NotBeNullOrEmpty();
        response.Status.Should().Be(ResponseObjectStatus.Completed);
        response.Output.Should().NotBeNullOrEmpty();

        // Retrieve the stored response
        var retrieved = await client.Responses.GetResponseAsync(response.Id!);
        retrieved.Id.Should().Be(response.Id);

        // Delete the response
        var deleted = await client.Responses.DeleteResponseAsync(response.Id!);
        deleted.Deleted.Should().BeTrue();
    }
}
