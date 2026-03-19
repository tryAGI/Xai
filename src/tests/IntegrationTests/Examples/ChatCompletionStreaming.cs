/*
order: 20
title: Chat Completion Streaming
slug: chat-completion-streaming

Stream a chat completion response token by token.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ChatCompletionStreaming()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        await foreach (var chunk in client.Chat.CreateChatCompletionAsStreamAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Tell me a short story.",
                },
            ]))
        {
            Console.Write(chunk.Choices?[0].Delta?.Content);
        }
    }
}
