
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Xai.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.VoiceModel? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.VoiceReasoningEffort? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.SessionConfig? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.TurnDetection? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.AudioConfig? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResumptionConfig? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Xai.Realtime.Tool>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.Tool? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.AudioDirectionConfig? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.AudioFormatConfig? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.AudioTransport? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.AudioTranscriptionConfig? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ConversationItem? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Xai.Realtime.ContentPart>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ContentPart? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.SessionInfo? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ConversationInfo? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseInfo? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.RealtimeError? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseConfig? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.SessionUpdatePayload? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.SessionUpdatePayloadType? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ConversationItemCreatePayload? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ConversationItemCreatePayloadType? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferAppendPayload? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferAppendPayloadType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferCommitPayload? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferCommitPayloadType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseCreatePayload? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseCreatePayloadType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.SessionCreatedEvent? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.SessionCreatedEventType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.SessionUpdatedEvent? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.SessionUpdatedEventType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ConversationCreatedEvent? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ConversationCreatedEventType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ConversationItemAddedEvent? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ConversationItemAddedEventType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferSpeechStartedEvent? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferSpeechStartedEventType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferSpeechStoppedEventType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferCommittedEvent? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferCommittedEventType? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioTranscriptionCompletedEvent? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.InputAudioTranscriptionCompletedEventType? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseCreatedEvent? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseCreatedEventType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseDoneEvent? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseDoneEventType? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputItemAddedEvent? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputItemAddedEventType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEventType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEventType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioDeltaEvent? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioDeltaEventType? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioDoneEvent? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioDoneEventType? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEventType? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallArgumentsDoneEventType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallCompletedEvent? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallCompletedEventType? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallFailedEvent? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallFailedEventType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.McpListToolsCompletedEvent? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.McpListToolsCompletedEventType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ErrorEvent? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ErrorEventType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ServerEvent? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ServerEventDiscriminator? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.Realtime.ServerEventDiscriminatorType? Type81 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Xai.Realtime.Tool>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Xai.Realtime.ContentPart>? ListType2 { get; set; }
    }
}