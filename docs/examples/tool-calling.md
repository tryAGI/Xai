# Tool Calling

Use function tools to let the model call external functions.

This example assumes `using Xai;` is in scope and `apiKey` contains your Xai API key.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Define a function tool with a JSON Schema for its parameters.
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

// Send a message that should trigger the tool call.
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

var choice = response.Choices![0];

// Inspect the tool call the model wants to make.
var toolCall = choice.Message!.ToolCalls![0];

Console.WriteLine($"{toolCall.Function.Name}({toolCall.Function.Arguments})");
```