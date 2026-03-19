# Deferred Completions

Deferred completions allow you to submit chat completion requests for asynchronous processing. This is useful for non-time-sensitive workloads, batch-like processing at lower priority, or when you want to queue many requests and retrieve results later.

## Quick Start

```csharp
using Xai;

using var client = new XaiClient(apiKey);

// Use the convenience helper — submits + polls automatically
var response = await client.CreateDeferredAndWaitAsync(
    new CreateChatCompletionRequest
    {
        Model = "grok-3-mini",
        Messages = [
            new ChatCompletionMessage
            {
                Role = ChatCompletionMessageRole.User,
                Content = "Explain what a quasar is in two sentences.",
            },
        ],
    });

Console.WriteLine(response.Choices![0].Message?.Content);
```

## How It Works

1. **Submit** a chat completion request with `deferred: true`
2. The API returns immediately with a request ID (no choices yet)
3. **Poll** using the request ID until results are ready
4. Retrieve the completed response with choices populated

## Manual Polling

For full control over the polling process:

```csharp
// Step 1: Submit the deferred request
var submitResponse = await client.Chat.CreateChatCompletionAsync(
    model: "grok-3-mini",
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Write a detailed analysis of renewable energy trends.",
        },
    ],
    deferred: true);

var requestId = submitResponse.Id!;
Console.WriteLine($"Submitted deferred request: {requestId}");

// Step 2: Poll for the result
while (true)
{
    await Task.Delay(TimeSpan.FromSeconds(5));

    var result = await client.Chat.GetDeferredCompletionAsync(requestId);

    if (result.Choices is { Count: > 0 })
    {
        Console.WriteLine(result.Choices[0].Message?.Content);
        break;
    }

    Console.WriteLine("Still processing...");
}
```

## CreateDeferredAndWaitAsync Options

The `CreateDeferredAndWaitAsync` extension method handles submission and polling in one call:

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `request` | `CreateChatCompletionRequest` | *required* | The chat completion request (deferred flag is set automatically) |
| `pollingInterval` | `TimeSpan?` | 5 seconds | How often to check for results |
| `timeout` | `TimeSpan?` | 10 minutes | Maximum total wait time |
| `cancellationToken` | `CancellationToken` | `default` | Cancellation token |

```csharp
var response = await client.CreateDeferredAndWaitAsync(
    new CreateChatCompletionRequest
    {
        Model = "grok-3-mini",
        Messages = [
            new ChatCompletionMessage
            {
                Role = ChatCompletionMessageRole.User,
                Content = "Summarize the history of computing.",
            },
        ],
    },
    pollingInterval: TimeSpan.FromSeconds(10),
    timeout: TimeSpan.FromMinutes(5));
```

The method throws:

- `TimeoutException` if the result is not ready within the timeout period
- `InvalidOperationException` if the initial submission does not return a request ID

## Deferred vs. Batch API

| Feature | Deferred Completions | Batch API |
|---------|---------------------|-----------|
| Scope | Single request | Multiple requests |
| Submission | `deferred: true` parameter | Create batch + add requests |
| Polling | Per-request ID | Per-batch ID |
| Use case | Individual async requests | Bulk processing |
| Helper | `CreateDeferredAndWaitAsync` | Manual polling |

For processing many requests together, consider using the [Batch API](batches.md) instead.
