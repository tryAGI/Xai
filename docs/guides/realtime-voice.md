# Realtime Speech-to-Speech

`XaiRealtimeClient` is the SDK's WebSocket client for the xAI Speech-to-Speech API at `wss://api.x.ai/v1/realtime`. It supports bidirectional audio and text, server-side voice activity detection (VAD), function calling, built-in search tools, reconnects, and typed Grok Voice model selection.

See the [xAI Speech-to-Speech guide](https://docs.x.ai/developers/model-capabilities/audio/speech-to-speech) and [Voice API reference](https://docs.x.ai/developers/rest-api-reference/inference/voice) for service behavior and limits.

## Quick Start

```csharp
using Xai.Realtime;

--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:quick-start"
```

## Authentication

Use the API-key constructor in server-side applications:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:api-key-authentication"
```

For a short-lived client secret, create the client without an API key and pass the token using the WebSocket subprotocol expected by xAI:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:client-secret-authentication"
```

Do not expose a long-lived xAI API key in a browser or mobile client.

## Models and Reasoning

The model and reasoning effort are selected during the WebSocket handshake:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:model-selection"
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

### Audio, Transcription, Resumption, and Pronunciation

```csharp
--8<-- "src/tests/IntegrationTests/Tests.VoiceModels.cs:typed-session-configuration"

await client.SendSessionUpdateAsync(sessionUpdate, cancellationToken);
```

`AudioTransport.Json` carries base64 audio in JSON events. `AudioTransport.Binary` selects binary WebSocket frames; use the raw byte `SendAsync` overload for binary input, and keep output on JSON when consuming `ReceiveUpdatesAsync`. Input transcription accepts a BCP-47 language hint and up to 100 key terms. Output speed ranges from `0.7` to `1.5`. Pronunciation replacements are case-insensitive and apply to whole words.

Set `Resumption.Enabled` before starting a resumable conversation. To resume it after a disconnect, reconnect with the conversation ID as the `conversation_id` query parameter and enable resumption in the new session as well.

### Audio Formats

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
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:server-vad"
```

Higher thresholds require louder input before speech starts. Increase `SilenceDurationMs` when callers need longer pauses without ending their turn. `IdleTimeoutMs` lets the agent check whether an inactive caller is still present.

### Manual Turn Control

Manual mode requires an explicit JSON `null` for `turn_detection`. `UseManualTurnDetection()` emits that null while preserving typed session configuration:

```csharp
--8<-- "src/tests/IntegrationTests/Tests.VoiceModels.cs:manual-turn-detection"

await client.SendSessionUpdateAsync(sessionUpdate, cancellationToken);
```

In manual mode, append audio, commit it, and request a response yourself. Call `UseServerTurnDetection(...)` to switch the same configuration back to server VAD without emitting duplicate JSON properties.

## Sending Audio

The byte overload accepts raw audio and handles base64 encoding for `input_audio_buffer.append`:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:send-audio"
```

Send chunks continuously while the caller is speaking. Approximately 100 ms per chunk is a practical starting point.

When using manual turn detection, finish the turn explicitly:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:commit-manual-turn"
```

## Receiving Audio and Transcripts

Audio deltas are base64 strings. Decode and enqueue each chunk for playback as soon as it arrives:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:receive-audio"
```

Do not wait for `response.done` before starting playback; streaming each audio delta minimizes perceived latency.

## Tools

### Function Calling

Define a function with its JSON Schema parameters:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:json-using"

--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:configure-function-tool"
```

Execute the function when its arguments are complete, then add a `function_call_output` item:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:handle-function-tool"
```

### Built-in Search Tools

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:built-in-search-tools"
```

The collection must already exist before it can be used by `file_search`.

## Reconnection

Enable automatic reconnects before starting the receive loop:

```csharp
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:configure-reconnects"
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
--8<-- "src/tests/IntegrationTests/RealtimeVoiceGuideSnippets.cs:client-lifetime"
```

Keep audio capture and WebSocket connection startup parallel in latency-sensitive applications, buffer early microphone samples, and flush them after `ConnectAsync` completes.
