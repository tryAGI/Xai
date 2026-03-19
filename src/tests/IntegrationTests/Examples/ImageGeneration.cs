/*
order: 70
title: Image Generation
slug: image-generation

Generate an image from a text prompt.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ImageGeneration()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Images.CreateImageAsync(
            model: "grok-imagine-image",
            prompt: "A simple red circle on a white background");

        Console.WriteLine(response.Data![0].Url);
    }
}
