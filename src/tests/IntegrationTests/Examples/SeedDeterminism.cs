/*
order: 45
title: Seed Determinism
slug: seed-determinism

Use a fixed seed and temperature=0 for reproducible output.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SeedDeterminism()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        const int seed = 42;
        const string prompt = "What is the capital of Japan? Answer with just the city name.";

        //// Send the same request twice with the same seed and temperature=0.
        var response1 = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages:
            [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = prompt,
                },
            ],
            seed: seed,
            temperature: 0);

        var response2 = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages:
            [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = prompt,
                },
            ],
            seed: seed,
            temperature: 0);

        response1.Choices.Should().NotBeNullOrEmpty();
        response2.Choices.Should().NotBeNullOrEmpty();

        var content1 = response1.Choices![0].Message?.Content;
        var content2 = response2.Choices![0].Message?.Content;

        content1.Should().NotBeNullOrEmpty();
        content2.Should().NotBeNullOrEmpty();

        //// With the same seed and temperature=0, outputs should be identical.
        content1.Should().Be(content2,
            "same seed and temperature=0 should produce deterministic output");

        Console.WriteLine($"Response 1: {content1}");
        Console.WriteLine($"Response 2: {content2}");
    }
}
