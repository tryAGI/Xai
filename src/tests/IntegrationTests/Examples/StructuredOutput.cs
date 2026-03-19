/*
order: 50
title: Structured Output
slug: structured-output

Get structured JSON output using JSON Schema or JSON Object response formats.
*/

using System.Text.Json;

namespace Xai.IntegrationTests;

public partial class Tests
{
    //// Use `ResponseFormatType.JsonSchema` with a strict schema to get validated structured output.
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_StructuredOutput_JsonSchema()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Extract the capital of France. Respond using the provided JSON schema.",
                },
            ],
            responseFormat: new ResponseFormat
            {
                Type = ResponseFormatType.JsonSchema,
                JsonSchema = new ResponseFormatJsonSchema
                {
                    Name = "capital_response",
                    Strict = true,
                    Schema = new
                    {
                        type = "object",
                        properties = new
                        {
                            country = new { type = "string" },
                            capital = new { type = "string" },
                        },
                        required = new[] { "country", "capital" },
                        additionalProperties = false,
                    },
                },
            });

        response.Choices.Should().NotBeNullOrEmpty();

        var content = response.Choices![0].Message?.Content;
        content.Should().NotBeNullOrEmpty();

        var json = JsonSerializer.Deserialize<JsonElement>(content!);
        json.GetProperty("capital").GetString().Should().Be("Paris");

        Console.WriteLine(content);
    }

    //// Use `ResponseFormatType.JsonObject` for simpler JSON responses without a schema.
    [TestMethod]
    [TestCategory("Smoke")]
    public async Task Example_StructuredOutput_JsonObject()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.System,
                    Content = "You always respond in valid JSON with a 'result' field.",
                },
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "What is 10 * 5?",
                },
            ],
            responseFormat: new ResponseFormat
            {
                Type = ResponseFormatType.JsonObject,
            });

        response.Choices.Should().NotBeNullOrEmpty();

        var content = response.Choices![0].Message?.Content;
        content.Should().NotBeNullOrEmpty();

        var json = JsonSerializer.Deserialize<JsonElement>(content!);
        json.GetProperty("result").GetInt32().Should().Be(50);

        Console.WriteLine(content);
    }
}
