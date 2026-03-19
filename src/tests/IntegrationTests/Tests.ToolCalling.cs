using System.Text.Json;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task CreateChatCompletionWithToolCalling()
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
                    Parameters = JsonSerializer.SerializeToNode(new
                    {
                        type = "object",
                        properties = new
                        {
                            location = new
                            {
                                type = "string",
                                description = "The city name.",
                            },
                        },
                        required = new[] { "location" },
                    }),
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

        var toolCall = choice.Message!.ToolCalls![0];
        toolCall.Function.Name.Should().Be("get_weather");
        toolCall.Function.Arguments.Should().Contain("San Francisco");
    }
}
