# Chat Completion Streaming

Stream a chat completion response token by token.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Stream the response and print each chunk as it arrives.
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
```