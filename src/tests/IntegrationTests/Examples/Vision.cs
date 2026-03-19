/*
order: 60
title: Vision
slug: vision

Analyze an image using a vision-capable model.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Vision()
    {
        var client = GetAuthenticatedClient();

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
    }
}
