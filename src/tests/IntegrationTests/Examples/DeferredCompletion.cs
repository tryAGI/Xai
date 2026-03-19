/*
order: 120
title: Deferred Completion
slug: deferred-completion

Submit a chat completion for asynchronous processing and poll for the result.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task Example_DeferredCompletion()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        //// Submit a deferred request — it returns immediately with a request ID.
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

        //// Poll for the result (the request is processed asynchronously).
        await Task.Delay(TimeSpan.FromSeconds(5));

        var result = await client.Chat.GetDeferredCompletionAsync(response.Id!);
        result.Choices.Should().NotBeNullOrEmpty();

        Console.WriteLine(result.Choices![0].Message?.Content);
    }
}
