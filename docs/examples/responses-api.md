# Responses API

Create, retrieve, and delete server-stored responses.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Create a response that is stored server-side for later retrieval.
var response = await client.Responses.CreateResponseAsync(
    model: modelId,
    input: "What is 2+2? Answer with just the number.");

Console.WriteLine($"Response: {response.Output}");

// Retrieve the stored response by ID.
var retrieved = await client.Responses.GetResponseAsync(response.Id!);

Console.WriteLine($"Retrieved: {retrieved.Id}");

// Delete the stored response when no longer needed.
var deleted = await client.Responses.DeleteResponseAsync(response.Id!);

Console.WriteLine($"Deleted: {deleted.Deleted}");
```