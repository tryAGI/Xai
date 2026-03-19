using System.Text.Json;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task CreateChatCompletionWithParallelToolCalls()
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
            new ChatCompletionTool
            {
                Type = ChatCompletionToolType.Function,
                Function = new FunctionDefinition
                {
                    Name = "get_time",
                    Description = "Get the current time for a timezone.",
                    Parameters = JsonSerializer.Deserialize<JsonElement>("""
                        {
                            "type": "object",
                            "properties": {
                                "timezone": {
                                    "type": "string",
                                    "description": "The IANA timezone name."
                                }
                            },
                            "required": ["timezone"]
                        }
                        """),
                },
            },
        };

        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages:
            [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "What's the weather in Tokyo and what time is it in America/New_York?",
                },
            ],
            tools: tools,
            parallelToolCalls: true,
            toolChoice: new OneOf<CreateChatCompletionRequestToolChoice?, ChatCompletionNamedToolChoice>(
                CreateChatCompletionRequestToolChoice.Auto));

        response.Choices.Should().NotBeNullOrEmpty();

        var choice = response.Choices![0];
        choice.FinishReason.Should().Be(ChatCompletionChoiceFinishReason.ToolCalls);
        choice.Message?.ToolCalls.Should().NotBeNullOrEmpty();
        choice.Message!.ToolCalls!.Count.Should().BeGreaterThanOrEqualTo(2,
            "parallel tool calls should produce at least 2 tool calls");

        var functionNames = choice.Message.ToolCalls.Select(tc => tc.Function.Name).ToList();
        functionNames.Should().Contain("get_weather");
        functionNames.Should().Contain("get_time");
    }
}
