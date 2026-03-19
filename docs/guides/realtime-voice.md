# Realtime Voice Agent

The `RealtimeVoiceClient` provides a WebSocket client for the xAI Realtime Voice Agent API at `wss://api.x.ai/v1/realtime`. It supports bidirectional audio/text streaming, server-side voice activity detection (VAD), function calling, and built-in tools like web search and X search.

## Quick Start

```csharp
using Xai;

using var client = new RealtimeVoiceClient(apiKey);
await client.ConnectAsync();

// Configure the session
await client.SendEventAsync(RealtimeClientEvent.SessionUpdate(new RealtimeSessionConfig
{
    Voice = "Eve",
    Instructions = "You are a helpful assistant. Respond briefly.",
    Modalities = ["text", "audio"],
    TurnDetection = new RealtimeTurnDetection
    {
        Type = "server_vad",
        Threshold = 0.85,
        SilenceDurationMs = 500,
    },
}));

// Send a text message and request a response
await client.SendEventAsync(RealtimeClientEvent.UserMessage("What's the weather like today?"));
await client.SendEventAsync(RealtimeClientEvent.CreateResponse(["text"]));

// Process server events
await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken))
{
    if (serverEvent.IsAudioTranscriptDelta)
        Console.Write(serverEvent.Delta);
    else if (serverEvent.IsResponseDone)
        break;
    else if (serverEvent.IsError)
        Console.Error.WriteLine($"Error: {serverEvent.Error?.Message}");
}
```

## Voices

Five voices are available:

| Voice | Description |
|-------|-------------|
| `Eve` | Default voice |
| `Ara` | Alternative voice |
| `Rex` | Alternative voice |
| `Sal` | Alternative voice |
| `Leo` | Alternative voice |

## Audio Formats

Configure input/output audio formats via `RealtimeAudioConfig`:

```csharp
await client.SendEventAsync(RealtimeClientEvent.SessionUpdate(new RealtimeSessionConfig
{
    Voice = "Eve",
    Modalities = ["text", "audio"],
    Audio = new RealtimeAudioConfig
    {
        Input = new RealtimeAudioDirectionConfig
        {
            Format = new RealtimeAudioFormatConfig
            {
                Type = "audio/pcm",  // Linear16 little-endian
                Rate = 24000,        // Sample rate in Hz
            },
        },
        Output = new RealtimeAudioDirectionConfig
        {
            Format = new RealtimeAudioFormatConfig
            {
                Type = "audio/pcm",
                Rate = 24000,
            },
        },
    },
}));
```

Supported formats:

| Format | Type | Sample Rates |
|--------|------|-------------|
| PCM (Linear16) | `audio/pcm` | 8000, 16000, 22050, 24000 (default), 32000, 44100, 48000 |
| G.711 µ-law | `audio/pcmu` | 8000 only |
| G.711 A-law | `audio/pcma` | 8000 only |

## Sending Audio

Stream raw audio data as base64-encoded chunks:

```csharp
// Read audio from a file or microphone
byte[] audioChunk = GetAudioChunk(); // your audio source
string base64Audio = Convert.ToBase64String(audioChunk);

// Send audio data
await client.SendEventAsync(RealtimeClientEvent.AppendAudio(base64Audio));

// Commit the audio buffer (in manual mode, or to force processing)
await client.SendEventAsync(RealtimeClientEvent.CommitAudio());
```

## Turn Detection

### Server VAD (Automatic)

The server automatically detects when the user starts and stops speaking:

```csharp
TurnDetection = new RealtimeTurnDetection
{
    Type = "server_vad",
    Threshold = 0.85,          // Sensitivity (0.1 - 0.9)
    SilenceDurationMs = 500,   // Silence before ending turn (0 - 10000)
    PrefixPaddingMs = 333,     // Audio to include before speech start (0 - 10000)
}
```

### Manual Mode

Set `TurnDetection` to `null` for manual control — you decide when to commit the audio buffer and trigger a response:

```csharp
await client.SendEventAsync(RealtimeClientEvent.SessionUpdate(new RealtimeSessionConfig
{
    Voice = "Eve",
    Modalities = ["text", "audio"],
    TurnDetection = null, // Manual mode
}));

// ... send audio chunks ...
await client.SendEventAsync(RealtimeClientEvent.CommitAudio());
await client.SendEventAsync(RealtimeClientEvent.CreateResponse(["audio"]));
```

## Tools

### Function Calling

Define custom functions the agent can invoke:

```csharp
await client.SendEventAsync(RealtimeClientEvent.SessionUpdate(new RealtimeSessionConfig
{
    Voice = "Eve",
    Modalities = ["text", "audio"],
    Tools = [
        RealtimeTool.Function(
            name: "get_weather",
            description: "Get the current weather for a location",
            parameters: new
            {
                type = "object",
                properties = new
                {
                    location = new { type = "string", description = "City name" },
                },
                required = new[] { "location" },
            }),
    ],
}));

// Handle function calls in the event loop
await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken))
{
    if (serverEvent.IsFunctionCallArgumentsDone)
    {
        // Execute the function
        var result = ExecuteFunction(serverEvent.Name!, serverEvent.Arguments!);

        // Send the result back
        await client.SendEventAsync(
            RealtimeClientEvent.FunctionCallOutput(serverEvent.CallId!, result));
        await client.SendEventAsync(RealtimeClientEvent.CreateResponse(["text", "audio"]));
    }
    else if (serverEvent.IsResponseDone)
    {
        break;
    }
}
```

### Built-in Tools

The xAI Realtime API includes built-in tools:

```csharp
Tools = [
    // Web search — searches the internet
    RealtimeTool.WebSearch(),

    // X search — searches posts on X (Twitter)
    RealtimeTool.XSearch(),

    // X search with allowed handles filter
    RealtimeTool.XSearch(allowedHandles: ["@elonmusk", "@xaboratory"]),

    // File search — searches uploaded document collections
    RealtimeTool.FileSearch(collectionIds: ["col_abc123"], maxResults: 5),
]
```

## Server Events Reference

Use the `Is*` helper properties to check event types:

| Property | Event Type | Description |
|----------|-----------|-------------|
| `IsSessionCreated` | `session.created` | WebSocket connection established |
| `IsSessionUpdated` | `session.updated` | Session config applied |
| `IsConversationCreated` | `conversation.created` | New conversation started |
| `IsSpeechStarted` | `input_audio_buffer.speech_started` | VAD detected speech |
| `IsSpeechStopped` | `input_audio_buffer.speech_stopped` | VAD detected silence |
| `IsAudioBufferCommitted` | `input_audio_buffer.committed` | Audio buffer committed |
| `IsTranscriptionCompleted` | `input_audio_transcription.completed` | User speech transcribed |
| `IsResponseCreated` | `response.created` | Response generation started |
| `IsResponseDone` | `response.done` | Response generation completed |
| `IsAudioTranscriptDelta` | `response.output_audio_transcript.delta` | Incremental transcript text |
| `IsAudioTranscriptDone` | `response.output_audio_transcript.done` | Full transcript available |
| `IsAudioDelta` | `response.output_audio.delta` | Incremental audio data (base64) |
| `IsAudioDone` | `response.output_audio.done` | Audio output completed |
| `IsFunctionCallArgumentsDone` | `response.function_call_arguments.done` | Function call ready to execute |
| `IsMcpListToolsCompleted` | `mcp_list_tools.completed` | MCP tool list received |
| `IsMcpCallArgumentsDone` | `response.mcp_call_arguments.done` | MCP tool call ready |
| `IsMcpCallCompleted` | `response.mcp_call.completed` | MCP tool call completed |
| `IsError` | `error` | Error occurred |
