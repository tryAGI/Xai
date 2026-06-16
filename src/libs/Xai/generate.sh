#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (hand-curated OpenAPI + AsyncAPI)
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Xai \
  --clientClassName XaiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
autosdk generate asyncapi.json \
  --namespace Xai.Realtime \
  --targetFramework net10.0 \
  --output Generated \
  --websocket-class-name XaiRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext
autosdk generate asyncapi.tts.json \
  --namespace Xai.TextToSpeech \
  --targetFramework net10.0 \
  --output Generated \
  --websocket-class-name XaiTextToSpeechStreamingClient \
  --json-serializer-context TextToSpeechStreamingSourceGenerationContext
