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
    public async Task Example_ResponsesApi()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        //// Create a response (stored server-side)
        var response = await client.Responses.CreateResponseAsync(
            model: modelId,
            input: "What is 2+2? Answer with just the number.");

        Console.WriteLine($"Response: {response.Output}");

        //// Retrieve the stored response
        var retrieved = await client.Responses.GetResponseAsync(response.Id!);
        Console.WriteLine($"Retrieved: {retrieved.Id}");

        //// Delete the stored response
        var deleted = await client.Responses.DeleteResponseAsync(response.Id!);
        Console.WriteLine($"Deleted: {deleted.Deleted}");
    }
}
