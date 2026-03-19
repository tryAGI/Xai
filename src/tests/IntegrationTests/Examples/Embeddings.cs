/*
order: 150
title: Embeddings
slug: embeddings

Generate text embeddings (single and batch).
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    //// Generate an embedding vector for a single text input.
    [TestMethod]
    [Ignore("xAI currently has no embedding models available")]
    public async Task Example_Embeddings_Single()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Embeddings.CreateEmbeddingAsync(
            model: "v1",
            input: "Hello, world!");

        response.Data.Should().NotBeNullOrEmpty();
        response.Data![0].Embedding.Should().NotBeNullOrEmpty();
        response.Usage?.TotalTokens.Should().BeGreaterThan(0);

        Console.WriteLine($"Embedding dimensions: {response.Data![0].Embedding!.Count}");
    }

    //// Generate embeddings for multiple texts in a single request.
    [TestMethod]
    [Ignore("xAI currently has no embedding models available")]
    public async Task Example_Embeddings_Batch()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Embeddings.CreateEmbeddingAsync(
            model: "v1",
            input: new List<string> { "Hello", "World" });

        response.Data.Should().NotBeNullOrEmpty();
        response.Data!.Count.Should().Be(2);

        Console.WriteLine($"Generated {response.Data.Count} embeddings");
    }
}
