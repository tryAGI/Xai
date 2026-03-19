/*
order: 50
title: Structured Output
slug: structured-output

Get structured JSON output using a JSON Schema response format.
*/

using System.Text.Json;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StructuredOutput()
    {
        var client = GetAuthenticatedClient();
        var modelId = GetModelId();

        var response = await client.Chat.CreateChatCompletionAsync(
            model: modelId,
            messages: [
                new ChatCompletionMessage
                {
                    Role = ChatCompletionMessageRole.User,
                    Content = "Extract the capital of France.",
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

        var json = JsonSerializer.Deserialize<JsonElement>(response.Choices![0].Message?.Content!);
        Console.WriteLine($"{json.GetProperty("country")}: {json.GetProperty("capital")}");
    }
}
