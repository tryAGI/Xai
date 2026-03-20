# Multi-Turn Conversation

Continue a conversation across multiple turns with system instructions and history.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Pass a system message and conversation history to maintain context across turns.
var response = await client.Chat.CreateChatCompletionAsync(
    model: modelId,
    messages:
    [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.System,
            Content = "You are a helpful math tutor. Always show your work.",
        },
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "What is 7 * 8?",
        },
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.Assistant,
            Content = "7 * 8 = 56",
        },
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Now divide that result by 4.",
        },
    ]);

var content = response.Choices![0].Message?.Content;
    "56 / 4 = 14, and the model should reference the previous result");

Console.WriteLine(content);
```