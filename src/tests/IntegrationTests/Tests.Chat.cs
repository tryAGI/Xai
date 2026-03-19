namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task CreateChatCompletion()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Say 'Hello, World!' and nothing else.",
                },
            ]);

        response.Choices.Should().NotBeNullOrEmpty();
        response.Choices![0].Message?.Content.Should().NotBeNullOrEmpty();
        response.Usage?.TotalTokens.Should().BeGreaterThan(0);
    }
}
