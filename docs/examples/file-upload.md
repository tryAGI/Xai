# File Upload

Upload a file for use with the Batch API.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Upload a file by providing its content, filename, and purpose.
var content = "Hello from xAI SDK integration test."u8.ToArray();

var file = await client.Files.UploadFileAsync(
    file: content,
    filename: "test-upload.txt",
    purpose: "batch");

Console.WriteLine($"Uploaded: {file.Id} ({file.Bytes} bytes)");
```