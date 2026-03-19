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
    public async Task Example_Reasoning()
    {
        var client = GetAuthenticatedClient();

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

        Console.WriteLine($"Reasoning: {response.Choices![0].Message?.ReasoningContent}");
        Console.WriteLine($"Answer: {response.Choices![0].Message?.Content}");
    }
}
