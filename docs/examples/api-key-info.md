# API Key Info

Retrieve information about the current API key.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Check the current API key's metadata — useful for diagnostics and validation.
var info = await client.Auth.GetApiKeyInfoAsync();

Console.WriteLine($"Key: {info.RedactedApiKey}");
Console.WriteLine($"User: {info.UserId}");
```