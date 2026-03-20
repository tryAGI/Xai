# Image Generation

Generate an image from a text prompt.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Generate an image using the Grok Imagine model.
var response = await client.Images.CreateImageAsync(
    model: "grok-imagine-image",
    prompt: "A simple red circle on a white background");

Console.WriteLine(response.Data![0].Url);
```