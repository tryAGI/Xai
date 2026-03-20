# Reasoning

Use reasoning effort to get step-by-step thinking from grok-3-mini.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Enable reasoning with high effort to get a thinking trace alongside the answer.
var response = await client.Chat.CreateChatCompletionAsync(
    model: "grok-3-mini",
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "What is 15 * 37? Think step by step.",
        },
    ],
    reasoningEffort: CreateChatCompletionRequestReasoningEffort.High);

var message = response.Choices![0].Message;
    "grok-3-mini with high reasoning effort should return reasoning content");

Console.WriteLine($"Reasoning: {message.ReasoningContent}");
Console.WriteLine($"Answer: {message.Content}");
```