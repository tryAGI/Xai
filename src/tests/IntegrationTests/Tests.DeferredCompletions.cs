namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task DeferredCompletion()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        // Submit deferred request
        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Explain what a quasar is in two sentences.",
                },
            ],
            deferred: true);

        response.Id.Should().NotBeNullOrEmpty();

        // Poll for result (may take time)
        await Task.Delay(TimeSpan.FromSeconds(5));

        var result = await client.Chat.GetDeferredCompletionAsync(response.Id!);
        result.Choices.Should().NotBeNullOrEmpty();
    }
}
