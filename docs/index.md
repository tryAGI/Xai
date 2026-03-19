# Xai

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.Xai)](https://www.nuget.org/packages/tryAGI.Xai/)
[![dotnet](https://github.com/tryAGI/Xai/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Xai/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Xai)](https://github.com/tryAGI/Xai/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

> **Disclaimer:** This package is not affiliated with, endorsed by, or sponsored by xAI. xAI and Grok are trademarks of xAI Corp.

## Features 🔥
- Fully generated C# SDK based on a hand-curated xAI OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Comprehensive API coverage:
  - **Chat completions** (streaming, tool calling, reasoning, structured output, deferred)
  - **Vision** (image input with Grok Vision models)
  - **Image generation & editing** (Grok Imagine)
  - **Video generation** with polling helper
  - **Text-to-speech** (multiple voices)
  - **Realtime voice** WebSocket client (bidirectional audio/text, VAD, tools)
  - **Embeddings**, **Batches**, **Files**, **Collections**

## Usage

```csharp
using Xai;

using var client = new XaiClient(apiKey);
```

### Chat Completion
```csharp
var response = await client.Chat.CreateChatCompletionAsync(
    model: "grok-3-mini",
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "What is the meaning of life?",
        },
    ]);

Console.WriteLine(response.Choices![0].Message?.Content);
```

### Streaming
```csharp
await foreach (var chunk in client.Chat.CreateChatCompletionAsStreamAsync(
    model: "grok-3-mini",
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Tell me a short story.",
        },
    ]))
{
    Console.Write(chunk.Choices?[0].Delta?.Content);
}
```

### Tool Calling
```csharp
using System.Text.Json;

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
                        "location": { "type": "string", "description": "The city name." }
                    },
                    "required": ["location"]
                }
                """),
        },
    },
};

var response = await client.Chat.CreateChatCompletionAsync(
    model: "grok-3-mini",
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
```

### Reasoning
```csharp
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

Console.WriteLine(response.Choices![0].Message?.ReasoningContent); // reasoning trace
Console.WriteLine(response.Choices![0].Message?.Content);          // final answer
```

### Structured Output (JSON Schema)
```csharp
var response = await client.Chat.CreateChatCompletionAsync(
    model: "grok-3-mini",
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

Console.WriteLine(response.Choices![0].Message?.Content);
// {"country":"France","capital":"Paris"}
```

### Vision (Image Input)
```csharp
var response = await client.Chat.CreateChatCompletionAsync(
    model: "grok-2-vision",
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = new OneOf<string, IList<ChatCompletionContentPart>>(
                new List<ChatCompletionContentPart>
                {
                    new ChatCompletionContentPart
                    {
                        Type = ChatCompletionContentPartType.Text,
                        Text = "Describe this image in one sentence.",
                    },
                    new ChatCompletionContentPart
                    {
                        Type = ChatCompletionContentPartType.ImageUrl,
                        ImageUrl = new ChatCompletionContentPartImageUrl
                        {
                            Url = "https://example.com/image.png",
                        },
                    },
                }),
        },
    ]);

Console.WriteLine(response.Choices![0].Message?.Content);
```

### Image Generation
```csharp
var response = await client.Images.CreateImageAsync(
    model: "grok-imagine-image",
    prompt: "A futuristic cityscape at sunset");

Console.WriteLine(response.Data![0].Url);
```

### Image Editing
```csharp
var response = await client.Images.CreateImageEditAsync(
    model: "grok-2-image",
    prompt: "Add a red hat to the person in the image",
    image: new ImageInput
    {
        Url = "https://example.com/photo.png",
    });

Console.WriteLine(response.Data![0].Url);
```

### Video Generation
```csharp
var status = await client.GenerateAndWaitAsync(
    new CreateVideoRequest
    {
        Model = "grok-imagine-video",
        Prompt = "A gentle ocean wave rolling onto a sandy beach at sunset",
        Duration = 3,
        Resolution = CreateVideoRequestResolution.x480p,
    },
    pollingInterval: TimeSpan.FromSeconds(10),
    timeout: TimeSpan.FromMinutes(5));

Console.WriteLine(status.Video?.Url);
```

### Text-to-Speech
```csharp
byte[] audioBytes = await client.Audio.CreateSpeechAsync(
    model: "tts-1",
    input: "Hello from xAI!",
    voice: CreateSpeechRequestVoice.Eve);

File.WriteAllBytes("output.mp3", audioBytes);
```

### Realtime Voice
```csharp
using var voiceClient = new RealtimeVoiceClient(apiKey);
await voiceClient.ConnectAsync();

// Configure session
await voiceClient.SendEventAsync(RealtimeClientEvent.SessionUpdate(new RealtimeSessionConfig
{
    Voice = "Eve",
    Instructions = "You are a helpful assistant.",
    Modalities = ["text", "audio"],
    TurnDetection = new RealtimeTurnDetection
    {
        Type = "server_vad",
        Threshold = 0.85,
        SilenceDurationMs = 500,
    },
}));

// Send a text message and request response
await voiceClient.SendEventAsync(RealtimeClientEvent.UserMessage("Say hello!"));
await voiceClient.SendEventAsync(RealtimeClientEvent.CreateResponse(["text"]));

// Receive events
await foreach (var serverEvent in voiceClient.ReceiveUpdatesAsync(cancellationToken))
{
    if (serverEvent.IsAudioTranscriptDelta)
        Console.Write(serverEvent.Delta);
    else if (serverEvent.IsResponseDone)
        break;
}
```

### Microsoft.Extensions.AI

This SDK covers xAI-specific endpoints (images, video, realtime, etc.). For standard `IChatClient`/`IEmbeddingGenerator` support, use `CustomProviders.XAi()` from the [tryAGI.OpenAI](https://www.nuget.org/packages/tryAGI.OpenAI/) package:

```csharp
using OpenAI;
using Microsoft.Extensions.AI;

IChatClient chatClient = new OpenAIClient(apiKey, CustomProviders.XAi());

var response = await chatClient.GetResponseAsync("Hello from Grok!");
Console.WriteLine(response.Text);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Xai/issues
Priority place for ideas and general questions: https://github.com/tryAGI/Xai/discussions
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
