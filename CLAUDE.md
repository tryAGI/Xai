# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [xAI (Grok)](https://x.ai/) API, auto-generated from OpenAPI + AsyncAPI specifications using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

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

1. `src/libs/Xai/openapi.yaml` -- hand-curated OpenAPI spec for REST API (chat, images, videos, embeddings, etc.)
2. `src/libs/Xai/asyncapi.json` -- AsyncAPI 3.0 spec for Realtime Voice Agent WebSocket API
3. `src/libs/Xai/generate.sh` -- runs AutoSDK CLI twice (OpenAPI + AsyncAPI) to generate code to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

The AsyncAPI spec generates a `XaiRealtimeClient` WebSocket client in namespace `Xai.Realtime` with:
- Typed `Send*Async()` methods for each client event (SessionUpdate, ConversationItemCreate, InputAudioBufferAppend, InputAudioBufferCommit, ResponseCreate)
- `ReceiveUpdatesAsync()` returning a discriminated `ServerEvent` union with `Is*` properties for 21 server event types
- All model classes (SessionConfig, TurnDetection, AudioConfig, Tool, ConversationItem, etc.)
- AOT-compatible `RealtimeSourceGenerationContext` for JSON serialization

### Hand-Written Code

| Path | Purpose |
|------|---------|
| `Helpers/VideoGenerationPoller.cs` | Extension method to submit + poll video generation |
| `Helpers/DeferredCompletionPoller.cs` | Extension method to submit + poll deferred chat completions |

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Xai/` | Main SDK library (`XaiClient` + `XaiRealtimeClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real xAI API |
| `src/tests/IntegrationTests/Examples/` | **Primary test location** — JSDoc-annotated tests that double as `autosdk docs sync` source |

### Documentation Generation

Tests in `Examples/` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`

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

The `XaiRealtimeClient` (in `Xai.Realtime` namespace) is auto-generated from `asyncapi.json`. It supports:
- Bidirectional audio/text streaming via `wss://api.x.ai/v1/realtime`
- Typed send methods: `SendSessionUpdateAsync`, `SendConversationItemCreateAsync`, `SendInputAudioBufferAppendAsync`, `SendInputAudioBufferCommitAsync`, `SendResponseCreateAsync`
- Discriminated `ServerEvent` union for receive with `Is*` properties (21 event types)
- Server VAD turn detection, function calling, MCP tool support
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
