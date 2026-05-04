
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Xai.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Xai.Realtime.JsonConverters.SessionUpdatePayloadTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.SessionUpdatePayloadTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ConversationItemCreatePayloadTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ConversationItemCreatePayloadTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferAppendPayloadTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferAppendPayloadTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferCommitPayloadTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferCommitPayloadTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseCreatePayloadTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseCreatePayloadTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.SessionCreatedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.SessionCreatedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.SessionUpdatedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.SessionUpdatedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ConversationCreatedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ConversationCreatedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ConversationItemAddedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ConversationItemAddedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferSpeechStartedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferSpeechStartedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferSpeechStoppedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferSpeechStoppedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferCommittedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioBufferCommittedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioTranscriptionCompletedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.InputAudioTranscriptionCompletedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseCreatedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseDoneEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseDoneEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputAudioTranscriptDeltaEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputAudioTranscriptDeltaEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputAudioTranscriptDoneEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputAudioTranscriptDoneEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputAudioDeltaEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputAudioDeltaEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputAudioDoneEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseOutputAudioDoneEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseMcpCallArgumentsDoneEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseMcpCallArgumentsDoneEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseMcpCallCompletedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseMcpCallCompletedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseMcpCallFailedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ResponseMcpCallFailedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.McpListToolsCompletedEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.McpListToolsCompletedEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ErrorEventTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ErrorEventTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Xai.Realtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.SessionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.TurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.AudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.Realtime.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.AudioDirectionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.AudioFormatConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ConversationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Xai.Realtime.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.SessionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ConversationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.RealtimeError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.SessionUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.SessionUpdatePayloadType), TypeInfoPropertyName = "SessionUpdatePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ConversationItemCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ConversationItemCreatePayloadType), TypeInfoPropertyName = "ConversationItemCreatePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferAppendPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferAppendPayloadType), TypeInfoPropertyName = "InputAudioBufferAppendPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferCommitPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferCommitPayloadType), TypeInfoPropertyName = "InputAudioBufferCommitPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseCreatePayloadType), TypeInfoPropertyName = "ResponseCreatePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.SessionCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.SessionCreatedEventType), TypeInfoPropertyName = "SessionCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.SessionUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.SessionUpdatedEventType), TypeInfoPropertyName = "SessionUpdatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ConversationCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ConversationCreatedEventType), TypeInfoPropertyName = "ConversationCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ConversationItemAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ConversationItemAddedEventType), TypeInfoPropertyName = "ConversationItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferSpeechStartedEventType), TypeInfoPropertyName = "InputAudioBufferSpeechStartedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferSpeechStoppedEventType), TypeInfoPropertyName = "InputAudioBufferSpeechStoppedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferCommittedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioBufferCommittedEventType), TypeInfoPropertyName = "InputAudioBufferCommittedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.InputAudioTranscriptionCompletedEventType), TypeInfoPropertyName = "InputAudioTranscriptionCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseCreatedEventType), TypeInfoPropertyName = "ResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseDoneEventType), TypeInfoPropertyName = "ResponseDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputItemAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputItemAddedEventType), TypeInfoPropertyName = "ResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEventType), TypeInfoPropertyName = "ResponseOutputAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEventType), TypeInfoPropertyName = "ResponseOutputAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputAudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputAudioDeltaEventType), TypeInfoPropertyName = "ResponseOutputAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseOutputAudioDoneEventType), TypeInfoPropertyName = "ResponseOutputAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEventType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEventType), TypeInfoPropertyName = "ResponseMcpCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseMcpCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseMcpCallCompletedEventType), TypeInfoPropertyName = "ResponseMcpCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseMcpCallFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ResponseMcpCallFailedEventType), TypeInfoPropertyName = "ResponseMcpCallFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.McpListToolsCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.McpListToolsCompletedEventType), TypeInfoPropertyName = "McpListToolsCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ErrorEventType), TypeInfoPropertyName = "ErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.Realtime.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.Realtime.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Xai.Realtime.ContentPart>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}