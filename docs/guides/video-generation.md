# Video Generation

The xAI SDK supports video generation using Grok Imagine Video models. Video generation is asynchronous — you submit a request, then poll for the result. The SDK includes a `GenerateAndWaitAsync` helper that handles the polling for you.

## Quick Start

```csharp
using Xai;

using var client = new XaiClient(apiKey);

var status = await client.GenerateAndWaitAsync(
    new CreateVideoRequest
    {
        Model = "grok-imagine-video",
        Prompt = "A gentle ocean wave rolling onto a sandy beach at sunset",
        Duration = 3,
        Resolution = CreateVideoRequestResolution.x480p,
    });

Console.WriteLine(status.Video?.Url);
```

## Manual Polling

If you need more control over the polling process, use the low-level APIs:

```csharp
// Step 1: Submit the video generation request
var createResponse = await client.Videos.CreateVideoAsync(new CreateVideoRequest
{
    Model = "grok-imagine-video",
    Prompt = "A cat playing piano in a jazz club",
    Duration = 5,
    Resolution = CreateVideoRequestResolution.x480p,
});

var requestId = createResponse.RequestId!;
Console.WriteLine($"Submitted: {requestId}");

// Step 2: Poll for status
while (true)
{
    await Task.Delay(TimeSpan.FromSeconds(10));

    var status = await client.Videos.GetVideoStatusAsync(requestId);

    switch (status.Status)
    {
        case VideoStatusResponseStatus.Done:
            Console.WriteLine($"Video ready: {status.Video?.Url}");
            return;

        case VideoStatusResponseStatus.Failed:
            Console.Error.WriteLine("Video generation failed.");
            return;

        case VideoStatusResponseStatus.Expired:
            Console.Error.WriteLine("Video generation expired.");
            return;

        case VideoStatusResponseStatus.Pending:
        default:
            Console.WriteLine("Still generating...");
            continue;
    }
}
```

## GenerateAndWaitAsync Options

The `GenerateAndWaitAsync` extension method accepts these parameters:

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `request` | `CreateVideoRequest` | *required* | The video generation request |
| `pollingInterval` | `TimeSpan?` | 5 seconds | How often to check the status |
| `timeout` | `TimeSpan?` | 10 minutes | Maximum total wait time |
| `cancellationToken` | `CancellationToken` | `default` | Cancellation token |

The method throws:

- `TimeoutException` if the video generation exceeds the timeout
- `InvalidOperationException` if the video generation fails or expires

```csharp
// With custom polling options
var status = await client.GenerateAndWaitAsync(
    new CreateVideoRequest
    {
        Model = "grok-imagine-video",
        Prompt = "Northern lights dancing over a frozen lake",
        Duration = 3,
        Resolution = CreateVideoRequestResolution.x480p,
    },
    pollingInterval: TimeSpan.FromSeconds(15),
    timeout: TimeSpan.FromMinutes(10));
```

## Resolutions

| Enum Value | Resolution |
|------------|-----------|
| `CreateVideoRequestResolution.x480p` | 480p |
