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
    public async Task Example_ToolCalling()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

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

        var toolCall = response.Choices![0].Message!.ToolCalls![0];
        Console.WriteLine($"{toolCall.Function.Name}({toolCall.Function.Arguments})");
    }
}
