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
    public async Task Example_ChatCompletion()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Say 'Hello, World!' and nothing else.",
                },
            ]);

        Console.WriteLine(response.Choices![0].Message?.Content);
    }
}
