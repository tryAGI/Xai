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
    [TestCategory("Smoke")]
    public async Task Example_Vision()
    {
        var client = GetAuthenticatedClient();

        //// Send both text and an image URL as a multi-part content message.
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

        response.Choices.Should().NotBeNullOrEmpty();
        response.Choices![0].Message?.Content.Should().NotBeNullOrEmpty();

        Console.WriteLine(response.Choices![0].Message?.Content);
    }
}
