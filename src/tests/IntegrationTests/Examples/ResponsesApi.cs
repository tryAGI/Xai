/*
order: 110
title: Responses API
slug: responses-api

Create, retrieve, and delete server-stored responses.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_ResponsesApi()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        //// Create a response that is stored server-side for later retrieval.
        var response = await client.Responses.CreateResponseAsync(
            model: modelId,
            input: "What is 2+2? Answer with just the number.");

        response.Id.Should().NotBeNullOrEmpty();
        response.Status.Should().Be(ResponseObjectStatus.Completed);
        response.Output.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Response: {response.Output}");

        //// Retrieve the stored response by ID.
        var retrieved = await client.Responses.GetResponseAsync(response.Id!);
        retrieved.Id.Should().Be(response.Id);

        Console.WriteLine($"Retrieved: {retrieved.Id}");

        //// Delete the stored response when no longer needed.
        var deleted = await client.Responses.DeleteResponseAsync(response.Id!);
        deleted.Deleted.Should().BeTrue();

        Console.WriteLine($"Deleted: {deleted.Deleted}");
    }
}
