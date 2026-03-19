/*
order: 160
title: List Models
slug: list-models

List available models by category (language, image, video, embedding).
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    //// List all models available on the account.
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_ListModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListModelsAsync();

        response.Data.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Total models: {response.Data!.Count}");
    }

    //// List only language models with their input/output modalities.
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_ListLanguageModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListLanguageModelsAsync();

        response.Models.Should().NotBeNullOrEmpty();

        var model = response.Models![0];
        model.Id.Should().NotBeNullOrEmpty();
        model.InputModalities.Should().NotBeNullOrEmpty();
        model.OutputModalities.Should().NotBeNullOrEmpty();

        foreach (var m in response.Models!)
        {
            Console.WriteLine($"{m.Id}: in={string.Join(",", m.InputModalities!)} out={string.Join(",", m.OutputModalities!)}");
        }
    }

    //// List image generation models.
    [TestMethod]
    public async Task Example_ListImageGenerationModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListImageGenerationModelsAsync();

        response.Models.Should().NotBeNullOrEmpty();

        foreach (var m in response.Models!)
        {
            Console.WriteLine(m.Id);
        }
    }

    //// List video generation models.
    [TestMethod]
    public async Task Example_ListVideoGenerationModels()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Models.ListVideoGenerationModelsAsync();

        response.Models.Should().NotBeNullOrEmpty();

        foreach (var m in response.Models!)
        {
            Console.WriteLine(m.Id);
        }
    }
}
