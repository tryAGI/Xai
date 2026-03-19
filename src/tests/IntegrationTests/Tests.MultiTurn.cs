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
                    Content = "You are a helpful math tutor. Be concise.",
                },
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "What is 10 * 5?",
                },
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.Assistant,
                    Content = "50",
                },
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Now divide that by 2.",
                },
            ]);

        response.Choices.Should().NotBeNullOrEmpty();

        var content = response.Choices![0].Message?.Content;
        content.Should().NotBeNullOrEmpty();
        content.Should().Contain("25");
    }
}
