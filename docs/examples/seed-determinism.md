# Seed Determinism

Use a fixed seed and temperature=0 for reproducible output.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

const int seed = 42;
const string prompt = "What is the capital of Japan? Answer with just the city name.";

// Send the same request twice with the same seed and temperature=0.
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

var content1 = response1.Choices![0].Message?.Content;
var content2 = response2.Choices![0].Message?.Content;

// With the same seed and temperature=0, outputs should be identical.
    "same seed and temperature=0 should produce deterministic output");

Console.WriteLine($"Response 1: {content1}");
Console.WriteLine($"Response 2: {content2}");
```