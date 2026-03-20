# Document Search

Search uploaded document collections using hybrid search.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

var collectionId =
    Environment.GetEnvironmentVariable("XAI_COLLECTION_ID") is { Length: > 0 } value
        ? value
        : throw new AssertInconclusiveException(
            "XAI_COLLECTION_ID environment variable is not found.");

// Search across document collections using hybrid (semantic + keyword) mode.
var response = await client.Collections.SearchDocumentsAsync(
    query: "What is xAI?",
    collectionIds: [collectionId],
    mode: SearchDocumentsRequestMode.Hybrid,
    maxNumResults: 5);

foreach (var result in response.Results!)
{
    Console.WriteLine($"Score: {result.Score:F3} — {result.Content?[..Math.Min(80, result.Content?.Length ?? 0)]}...");
}
```