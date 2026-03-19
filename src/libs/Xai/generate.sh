dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Xai \
  --clientClassName XaiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
