#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (hand-curated OpenAPI + AsyncAPI)

dotnet tool install --global autosdk.cli --prerelease
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
