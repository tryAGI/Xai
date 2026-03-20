# Video Generation

Generate a video from a text prompt using the polling helper.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Use the `GenerateAndWaitAsync` helper to submit a video request and poll until done.
var status = await client.GenerateAndWaitAsync(
    new CreateVideoRequest
    {
        Model = "grok-imagine-video",
        Prompt = "A gentle ocean wave rolling onto a sandy beach at sunset",
        Duration = 3,
        Resolution = CreateVideoRequestResolution.x480p,
    },
    pollingInterval: TimeSpan.FromSeconds(10),
    timeout: TimeSpan.FromMinutes(5));

Console.WriteLine(status.Video?.Url);
```