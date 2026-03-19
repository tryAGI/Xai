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
    [TestCategory("Smoke")]
    public async Task Example_ChatCompletionStreaming()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        //// Stream the response and print each chunk as it arrives.
        var chunks = new List<CreateChatCompletionStreamResponse>();
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
            chunks.Add(chunk);
            Console.Write(chunk.Choices?[0].Delta?.Content);
        }

        chunks.Should().NotBeEmpty();
    }
}
