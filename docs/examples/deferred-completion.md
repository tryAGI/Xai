# Deferred Completion

Submit a chat completion for asynchronous processing and poll for the result.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Submit a deferred request — it returns immediately with a request ID.
var response = await client.Chat.CreateChatCompletionAsync(
    model: modelId,
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Explain what a quasar is in two sentences.",
        },
    ],
    deferred: true);

// Poll for the result (the request is processed asynchronously).
await Task.Delay(TimeSpan.FromSeconds(5));

var result = await client.Chat.GetDeferredCompletionAsync(response.Id!);

Console.WriteLine(result.Choices![0].Message?.Content);
```