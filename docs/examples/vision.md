# Vision

Analyze an image using a vision-capable model.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);

// Send both text and an image URL as a multi-part content message.
var response = await client.Chat.CreateChatCompletionAsync(
    model: "grok-2-vision",
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = new OneOf<string, IList<ChatCompletionContentPart>>(
                new List<ChatCompletionContentPart>
                {
                    new ChatCompletionContentPart
                    {
                        Type = ChatCompletionContentPartType.Text,
                        Text = "Describe this image in one sentence.",
                    },
                    new ChatCompletionContentPart
                    {
                        Type = ChatCompletionContentPartType.ImageUrl,
                        ImageUrl = new ChatCompletionContentPartImageUrl
                        {
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b0/NewTux.svg/150px-NewTux.svg.png",
                        },
                    },
                }),
        },
    ]);

Console.WriteLine(response.Choices![0].Message?.Content);
```