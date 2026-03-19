namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Ignore("Requires a pre-created collection with uploaded documents")]
    public async Task SearchDocuments()
    {
        var client = GetAuthenticatedClient();

        var collectionId =
            Environment.GetEnvironmentVariable("XAI_COLLECTION_ID") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException(
                    "XAI_COLLECTION_ID environment variable is not found.");

        var response = await client.Collections.SearchDocumentsAsync(
            query: "What is xAI?",
            collectionIds: [collectionId],
            mode: SearchDocumentsRequestMode.Hybrid,
            maxNumResults: 5);

        response.Results.Should().NotBeNullOrEmpty();
        response.Results![0].Content.Should().NotBeNullOrEmpty();
        response.Results[0].Score.Should().BeGreaterThan(0);
    }
}
