/*
order: 40
title: Reasoning
slug: reasoning

Use reasoning effort to get step-by-step thinking from grok-3-mini.
*/

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_Reasoning()
    {
        var client = GetAuthenticatedClient();

        //// Enable reasoning with high effort to get a thinking trace alongside the answer.
        var response = await client.Chat.CreateChatCompletionAsync(
            model: "grok-3-mini",
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "What is 15 * 37? Think step by step.",
                },
            ],
            reasoningEffort: CreateChatCompletionRequestReasoningEffort.High);

        response.Choices.Should().NotBeNullOrEmpty();

        var message = response.Choices![0].Message;
        message.Should().NotBeNull();
        message!.Content.Should().NotBeNullOrEmpty();
        message.ReasoningContent.Should().NotBeNullOrEmpty(
            "grok-3-mini with high reasoning effort should return reasoning content");

        Console.WriteLine($"Reasoning: {message.ReasoningContent}");
        Console.WriteLine($"Answer: {message.Content}");
    }
}
