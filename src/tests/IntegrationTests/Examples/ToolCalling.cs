/*
order: 30
title: Tool Calling
slug: tool-calling

Use function tools to let the model call external functions.
*/

using System.Text.Json;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_ToolCalling()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        //// Define a function tool with a JSON Schema for its parameters.
        var tools = new List<ChatCompletionTool>
        {
            new ChatCompletionTool
            {
                Type = ChatCompletionToolType.Function,
                Function = new FunctionDefinition
                {
                    Name = "get_weather",
                    Description = "Get the current weather for a location.",
                    Parameters = JsonSerializer.Deserialize<JsonElement>("""
                        {
                            "type": "object",
                            "properties": {
                                "location": {
                                    "type": "string",
                                    "description": "The city name."
                                }
                            },
                            "required": ["location"]
                        }
                        """),
                },
            },
        };

        //// Send a message that should trigger the tool call.
        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "What is the weather in San Francisco?",
                },
            ],
            tools: tools,
            toolChoice: new OneOf<CreateChatCompletionRequestToolChoice?, ChatCompletionNamedToolChoice>(
                CreateChatCompletionRequestToolChoice.Auto));

        response.Choices.Should().NotBeNullOrEmpty();

        var choice = response.Choices![0];
        choice.FinishReason.Should().Be(ChatCompletionChoiceFinishReason.ToolCalls);
        choice.Message?.ToolCalls.Should().NotBeNullOrEmpty();

        //// Inspect the tool call the model wants to make.
        var toolCall = choice.Message!.ToolCalls![0];
        toolCall.Function.Name.Should().Be("get_weather");
        toolCall.Function.Arguments.Should().Contain("San Francisco");

        Console.WriteLine($"{toolCall.Function.Name}({toolCall.Function.Arguments})");
    }
}
