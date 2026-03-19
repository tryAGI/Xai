namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task CreateChatCompletionMultiTurn()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages:
            [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.System,
                    Content = "You are a helpful math tutor. Always show your work.",
                },
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "What is 7 * 8?",
                },
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.Assistant,
                    Content = "7 * 8 = 56",
                },
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Now divide that result by 4.",
                },
            ]);

        response.Choices.Should().NotBeNullOrEmpty();

        var content = response.Choices![0].Message?.Content;
        content.Should().NotBeNullOrEmpty();
        content.Should().Contain("14",
            "56 / 4 = 14, and the model should reference the previous result");
    }
}
