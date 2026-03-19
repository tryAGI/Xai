# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [xAI (Grok)](https://x.ai/) API, auto-generated from a hand-curated OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Includes hand-written Realtime Voice Agent WebSocket client. Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Xai.slnx

# Build for release (also produces NuGet package)
dotnet build Xai.slnx -c Release

# Run integration tests (requires XAI_API_KEY env var)
dotnet test src/tests/IntegrationTests/Xai.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Xai && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `Generated/` is **auto-generated** -- do not manually edit files in `src/libs/Xai/Generated/`.

1. `src/libs/Xai/openapi.yaml` -- hand-curated OpenAPI spec from x.ai documentation
2. `src/libs/Xai/generate.sh` -- runs AutoSDK CLI to generate code to `Generated/`
3. CI auto-updates the spec and creates PRs if changes are detected

### Hand-Written Code

| Path | Purpose |
|------|---------|
| `Realtime/RealtimeVoiceClient.cs` | WebSocket client for `wss://api.x.ai/v1/realtime` |
| `Realtime/Events/` | Client and server event types for the Realtime API |
| `Realtime/Models/` | Session config, audio format, turn detection, tool definitions |
| `Realtime/RealtimeJsonSerializerContext.cs` | AOT-compatible JSON serialization for Realtime types |
| `Helpers/VideoGenerationPoller.cs` | Extension method to submit + poll video generation |
| `Helpers/DeferredCompletionPoller.cs` | Extension method to submit + poll deferred chat completions |

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Xai/` | Main SDK library (`XaiClient` + `RealtimeVoiceClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real xAI API |

### Sub-Clients

`XaiClient` exposes sub-clients for each API area:
- `Chat` -- Chat completions (with deferred support)
- `Responses` -- Responses API (create/get/delete)
- `Embeddings` -- Text embeddings
- `Images` -- Image generation and editing
- `Videos` -- Video generation (async with polling)
- `Audio` -- Text-to-speech
- `Models` -- Model listing (language, image, video, embedding)
- `Auth` -- API key info, realtime client secrets
- `Batches` -- Batch API (create, list, get, cancel, add requests, get results)
- `Files` -- File upload
- `Collections` -- Document search

### Realtime Voice Agent API

The `RealtimeVoiceClient` is a hand-written WebSocket client following the same pattern as `tryAGI.OpenAI.RealtimeConversationClient`. It supports:
- Bidirectional audio/text streaming
- Server VAD turn detection
- Function calling, web search, X search, file search tools
- MCP tool support
- 5 voice options: Eve, Ara, Rex, Sal, Leo
- Multiple audio formats: PCM (configurable sample rate), G.711 µ-law, G.711 A-law

### Build Configuration

- **Target:** `net10.0`
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### MEAI Integration

Not implemented in this SDK. The existing `CustomProviders.XAi()` in `tryAGI.OpenAI` provides full `IChatClient` and `IEmbeddingGenerator` support via the OpenAI-compatible API. This SDK covers the unique xAI endpoints (images, videos, realtime, responses, etc.).

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
