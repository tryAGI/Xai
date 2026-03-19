#nullable enable

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Xai;

/// <summary>
/// Source-generated JSON serializer context for Realtime Voice API types.
/// Enables AOT-compatible serialization.
/// </summary>
[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower)]
[JsonSerializable(typeof(RealtimeClientEvent))]
[JsonSerializable(typeof(RealtimeServerEvent))]
[JsonSerializable(typeof(RealtimeSessionConfig))]
[JsonSerializable(typeof(RealtimeTurnDetection))]
[JsonSerializable(typeof(RealtimeAudioConfig))]
[JsonSerializable(typeof(RealtimeAudioDirectionConfig))]
[JsonSerializable(typeof(RealtimeAudioFormatConfig))]
[JsonSerializable(typeof(RealtimeTool))]
[JsonSerializable(typeof(RealtimeConversationItem))]
[JsonSerializable(typeof(RealtimeContentPart))]
[JsonSerializable(typeof(RealtimeResponseConfig))]
[JsonSerializable(typeof(RealtimeSessionInfo))]
[JsonSerializable(typeof(RealtimeConversationInfo))]
[JsonSerializable(typeof(RealtimeResponseInfo))]
[JsonSerializable(typeof(RealtimeError))]
internal sealed partial class RealtimeJsonSerializerContext : JsonSerializerContext;
