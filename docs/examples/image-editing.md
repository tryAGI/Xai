# Image Editing

Edit an existing image using a text prompt.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Edit an image by providing a source image URL and an instruction prompt.
var response = await client.Images.CreateImageEditAsync(
    model: "grok-2-image",
    prompt: "Add a red hat to the person in the image",
    image: new ImageInput
    {
        Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/PNG_transparency_demonstration_1.png/280px-PNG_transparency_demonstration_1.png",
    });

Console.WriteLine(response.Data![0].Url);
```