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
  - **Text-to-speech** (REST, streaming WebSocket, built-in and custom voices)
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

### Responses API
```csharp
// Create a response (stored server-side)
var response = await client.Responses.CreateResponseAsync(
    model: "grok-3-mini",
    input: "What is 2+2? Answer with just the number.");

Console.WriteLine(response.Output);

// Retrieve a stored response
var retrieved = await client.Responses.GetResponseAsync(response.Id!);

// Delete a stored response
await client.Responses.DeleteResponseAsync(response.Id!);
```

### Deferred Completions
```csharp
// Submit a deferred request (processed asynchronously)
var response = await client.Chat.CreateChatCompletionAsync(
    model: "grok-3-mini",
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Explain what a quasar is in two sentences.",
        },
    ],
    deferred: true);

// Poll for the result
var result = await client.Chat.GetDeferredCompletionAsync(response.Id!);
Console.WriteLine(result.Choices![0].Message?.Content);

// Or use the convenience helper that submits + polls automatically:
var completed = await client.CreateDeferredAndWaitAsync(
    new CreateChatCompletionRequest
    {
        Model = "grok-3-mini",
        Messages = [
            new ChatCompletionMessage
            {
                Role = ChatCompletionMessageRole.User,
                Content = "Write a haiku about programming.",
            },
        ],
    },
    pollingInterval: TimeSpan.FromSeconds(5),
    timeout: TimeSpan.FromMinutes(2));

Console.WriteLine(completed.Choices![0].Message?.Content);
```

### Microsoft.Extensions.AI

This SDK covers xAI-specific endpoints (images, video, realtime, etc.). For standard `IChatClient`/`IEmbeddingGenerator` support, use `CustomProviders.XAi()` from the [tryAGI.OpenAI](https://www.nuget.org/packages/tryAGI.OpenAI/) package:

```csharp
using tryAGI.OpenAI;
using Microsoft.Extensions.AI;

using var api = CustomProviders.XAi("API_KEY");
IChatClient chatClient = api;

var response = await chatClient.GetResponseAsync("Hello from Grok!");
Console.WriteLine(response.Text);
```

<!-- EXAMPLES:START -->
### Chat Completion
Send a simple chat completion request.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Create a chat completion with a simple user message.
var response = await client.Chat.CreateChatCompletionAsync(
    model: modelId,
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Say 'Hello, World!' and nothing else.",
        },
    ]);

Console.WriteLine(response.Choices![0].Message?.Content);
```

### Chat Completion Streaming
Stream a chat completion response token by token.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Stream the response and print each chunk as it arrives.
var chunks = new List<CreateChatCompletionStreamResponse>();
await foreach (var chunk in client.Chat.CreateChatCompletionAsStreamAsync(
    model: modelId,
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Tell me a short story.",
        },
    ]))
{
    chunks.Add(chunk);
    Console.Write(chunk.Choices?[0].Delta?.Content);
}
```

### Tool Calling
Use function tools to let the model call external functions.

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

### Parallel Tool Calls
Call multiple tools in parallel within a single response.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Define multiple tools that the model can call simultaneously.
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

// Enable `parallelToolCalls` so the model can invoke multiple tools at once.
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

var choice = response.Choices![0];
    "parallel tool calls should produce at least 2 tool calls");

var functionNames = choice.Message.ToolCalls.Select(tc => tc.Function.Name).ToList();

foreach (var tc in choice.Message.ToolCalls)
{
    Console.WriteLine($"{tc.Function.Name}({tc.Function.Arguments})");
}
```

### Reasoning
Use reasoning effort to get step-by-step thinking from grok-3-mini.

```csharp
var client = new XaiClient(apiKey);

// Enable reasoning with high effort to get a thinking trace alongside the answer.
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

var message = response.Choices![0].Message;
    "grok-3-mini with high reasoning effort should return reasoning content");

Console.WriteLine($"Reasoning: {message.ReasoningContent}");
Console.WriteLine($"Answer: {message.Content}");
```

### Seed Determinism
Use a fixed seed and temperature=0 for reproducible output.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

const int seed = 42;
const string prompt = "What is the capital of Japan? Answer with just the city name.";

// Send the same request twice with the same seed and temperature=0.
var response1 = await client.Chat.CreateChatCompletionAsync(
    model: modelId,
    messages:
    [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = prompt,
        },
    ],
    seed: seed,
    temperature: 0);

var response2 = await client.Chat.CreateChatCompletionAsync(
    model: modelId,
    messages:
    [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = prompt,
        },
    ],
    seed: seed,
    temperature: 0);

var content1 = response1.Choices![0].Message?.Content;
var content2 = response2.Choices![0].Message?.Content;

// With the same seed and temperature=0, outputs should be identical.
    "same seed and temperature=0 should produce deterministic output");

Console.WriteLine($"Response 1: {content1}");
Console.WriteLine($"Response 2: {content2}");
```

### Vision
Analyze an image using a vision-capable model.

```csharp
var client = new XaiClient(apiKey);

// Send both text and an image URL as a multi-part content message.
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
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b0/NewTux.svg/150px-NewTux.svg.png",
                        },
                    },
                }),
        },
    ]);

Console.WriteLine(response.Choices![0].Message?.Content);
```

### Image Generation
Generate an image from a text prompt.

```csharp
var client = new XaiClient(apiKey);

// Generate an image using the Grok Imagine model.
var response = await client.Images.CreateImageAsync(
    model: "grok-imagine-image",
    prompt: "A simple red circle on a white background");

Console.WriteLine(response.Data![0].Url);
```

### Image Editing
Edit an existing image using a text prompt.

```csharp
var client = new XaiClient(apiKey);

// Edit an image by providing a source image URL and an instruction prompt.
var response = await client.Images.CreateImageEditAsync(
    model: "grok-2-image",
    prompt: "Add a red hat to the person in the image",
    image: new ImageInput
    {
        Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/PNG_transparency_demonstration_1.png/280px-PNG_transparency_demonstration_1.png",
    });

Console.WriteLine(response.Data![0].Url);
```

### Video Generation
Generate a video from a text prompt using the polling helper.

```csharp
var client = new XaiClient(apiKey);

// Use the `GenerateAndWaitAsync` helper to submit a video request and poll until done.
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

### Text to Speech
Convert text to speech audio.

```csharp
var client = new XaiClient(apiKey);

// Generate speech audio from text. Built-in and custom voices are passed as voice IDs.
byte[] audioBytes = await client.Audio.CreateTextToSpeechAsync(
    text: "Hello from xAI!",
    language: "en",
    voiceId: "eve");

Console.WriteLine($"Generated {audioBytes.Length} bytes of audio.");
```

### Custom Voices
Use cloned voice IDs with text-to-speech.

```csharp
var customVoiceId =
    Environment.GetEnvironmentVariable("XAI_CUSTOM_VOICE_ID") is { Length: > 0 } value
        ? value
        : throw new AssertInconclusiveException(
            "XAI_CUSTOM_VOICE_ID environment variable is not found.");

var client = new XaiClient(apiKey);

// Retrieve metadata for a custom voice owned by your team.
var customVoice = await client.CustomVoices.GetCustomVoiceAsync(customVoiceId);

// Use the custom voice ID anywhere a built-in TTS voice ID is accepted.
byte[] audioBytes = await client.Audio.CreateTextToSpeechAsync(
    text: "Hello from my custom xAI voice.",
    language: "en",
    voiceId: customVoice.VoiceId);
```

### Text to Speech Streaming
Stream text deltas into the xAI Text to Speech WebSocket API and receive audio chunks as they are generated.

```csharp
var apiKey =
    Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
        ? apiKeyValue
        : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

// Create a WebSocket client and connect with the TTS voice, language, and audio format.
using var client = new Xai.TextToSpeech.XaiTextToSpeechStreamingClient(apiKey);
await client.ConnectAsync(
    language: "en",
    voice: "eve",
    codec: "mp3");

// Stream text as one or more deltas, then flush the utterance with text.done.
await client.SendTextDeltaAsync(new Xai.TextToSpeech.TextDeltaPayload
{
    Delta = "Hello from xAI streaming text to speech.",
});
await client.SendTextDoneAsync(new Xai.TextToSpeech.TextDonePayload());

// Receive base64 audio chunks until the utterance is complete.
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
using var audio = new MemoryStream();
var receivedAudioDone = false;

await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
{
    if (serverEvent.IsAudioDelta)
    {
        audio.Write(serverEvent.AudioDelta.DeltaBytes.Span);
    }
    else if (serverEvent.IsAudioDone)
    {
        receivedAudioDone = true;
        break;
    }
    else if (serverEvent.IsError)
    {
        throw new InvalidOperationException($"Received error: {serverEvent.Error?.Message}");
    }
}

Console.WriteLine($"Generated {audio.Length} streaming audio bytes.");
```

### Responses API
Create, retrieve, and delete server-stored responses.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Create a response that is stored server-side for later retrieval.
var response = await client.Responses.CreateResponseAsync(
    model: modelId,
    input: "What is 2+2? Answer with just the number.");

Console.WriteLine($"Response: {response.Output}");

// Retrieve the stored response by ID.
var retrieved = await client.Responses.GetResponseAsync(response.Id!);

Console.WriteLine($"Retrieved: {retrieved.Id}");

// Delete the stored response when no longer needed.
var deleted = await client.Responses.DeleteResponseAsync(response.Id!);

Console.WriteLine($"Deleted: {deleted.Deleted}");
```

### Deferred Completion
Submit a chat completion for asynchronous processing and poll for the result.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Submit a deferred request — it returns immediately with a request ID.
var response = await client.Chat.CreateChatCompletionAsync(
    model: modelId,
    messages: [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Explain what a quasar is in two sentences.",
        },
    ],
    deferred: true);

// Poll for the result (the request is processed asynchronously).
await Task.Delay(TimeSpan.FromSeconds(5));

var result = await client.Chat.GetDeferredCompletionAsync(response.Id!);

Console.WriteLine(result.Choices![0].Message?.Content);
```

### Realtime Voice
Connect to the Realtime Voice Agent WebSocket API for bidirectional text/audio streaming.

```csharp
var apiKey =
    Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } apiKeyValue
        ? apiKeyValue
        : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.");

// Create a WebSocket client and connect to the xAI Realtime API.
using var client = new XaiRealtimeClient(apiKey);
await client.ConnectAsync();

// Configure the session with voice, instructions, and turn detection.
await client.SendSessionUpdateAsync(new SessionUpdatePayload
{
    Session = new SessionConfig
    {
        Voice = "eve",
        Instructions = "You are a helpful assistant. Respond briefly.",
        Modalities = ["text", "audio"],
        TurnDetection = new TurnDetection
        {
            Type = "server_vad",
            Threshold = 0.85,
            SilenceDurationMs = 500,
        },
    },
});

// Send a text message and request a text response.
await client.SendConversationItemCreateAsync(new ConversationItemCreatePayload
{
    Item = new ConversationItem
    {
        Type = "message",
        Role = "user",
        Content = [new ContentPart { Type = "input_text", Text = "Say hello!" }],
    },
});
await client.SendResponseCreateAsync(new ResponseCreatePayload
{
    Response = new ResponseConfig
    {
        Modalities = ["text"],
    },
});

// Receive server events until the response is complete.
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
var receivedSessionUpdated = false;
var receivedResponseDone = false;
string? transcriptText = null;

await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
{
    if (serverEvent.IsSessionUpdated)
    {
        receivedSessionUpdated = true;
    }
    else if (serverEvent.IsResponseOutputAudioTranscriptDelta)
    {
        transcriptText = (transcriptText ?? "") + serverEvent.ResponseOutputAudioTranscriptDelta?.Delta;
        Console.Write(serverEvent.ResponseOutputAudioTranscriptDelta?.Delta);
    }
    else if (serverEvent.IsResponseDone)
    {
        receivedResponseDone = true;
        break;
    }
    else if (serverEvent.IsError)
    {
        throw new InvalidOperationException($"Received error: {serverEvent.Error?.Error?.Message}");
    }
}
```

### Multi-Turn Conversation
Continue a conversation across multiple turns with system instructions and history.

```csharp
var client = new XaiClient(apiKey);
var modelId = GetModelId();

// Pass a system message and conversation history to maintain context across turns.
var response = await client.Chat.CreateChatCompletionAsync(
    model: modelId,
    messages:
    [
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.System,
            Content = "You are a helpful math tutor. Always show your work.",
        },
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "What is 7 * 8?",
        },
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.Assistant,
            Content = "7 * 8 = 56",
        },
        new ChatCompletionMessage
        {
            Role = ChatCompletionMessageRole.User,
            Content = "Now divide that result by 4.",
        },
    ]);

var content = response.Choices![0].Message?.Content;
    "56 / 4 = 14, and the model should reference the previous result");

Console.WriteLine(content);
```

### Document Search
Search uploaded document collections using hybrid search.

```csharp
var client = new XaiClient(apiKey);

var collectionId =
    Environment.GetEnvironmentVariable("XAI_COLLECTION_ID") is { Length: > 0 } value
        ? value
        : throw new AssertInconclusiveException(
            "XAI_COLLECTION_ID environment variable is not found.");

// Search across document collections using hybrid (semantic + keyword) mode.
var response = await client.Collections.SearchDocumentsAsync(
    query: "What is xAI?",
    collectionIds: [collectionId],
    mode: SearchDocumentsRequestMode.Hybrid,
    maxNumResults: 5);

foreach (var result in response.Results!)
{
    Console.WriteLine($"Score: {result.Score:F3} — {result.Content?[..Math.Min(80, result.Content?.Length ?? 0)]}...");
}
```

### File Upload
Upload a file for use with the Batch API.

```csharp
var client = new XaiClient(apiKey);

// Upload a file by providing its content, filename, and purpose.
var content = "Hello from xAI SDK integration test."u8.ToArray();

var file = await client.Files.UploadFileAsync(
    file: content,
    filename: "test-upload.txt",
    purpose: "batch");

Console.WriteLine($"Uploaded: {file.Id} ({file.Bytes} bytes)");
```

### API Key Info
Retrieve information about the current API key.

```csharp
var client = new XaiClient(apiKey);

// Check the current API key's metadata — useful for diagnostics and validation.
var info = await client.Auth.GetApiKeyInfoAsync();

Console.WriteLine($"Key: {info.RedactedApiKey}");
Console.WriteLine($"User: {info.UserId}");
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Xai/issues
Priority place for ideas and general questions: https://github.com/tryAGI/Xai/discussions
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
