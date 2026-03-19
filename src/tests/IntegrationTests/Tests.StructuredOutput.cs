using System.Text.Json;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task CreateChatCompletionWithJsonObject()
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
                    Content = "You are a helpful assistant that responds in JSON format.",
                },
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Give me the capital of France. Respond with {\"capital\": \"...\"}",
                },
            ],
            responseFormat: new ResponseFormat
            {
                Type = ResponseFormatType.JsonObject,
            });

        response.Choices.Should().NotBeNullOrEmpty();

        var content = response.Choices![0].Message?.Content;
        content.Should().NotBeNullOrEmpty();

        // Verify it's valid JSON
        var json = JsonSerializer.Deserialize<JsonElement>(content!);
        json.GetProperty("capital").GetString().Should().Be("Paris");
    }

    [TestMethod]
    [TestCategory("Smoke")]
    public async Task CreateChatCompletionWithJsonSchema()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages:
            [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "What are the capitals of France and Germany?",
                },
            ],
            responseFormat: new ResponseFormat
            {
                Type = ResponseFormatType.JsonSchema,
                JsonSchema = new ResponseFormatJsonSchema
                {
                    Name = "capitals",
                    Description = "A list of country capitals",
                    Schema = JsonSerializer.Deserialize<object>("""
                        {
                            "type": "object",
                            "properties": {
                                "countries": {
                                    "type": "array",
                                    "items": {
                                        "type": "object",
                                        "properties": {
                                            "country": { "type": "string" },
                                            "capital": { "type": "string" }
                                        },
                                        "required": ["country", "capital"]
                                    }
                                }
                            },
                            "required": ["countries"]
                        }
                        """),
                    Strict = true,
                },
            });

        response.Choices.Should().NotBeNullOrEmpty();

        var content = response.Choices![0].Message?.Content;
        content.Should().NotBeNullOrEmpty();

        // Verify it's valid JSON matching the schema
        var json = JsonSerializer.Deserialize<JsonElement>(content!);
        var countries = json.GetProperty("countries");
        countries.GetArrayLength().Should().BeGreaterThanOrEqualTo(2);
    }
}
