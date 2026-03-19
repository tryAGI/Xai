/*
order: 10
title: Chat Completion
slug: chat-completion

Send a simple chat completion request.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_ChatCompletion()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        //// Create a chat completion with a simple user message.
        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Say 'Hello, World!' and nothing else.",
                },
            ]);

        response.Choices.Should().NotBeNullOrEmpty();
        response.Choices![0].Message?.Content.Should().NotBeNullOrEmpty();
        response.Usage?.TotalTokens.Should().BeGreaterThan(0);

        Console.WriteLine(response.Choices![0].Message?.Content);
    }
}
