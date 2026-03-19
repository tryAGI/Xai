# Batch API

The Batch API lets you submit multiple chat completion requests as a batch for asynchronous processing. This is ideal for bulk workloads like dataset evaluation, content generation pipelines, or any scenario where you need to process many prompts efficiently.

## Quick Start

```csharp
using Xai;

using var client = new XaiClient(apiKey);

// Step 1: Create a batch
var batch = await client.Batches.CreateBatchAsync(name: "my-batch");
Console.WriteLine($"Created batch: {batch.BatchId}");

// Step 2: Add requests
await client.Batches.AddBatchRequestsAsync(
    batchId: batch.BatchId!,
    batchRequests: [
        new BatchRequestItem
        {
            BatchRequestId = "req-1",
            BatchRequest = new
            {
                chat_get_completion = new
                {
                    model = "grok-3-mini",
                    messages = new[]
                    {
                        new { role = "user", content = "What is 2+2? Answer with just the number." },
                    },
                },
            },
        },
        new BatchRequestItem
        {
            BatchRequestId = "req-2",
            BatchRequest = new
            {
                chat_get_completion = new
                {
                    model = "grok-3-mini",
                    messages = new[]
                    {
                        new { role = "user", content = "What is 3+3? Answer with just the number." },
                    },
                },
            },
        },
    ]);

// Step 3: Poll for completion
while (true)
{
    await Task.Delay(TimeSpan.FromSeconds(10));

    var status = await client.Batches.GetBatchAsync(batch.BatchId!);

    if (status.State is { NumPending: 0 })
    {
        // Step 4: Get results
        var results = await client.Batches.GetBatchResultsAsync(batch.BatchId!);

        foreach (var item in results.Succeeded!)
        {
            Console.WriteLine($"{item.BatchRequestId}: completed");
        }
        break;
    }

    Console.WriteLine($"Pending: {status.State?.NumPending}");
}
```

## Batch Lifecycle

```
CreateBatch → AddBatchRequests → Poll GetBatch → GetBatchResults
                                       ↑               │
                                       └───────────────┘
                                      (until NumPending = 0)
```

### 1. Create a Batch

```csharp
var batch = await client.Batches.CreateBatchAsync(name: "evaluation-run-42");

Console.WriteLine($"Batch ID: {batch.BatchId}");
Console.WriteLine($"Name: {batch.Name}");
```

### 2. Add Requests

Add one or more requests to the batch. Each request needs a unique `BatchRequestId` for correlation:

```csharp
var updated = await client.Batches.AddBatchRequestsAsync(
    batchId: batch.BatchId!,
    batchRequests: [
        new BatchRequestItem
        {
            BatchRequestId = "prompt-001",
            BatchRequest = new
            {
                chat_get_completion = new
                {
                    model = "grok-3-mini",
                    messages = new[]
                    {
                        new { role = "user", content = "Translate 'hello' to French." },
                    },
                },
            },
        },
    ]);
```

### 3. Monitor Progress

Poll the batch status to check how many requests are still pending:

```csharp
var status = await client.Batches.GetBatchAsync(batch.BatchId!);

Console.WriteLine($"Pending: {status.State?.NumPending}");
```

### 4. Get Results

Once all requests are processed (`NumPending == 0`), retrieve the results:

```csharp
var results = await client.Batches.GetBatchResultsAsync(batch.BatchId!);

// Successful completions
foreach (var item in results.Succeeded ?? [])
{
    Console.WriteLine($"{item.BatchRequestId}: success");
}

// Failed requests
foreach (var item in results.Failed ?? [])
{
    Console.WriteLine($"{item.BatchRequestId}: failed");
}
```

## Managing Batches

### List All Batches

```csharp
var list = await client.Batches.ListBatchesAsync();

foreach (var b in list.Batches ?? [])
{
    Console.WriteLine($"{b.BatchId}: {b.Name}");
}
```

### Cancel a Batch

Cancel a batch that is still in progress:

```csharp
var cancelled = await client.Batches.CancelBatchAsync(batch.BatchId!);
Console.WriteLine($"Cancelled: {cancelled.BatchId}");
```

## Tips

- Use meaningful `BatchRequestId` values (e.g., `"eval-dataset-row-42"`) so you can correlate results with your input data
- Poll at reasonable intervals (10-30 seconds) to avoid rate limiting
- For single async requests, consider [Deferred Completions](deferred-completions.md) instead
