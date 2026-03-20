# Chat Completion

Send a simple chat completion request.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Create a chat completion with a simple user message.
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
```