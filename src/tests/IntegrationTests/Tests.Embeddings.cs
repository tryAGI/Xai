namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Ignore("xAI currently has no embedding models available")]
    public async Task CreateEmbedding()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Embeddings.CreateEmbeddingAsync(
            model: "v1",
            input: "Hello, world!");

        response.Data.Should().NotBeNullOrEmpty();
        response.Data![0].Embedding.Should().NotBeNullOrEmpty();
        response.Usage?.TotalTokens.Should().BeGreaterThan(0);
    }

    [TestMethod]
    [Ignore("xAI currently has no embedding models available")]
    public async Task CreateEmbeddingBatch()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Embeddings.CreateEmbeddingAsync(
            model: "v1",
            input: new List<string> { "Hello", "World" });

        response.Data.Should().NotBeNullOrEmpty();
        response.Data!.Count.Should().Be(2);
    }
}
