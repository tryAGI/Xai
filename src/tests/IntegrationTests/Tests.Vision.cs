namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task CreateChatCompletionWithImageInput()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Chat.CreateChatCompletionAsync(
            model: "grok-2-vision",
            messages:
            [
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
    }
}
