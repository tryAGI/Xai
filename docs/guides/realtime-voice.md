# Realtime Speech-to-Speech

`XaiRealtimeClient` is the SDK's WebSocket client for the xAI Speech-to-Speech API at `wss://api.x.ai/v1/realtime`. It supports bidirectional audio and text, server-side voice activity detection (VAD), function calling, built-in search tools, reconnects, and typed Grok Voice model selection.

See the [xAI Speech-to-Speech guide](https://docs.x.ai/developers/model-capabilities/audio/speech-to-speech) and [Voice API reference](https://docs.x.ai/developers/rest-api-reference/inference/voice) for service behavior and limits.

## Quick Start

```csharp
using Xai.Realtime;

await using var client = new XaiRealtimeClient(apiKey);
await client.ConnectAsync(
    model: VoiceModel.GrokVoiceThinkFast20,
    reasoningEffort: VoiceReasoningEffort.High,
    cancellationToken: cancellationToken);

await client.SendSessionUpdateAsync(new SessionUpdatePayload
{
    Session = new SessionConfig
    {
        Voice = "eve",
        Instructions = "Be helpful and concise.",
        Modalities = ["text", "audio"],
        TurnDetection = new TurnDetection
        {
            Type = "server_vad",
            Threshold = 0.85,
            SilenceDurationMs = 500,
            PrefixPaddingMs = 333,
        },
    },
}, cancellationToken);

await client.SendConversationItemCreateAsync(new ConversationItemCreatePayload
{
    Item = new ConversationItem
    {
        Type = "message",
        Role = "user",
        Content =
        [
            new ContentPart
            {
                Type = "input_text",
                Text = "Introduce yourself in one sentence.",
            },
        ],
    },
}, cancellationToken);

await client.SendResponseCreateAsync(new ResponseCreatePayload
{
    Response = new ResponseConfig { Modalities = ["text", "audio"] },
}, cancellationToken);

await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken))
{
    if (serverEvent.IsResponseOutputAudioTranscriptDelta)
    {
        Console.Write(serverEvent.ResponseOutputAudioTranscriptDelta?.Delta);
    }
    else if (serverEvent.IsResponseDone)
    {
        break;
    }
    else if (serverEvent.IsError)
    {
        throw new InvalidOperationException(serverEvent.Error?.Error?.Message);
    }
}
```

## Authentication

Use the API-key constructor in server-side applications:

```csharp
await using var client = new XaiRealtimeClient(apiKey);
```

For a short-lived client secret, create the client without an API key and pass the token using the WebSocket subprotocol expected by xAI:

```csharp
await using var client = new XaiRealtimeClient();
await client.ConnectAsync(
    model: VoiceModel.GrokVoiceLatest,
    additionalSubProtocols: [$"xai-client-secret.{clientSecret}"],
    cancellationToken: cancellationToken);
```

Do not expose a long-lived xAI API key in a browser or mobile client.

## Models and Reasoning

The model and reasoning effort are selected during the WebSocket handshake:

```csharp
await client.ConnectAsync(
    model: VoiceModel.GrokVoiceThinkFast20,
    reasoningEffort: VoiceReasoningEffort.High,
    cancellationToken: cancellationToken);
```

| SDK value | Wire value | Use |
|---|---|---|
| `VoiceModel.GrokVoiceLatest` | `grok-voice-latest` | Follow xAI's recommended model automatically |
| `VoiceModel.GrokVoiceThinkFast20` | `grok-voice-think-fast-2.0` | Pin Think Fast 2.0 for stable behavior |
| `VoiceModel.GrokVoiceThinkFast10` | `grok-voice-think-fast-1.0` | Remain on the previous model intentionally |
| `VoiceReasoningEffort.High` | `high` | Enable reasoning; this is the service default |
| `VoiceReasoningEffort.None` | `none` | Disable reasoning |

The `grok-voice-latest` alias moves from Think Fast 1.0 to Think Fast 2.0 on August 5, 2026. Pin a versioned model when production behavior must remain stable.

If you supply the low-level `uri` override to `ConnectAsync`, include any required query parameters in that URI. The typed `model` and `reasoningEffort` values are used when the SDK builds the default endpoint URI.

## Session Configuration

Send `SessionUpdatePayload` after connecting. Voice IDs are lowercase; use a built-in voice such as `eve`, `ara`, `rex`, `sal`, or `leo`, or a custom voice ID returned by the Custom Voices API.

### Audio Formats

```csharp
await client.SendSessionUpdateAsync(new SessionUpdatePayload
{
    Session = new SessionConfig
    {
        Voice = "eve",
        Modalities = ["text", "audio"],
        Audio = new AudioConfig
        {
            Input = new AudioDirectionConfig
            {
                Format = new AudioFormatConfig
                {
                    Type = "audio/pcm",
                    Rate = 24000,
                },
            },
            Output = new AudioDirectionConfig
            {
                Format = new AudioFormatConfig
                {
                    Type = "audio/pcm",
                    Rate = 24000,
                },
            },
        },
    },
}, cancellationToken);
```

| Format | `Type` | Supported sample rates |
|---|---|---|
| PCM16 little-endian | `audio/pcm` | 8000, 16000, 22050, 24000, 32000, 44100, 48000 |
| G.711 μ-law | `audio/pcmu` | 8000 |
| G.711 A-law | `audio/pcma` | 8000 |
| Opus packets | `audio/opus` | 24000 |

For lowest integration overhead, capture and play 24 kHz PCM16 so the application does not need to resample.

### Server VAD

With server VAD, xAI detects speech boundaries and creates responses automatically:

```csharp
TurnDetection = new TurnDetection
{
    Type = "server_vad",
    Threshold = 0.85,
    SilenceDurationMs = 500,
    PrefixPaddingMs = 333,
};
```

Higher thresholds require louder input before speech starts. Increase `SilenceDurationMs` when callers need longer pauses without ending their turn.

### Manual Turn Control

Manual mode requires an explicit JSON `null` for `turn_detection`. Use the raw send method for this configuration because the generated serializer omits nullable properties:

```csharp
await client.SendAsync(
    """
    {
      "type": "session.update",
      "session": {
        "voice": "eve",
        "modalities": ["text", "audio"],
        "turn_detection": null
      }
    }
    """,
    cancellationToken);
```

In manual mode, append audio, commit it, and request a response yourself.

## Sending Audio

The byte overload accepts raw audio and handles base64 encoding for `input_audio_buffer.append`:

```csharp
ReadOnlyMemory<byte> audioChunk = await GetMicrophoneChunkAsync(cancellationToken);
await client.SendInputAudioBufferAppendAsync(
    audio: audioChunk,
    cancellationToken: cancellationToken);
```

Send chunks continuously while the caller is speaking. Approximately 100 ms per chunk is a practical starting point.

When using manual turn detection, finish the turn explicitly:

```csharp
await client.SendInputAudioBufferCommitAsync(
    new InputAudioBufferCommitPayload(),
    cancellationToken);

await client.SendResponseCreateAsync(new ResponseCreatePayload
{
    Response = new ResponseConfig { Modalities = ["text", "audio"] },
}, cancellationToken);
```

## Receiving Audio and Transcripts

Audio deltas are base64 strings. Decode and enqueue each chunk for playback as soon as it arrives:

```csharp
await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken))
{
    if (serverEvent.IsResponseOutputAudioDelta &&
        serverEvent.ResponseOutputAudioDelta?.Delta is { Length: > 0 } delta)
    {
        byte[] audioBytes = Convert.FromBase64String(delta);
        await playbackStream.WriteAsync(audioBytes, cancellationToken);
    }
    else if (serverEvent.IsResponseOutputAudioTranscriptDelta)
    {
        Console.Write(serverEvent.ResponseOutputAudioTranscriptDelta?.Delta);
    }
    else if (serverEvent.IsResponseOutputAudioDone)
    {
        await playbackStream.FlushAsync(cancellationToken);
    }
    else if (serverEvent.IsError)
    {
        var error = serverEvent.Error?.Error;
        throw new InvalidOperationException($"{error?.Code}: {error?.Message}");
    }
}
```

Do not wait for `response.done` before starting playback; streaming each audio delta minimizes perceived latency.

## Tools

### Function Calling

Define a function with its JSON Schema parameters:

```csharp
using System.Text.Json;

using JsonDocument weatherSchema = JsonDocument.Parse(
    """
    {
      "type": "object",
      "properties": {
        "location": {
          "type": "string",
          "description": "City and country"
        }
      },
      "required": ["location"]
    }
    """);
JsonElement weatherParameters = weatherSchema.RootElement.Clone();

await client.SendSessionUpdateAsync(new SessionUpdatePayload
{
    Session = new SessionConfig
    {
        Voice = "eve",
        Modalities = ["text", "audio"],
        Tools =
        [
            new Tool
            {
                Type = "function",
                Name = "get_weather",
                Description = "Get the current weather for a location.",
                Parameters = weatherParameters,
            },
        ],
    },
}, cancellationToken);
```

Execute the function when its arguments are complete, then add a `function_call_output` item:

```csharp
if (serverEvent.IsResponseFunctionCallArgumentsDone)
{
    var functionCall = serverEvent.ResponseFunctionCallArgumentsDone!;
    string outputJson = await ExecuteToolAsync(
        functionCall.Name!,
        functionCall.Arguments!,
        cancellationToken);

    await client.SendConversationItemCreateAsync(new ConversationItemCreatePayload
    {
        Item = new ConversationItem
        {
            Type = "function_call_output",
            CallId = functionCall.CallId,
            Output = outputJson,
        },
    }, cancellationToken);

    // Wait for audio already buffered by the player to finish before requesting
    // the follow-up response, otherwise the two spoken turns can overlap.
    await WaitForPlaybackCompletionAsync(cancellationToken);
    await client.SendResponseCreateAsync(new ResponseCreatePayload(), cancellationToken);
}
```

### Built-in Search Tools

```csharp
Tools =
[
    new Tool { Type = "web_search" },
    new Tool
    {
        Type = "x_search",
        AllowedXHandles = ["grok", "xai"],
    },
    new Tool
    {
        Type = "file_search",
        VectorStoreIds = ["collection_abc123"],
        MaxNumResults = 5,
    },
];
```

The collection must already exist before it can be used by `file_search`.

## Reconnection

Enable automatic reconnects before starting the receive loop:

```csharp
client.ReconnectOptions.Enabled = true;
client.ReconnectOptions.MaxAttempts = 5;
client.ReconnectOptions.InitialDelay = TimeSpan.FromSeconds(1);
client.ReconnectOptions.MaxDelay = TimeSpan.FromSeconds(20);
client.ReconnectOptions.BackoffMultiplier = 2;
```

The client remembers the URI and connection options used by the successful `ConnectAsync` call. Subscribe to `Reconnecting`, `ExceptionOccurred`, and `Closed` when the application needs connection telemetry.

## Server Events

`ServerEvent` is a generated discriminated union. Check an `Is*` property before reading its matching payload.

| Property | Event type | Meaning |
|---|---|---|
| `IsSessionCreated` | `session.created` | Session opened; includes the selected model |
| `IsSessionUpdated` | `session.updated` | Session configuration accepted |
| `IsConversationCreated` | `conversation.created` | Conversation opened |
| `IsConversationItemAdded` | `conversation.item.added` | Item added to conversation history |
| `IsInputAudioBufferSpeechStarted` | `input_audio_buffer.speech_started` | VAD detected speech |
| `IsInputAudioBufferSpeechStopped` | `input_audio_buffer.speech_stopped` | VAD detected silence |
| `IsInputAudioBufferCommitted` | `input_audio_buffer.committed` | Buffered audio committed |
| `IsInputAudioTranscriptionCompleted` | `input_audio_transcription.completed` | User audio transcription completed |
| `IsResponseCreated` | `response.created` | Assistant response started |
| `IsResponseOutputItemAdded` | `response.output_item.added` | Output item added |
| `IsResponseOutputAudioTranscriptDelta` | `response.output_audio_transcript.delta` | Incremental assistant transcript |
| `IsResponseOutputAudioTranscriptDone` | `response.output_audio_transcript.done` | Assistant transcript completed |
| `IsResponseOutputAudioDelta` | `response.output_audio.delta` | Incremental base64 audio |
| `IsResponseOutputAudioDone` | `response.output_audio.done` | Assistant audio completed |
| `IsResponseFunctionCallArgumentsDone` | `response.function_call_arguments.done` | Function arguments completed |
| `IsMcpListToolsCompleted` | `mcp_list_tools.completed` | MCP tool discovery completed |
| `IsResponseMcpCallArgumentsDone` | `response.mcp_call_arguments.done` | MCP call arguments completed |
| `IsResponseMcpCallCompleted` | `response.mcp_call.completed` | MCP call succeeded |
| `IsResponseMcpCallFailed` | `response.mcp_call.failed` | MCP call failed |
| `IsResponseDone` | `response.done` | Assistant response completed |
| `IsError` | `error` | Service error received |

Unknown text messages raise the `UnknownMessage` event instead of being silently discarded.

## Lifetime and Cancellation

Pass a cancellation token to connection, send, and receive methods. Prefer `await using` so an open WebSocket receives a normal close frame before disposal:

```csharp
await using var client = new XaiRealtimeClient(apiKey);
```

Keep audio capture and WebSocket connection startup parallel in latency-sensitive applications, buffer early microphone samples, and flush them after `ConnectAsync` completes.
