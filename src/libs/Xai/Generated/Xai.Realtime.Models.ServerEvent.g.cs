#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Session has been created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.SessionCreatedEvent? SessionCreated { get; init; }
#else
        public global::Xai.Realtime.SessionCreatedEvent? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.SessionCreatedEvent? value)
        {
            value = SessionCreated;
            return IsSessionCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.SessionCreatedEvent PickSessionCreated() => IsSessionCreated
            ? SessionCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCreated' but the value was {ToString()}.");

        /// <summary>
        /// Session configuration has been updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.SessionUpdatedEvent? SessionUpdated { get; init; }
#else
        public global::Xai.Realtime.SessionUpdatedEvent? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.SessionUpdatedEvent? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.SessionUpdatedEvent PickSessionUpdated() => IsSessionUpdated
            ? SessionUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

        /// <summary>
        /// A new conversation has been created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ConversationCreatedEvent? ConversationCreated { get; init; }
#else
        public global::Xai.Realtime.ConversationCreatedEvent? ConversationCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationCreated))]
#endif
        public bool IsConversationCreated => ConversationCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConversationCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ConversationCreatedEvent? value)
        {
            value = ConversationCreated;
            return IsConversationCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ConversationCreatedEvent PickConversationCreated() => IsConversationCreated
            ? ConversationCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationCreated' but the value was {ToString()}.");

        /// <summary>
        /// A conversation item has been added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ConversationItemAddedEvent? ConversationItemAdded { get; init; }
#else
        public global::Xai.Realtime.ConversationItemAddedEvent? ConversationItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemAdded))]
#endif
        public bool IsConversationItemAdded => ConversationItemAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConversationItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ConversationItemAddedEvent? value)
        {
            value = ConversationItemAdded;
            return IsConversationItemAdded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ConversationItemAddedEvent PickConversationItemAdded() => IsConversationItemAdded
            ? ConversationItemAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemAdded' but the value was {ToString()}.");

        /// <summary>
        /// Speech detected in audio input (VAD).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.InputAudioBufferSpeechStartedEvent? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::Xai.Realtime.InputAudioBufferSpeechStartedEvent? InputAudioBufferSpeechStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStarted))]
#endif
        public bool IsInputAudioBufferSpeechStarted => InputAudioBufferSpeechStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferSpeechStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.InputAudioBufferSpeechStartedEvent? value)
        {
            value = InputAudioBufferSpeechStarted;
            return IsInputAudioBufferSpeechStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferSpeechStartedEvent PickInputAudioBufferSpeechStarted() => IsInputAudioBufferSpeechStarted
            ? InputAudioBufferSpeechStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferSpeechStarted' but the value was {ToString()}.");

        /// <summary>
        /// Speech has stopped in audio input (VAD).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent? InputAudioBufferSpeechStopped { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStopped))]
#endif
        public bool IsInputAudioBufferSpeechStopped => InputAudioBufferSpeechStopped != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferSpeechStopped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent? value)
        {
            value = InputAudioBufferSpeechStopped;
            return IsInputAudioBufferSpeechStopped;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent PickInputAudioBufferSpeechStopped() => IsInputAudioBufferSpeechStopped
            ? InputAudioBufferSpeechStopped!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferSpeechStopped' but the value was {ToString()}.");

        /// <summary>
        /// Audio buffer has been committed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.InputAudioBufferCommittedEvent? InputAudioBufferCommitted { get; init; }
#else
        public global::Xai.Realtime.InputAudioBufferCommittedEvent? InputAudioBufferCommitted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommitted))]
#endif
        public bool IsInputAudioBufferCommitted => InputAudioBufferCommitted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferCommitted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.InputAudioBufferCommittedEvent? value)
        {
            value = InputAudioBufferCommitted;
            return IsInputAudioBufferCommitted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.InputAudioBufferCommittedEvent PickInputAudioBufferCommitted() => IsInputAudioBufferCommitted
            ? InputAudioBufferCommitted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferCommitted' but the value was {ToString()}.");

        /// <summary>
        /// Audio transcription has been completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.InputAudioTranscriptionCompletedEvent? InputAudioTranscriptionCompleted { get; init; }
#else
        public global::Xai.Realtime.InputAudioTranscriptionCompletedEvent? InputAudioTranscriptionCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioTranscriptionCompleted))]
#endif
        public bool IsInputAudioTranscriptionCompleted => InputAudioTranscriptionCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputAudioTranscriptionCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.InputAudioTranscriptionCompletedEvent? value)
        {
            value = InputAudioTranscriptionCompleted;
            return IsInputAudioTranscriptionCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.InputAudioTranscriptionCompletedEvent PickInputAudioTranscriptionCompleted() => IsInputAudioTranscriptionCompleted
            ? InputAudioTranscriptionCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioTranscriptionCompleted' but the value was {ToString()}.");

        /// <summary>
        /// A response has been created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseCreatedEvent? ResponseCreated { get; init; }
#else
        public global::Xai.Realtime.ResponseCreatedEvent? ResponseCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseCreatedEvent? value)
        {
            value = ResponseCreated;
            return IsResponseCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseCreatedEvent PickResponseCreated() => IsResponseCreated
            ? ResponseCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreated' but the value was {ToString()}.");

        /// <summary>
        /// A response has completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseDoneEvent? ResponseDone { get; init; }
#else
        public global::Xai.Realtime.ResponseDoneEvent? ResponseDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseDone))]
#endif
        public bool IsResponseDone => ResponseDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseDoneEvent? value)
        {
            value = ResponseDone;
            return IsResponseDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseDoneEvent PickResponseDone() => IsResponseDone
            ? ResponseDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseDone' but the value was {ToString()}.");

        /// <summary>
        /// An output item has been added to the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; init; }
#else
        public global::Xai.Realtime.ResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseOutputItemAddedEvent? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseOutputItemAddedEvent PickResponseOutputItemAdded() => IsResponseOutputItemAdded
            ? ResponseOutputItemAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemAdded' but the value was {ToString()}.");

        /// <summary>
        /// Incremental audio transcript text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent? ResponseOutputAudioTranscriptDelta { get; init; }
#else
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent? ResponseOutputAudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioTranscriptDelta))]
#endif
        public bool IsResponseOutputAudioTranscriptDelta => ResponseOutputAudioTranscriptDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputAudioTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent? value)
        {
            value = ResponseOutputAudioTranscriptDelta;
            return IsResponseOutputAudioTranscriptDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent PickResponseOutputAudioTranscriptDelta() => IsResponseOutputAudioTranscriptDelta
            ? ResponseOutputAudioTranscriptDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioTranscriptDelta' but the value was {ToString()}.");

        /// <summary>
        /// Audio transcript completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent? ResponseOutputAudioTranscriptDone { get; init; }
#else
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent? ResponseOutputAudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioTranscriptDone))]
#endif
        public bool IsResponseOutputAudioTranscriptDone => ResponseOutputAudioTranscriptDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputAudioTranscriptDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent? value)
        {
            value = ResponseOutputAudioTranscriptDone;
            return IsResponseOutputAudioTranscriptDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent PickResponseOutputAudioTranscriptDone() => IsResponseOutputAudioTranscriptDone
            ? ResponseOutputAudioTranscriptDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioTranscriptDone' but the value was {ToString()}.");

        /// <summary>
        /// Incremental audio data (base64).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseOutputAudioDeltaEvent? ResponseOutputAudioDelta { get; init; }
#else
        public global::Xai.Realtime.ResponseOutputAudioDeltaEvent? ResponseOutputAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioDelta))]
#endif
        public bool IsResponseOutputAudioDelta => ResponseOutputAudioDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseOutputAudioDeltaEvent? value)
        {
            value = ResponseOutputAudioDelta;
            return IsResponseOutputAudioDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioDeltaEvent PickResponseOutputAudioDelta() => IsResponseOutputAudioDelta
            ? ResponseOutputAudioDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioDelta' but the value was {ToString()}.");

        /// <summary>
        /// Audio output completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseOutputAudioDoneEvent? ResponseOutputAudioDone { get; init; }
#else
        public global::Xai.Realtime.ResponseOutputAudioDoneEvent? ResponseOutputAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioDone))]
#endif
        public bool IsResponseOutputAudioDone => ResponseOutputAudioDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseOutputAudioDoneEvent? value)
        {
            value = ResponseOutputAudioDone;
            return IsResponseOutputAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseOutputAudioDoneEvent PickResponseOutputAudioDone() => IsResponseOutputAudioDone
            ? ResponseOutputAudioDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioDone' but the value was {ToString()}.");

        /// <summary>
        /// Function call arguments completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent PickResponseFunctionCallArgumentsDone() => IsResponseFunctionCallArgumentsDone
            ? ResponseFunctionCallArgumentsDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDone' but the value was {ToString()}.");

        /// <summary>
        /// MCP tool call arguments completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; init; }
#else
        public global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsDone))]
#endif
        public bool IsResponseMcpCallArgumentsDone => ResponseMcpCallArgumentsDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseMcpCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent? value)
        {
            value = ResponseMcpCallArgumentsDone;
            return IsResponseMcpCallArgumentsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent PickResponseMcpCallArgumentsDone() => IsResponseMcpCallArgumentsDone
            ? ResponseMcpCallArgumentsDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsDone' but the value was {ToString()}.");

        /// <summary>
        /// MCP tool call completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseMcpCallCompletedEvent? ResponseMcpCallCompleted { get; init; }
#else
        public global::Xai.Realtime.ResponseMcpCallCompletedEvent? ResponseMcpCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallCompleted))]
#endif
        public bool IsResponseMcpCallCompleted => ResponseMcpCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseMcpCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseMcpCallCompletedEvent? value)
        {
            value = ResponseMcpCallCompleted;
            return IsResponseMcpCallCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallCompletedEvent PickResponseMcpCallCompleted() => IsResponseMcpCallCompleted
            ? ResponseMcpCallCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// MCP tool call failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ResponseMcpCallFailedEvent? ResponseMcpCallFailed { get; init; }
#else
        public global::Xai.Realtime.ResponseMcpCallFailedEvent? ResponseMcpCallFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallFailed))]
#endif
        public bool IsResponseMcpCallFailed => ResponseMcpCallFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseMcpCallFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ResponseMcpCallFailedEvent? value)
        {
            value = ResponseMcpCallFailed;
            return IsResponseMcpCallFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ResponseMcpCallFailedEvent PickResponseMcpCallFailed() => IsResponseMcpCallFailed
            ? ResponseMcpCallFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallFailed' but the value was {ToString()}.");

        /// <summary>
        /// MCP tool list retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.McpListToolsCompletedEvent? McpListToolsCompleted { get; init; }
#else
        public global::Xai.Realtime.McpListToolsCompletedEvent? McpListToolsCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListToolsCompleted))]
#endif
        public bool IsMcpListToolsCompleted => McpListToolsCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpListToolsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.McpListToolsCompletedEvent? value)
        {
            value = McpListToolsCompleted;
            return IsMcpListToolsCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.McpListToolsCompletedEvent PickMcpListToolsCompleted() => IsMcpListToolsCompleted
            ? McpListToolsCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpListToolsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// An error occurred.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.Realtime.ErrorEvent? Error { get; init; }
#else
        public global::Xai.Realtime.ErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.Realtime.ErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Xai.Realtime.ErrorEvent PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.SessionCreatedEvent value) => new ServerEvent((global::Xai.Realtime.SessionCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.SessionCreatedEvent?(ServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.SessionCreatedEvent? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromSessionCreated(global::Xai.Realtime.SessionCreatedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.SessionUpdatedEvent value) => new ServerEvent((global::Xai.Realtime.SessionUpdatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.SessionUpdatedEvent?(ServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.SessionUpdatedEvent? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromSessionUpdated(global::Xai.Realtime.SessionUpdatedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ConversationCreatedEvent value) => new ServerEvent((global::Xai.Realtime.ConversationCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ConversationCreatedEvent?(ServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ConversationCreatedEvent? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationCreated(global::Xai.Realtime.ConversationCreatedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ConversationItemAddedEvent value) => new ServerEvent((global::Xai.Realtime.ConversationItemAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ConversationItemAddedEvent?(ServerEvent @this) => @this.ConversationItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ConversationItemAddedEvent? value)
        {
            ConversationItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemAdded(global::Xai.Realtime.ConversationItemAddedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent value) => new ServerEvent((global::Xai.Realtime.InputAudioBufferSpeechStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.InputAudioBufferSpeechStartedEvent?(ServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferSpeechStarted(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent value) => new ServerEvent((global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent?(ServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferSpeechStopped(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.InputAudioBufferCommittedEvent value) => new ServerEvent((global::Xai.Realtime.InputAudioBufferCommittedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.InputAudioBufferCommittedEvent?(ServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.InputAudioBufferCommittedEvent? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferCommitted(global::Xai.Realtime.InputAudioBufferCommittedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent value) => new ServerEvent((global::Xai.Realtime.InputAudioTranscriptionCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.InputAudioTranscriptionCompletedEvent?(ServerEvent @this) => @this.InputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent? value)
        {
            InputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioTranscriptionCompleted(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseCreatedEvent value) => new ServerEvent((global::Xai.Realtime.ResponseCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseCreatedEvent?(ServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseCreatedEvent? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseCreated(global::Xai.Realtime.ResponseCreatedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseDoneEvent value) => new ServerEvent((global::Xai.Realtime.ResponseDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseDoneEvent?(ServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseDoneEvent? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseDone(global::Xai.Realtime.ResponseDoneEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseOutputItemAddedEvent value) => new ServerEvent((global::Xai.Realtime.ResponseOutputItemAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseOutputItemAddedEvent?(ServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseOutputItemAddedEvent? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputItemAdded(global::Xai.Realtime.ResponseOutputItemAddedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent value) => new ServerEvent((global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent?(ServerEvent @this) => @this.ResponseOutputAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent? value)
        {
            ResponseOutputAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputAudioTranscriptDelta(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent value) => new ServerEvent((global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent?(ServerEvent @this) => @this.ResponseOutputAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent? value)
        {
            ResponseOutputAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputAudioTranscriptDone(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseOutputAudioDeltaEvent value) => new ServerEvent((global::Xai.Realtime.ResponseOutputAudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseOutputAudioDeltaEvent?(ServerEvent @this) => @this.ResponseOutputAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseOutputAudioDeltaEvent? value)
        {
            ResponseOutputAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputAudioDelta(global::Xai.Realtime.ResponseOutputAudioDeltaEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseOutputAudioDoneEvent value) => new ServerEvent((global::Xai.Realtime.ResponseOutputAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseOutputAudioDoneEvent?(ServerEvent @this) => @this.ResponseOutputAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseOutputAudioDoneEvent? value)
        {
            ResponseOutputAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputAudioDone(global::Xai.Realtime.ResponseOutputAudioDoneEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent value) => new ServerEvent((global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent?(ServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseFunctionCallArgumentsDone(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent value) => new ServerEvent((global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent?(ServerEvent @this) => @this.ResponseMcpCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent? value)
        {
            ResponseMcpCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseMcpCallArgumentsDone(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseMcpCallCompletedEvent value) => new ServerEvent((global::Xai.Realtime.ResponseMcpCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseMcpCallCompletedEvent?(ServerEvent @this) => @this.ResponseMcpCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseMcpCallCompletedEvent? value)
        {
            ResponseMcpCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseMcpCallCompleted(global::Xai.Realtime.ResponseMcpCallCompletedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ResponseMcpCallFailedEvent value) => new ServerEvent((global::Xai.Realtime.ResponseMcpCallFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ResponseMcpCallFailedEvent?(ServerEvent @this) => @this.ResponseMcpCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ResponseMcpCallFailedEvent? value)
        {
            ResponseMcpCallFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseMcpCallFailed(global::Xai.Realtime.ResponseMcpCallFailedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.McpListToolsCompletedEvent value) => new ServerEvent((global::Xai.Realtime.McpListToolsCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.McpListToolsCompletedEvent?(ServerEvent @this) => @this.McpListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.McpListToolsCompletedEvent? value)
        {
            McpListToolsCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromMcpListToolsCompleted(global::Xai.Realtime.McpListToolsCompletedEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.Realtime.ErrorEvent value) => new ServerEvent((global::Xai.Realtime.ErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.Realtime.ErrorEvent?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.Realtime.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromError(global::Xai.Realtime.ErrorEvent? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::Xai.Realtime.ServerEventDiscriminatorType? type,
            global::Xai.Realtime.SessionCreatedEvent? sessionCreated,
            global::Xai.Realtime.SessionUpdatedEvent? sessionUpdated,
            global::Xai.Realtime.ConversationCreatedEvent? conversationCreated,
            global::Xai.Realtime.ConversationItemAddedEvent? conversationItemAdded,
            global::Xai.Realtime.InputAudioBufferSpeechStartedEvent? inputAudioBufferSpeechStarted,
            global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent? inputAudioBufferSpeechStopped,
            global::Xai.Realtime.InputAudioBufferCommittedEvent? inputAudioBufferCommitted,
            global::Xai.Realtime.InputAudioTranscriptionCompletedEvent? inputAudioTranscriptionCompleted,
            global::Xai.Realtime.ResponseCreatedEvent? responseCreated,
            global::Xai.Realtime.ResponseDoneEvent? responseDone,
            global::Xai.Realtime.ResponseOutputItemAddedEvent? responseOutputItemAdded,
            global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent? responseOutputAudioTranscriptDelta,
            global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent? responseOutputAudioTranscriptDone,
            global::Xai.Realtime.ResponseOutputAudioDeltaEvent? responseOutputAudioDelta,
            global::Xai.Realtime.ResponseOutputAudioDoneEvent? responseOutputAudioDone,
            global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone,
            global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent? responseMcpCallArgumentsDone,
            global::Xai.Realtime.ResponseMcpCallCompletedEvent? responseMcpCallCompleted,
            global::Xai.Realtime.ResponseMcpCallFailedEvent? responseMcpCallFailed,
            global::Xai.Realtime.McpListToolsCompletedEvent? mcpListToolsCompleted,
            global::Xai.Realtime.ErrorEvent? error
            )
        {
            Type = type;

            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            ConversationCreated = conversationCreated;
            ConversationItemAdded = conversationItemAdded;
            InputAudioBufferSpeechStarted = inputAudioBufferSpeechStarted;
            InputAudioBufferSpeechStopped = inputAudioBufferSpeechStopped;
            InputAudioBufferCommitted = inputAudioBufferCommitted;
            InputAudioTranscriptionCompleted = inputAudioTranscriptionCompleted;
            ResponseCreated = responseCreated;
            ResponseDone = responseDone;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputAudioTranscriptDelta = responseOutputAudioTranscriptDelta;
            ResponseOutputAudioTranscriptDone = responseOutputAudioTranscriptDone;
            ResponseOutputAudioDelta = responseOutputAudioDelta;
            ResponseOutputAudioDone = responseOutputAudioDone;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseMcpCallArgumentsDone = responseMcpCallArgumentsDone;
            ResponseMcpCallCompleted = responseMcpCallCompleted;
            ResponseMcpCallFailed = responseMcpCallFailed;
            McpListToolsCompleted = mcpListToolsCompleted;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            McpListToolsCompleted as object ??
            ResponseMcpCallFailed as object ??
            ResponseMcpCallCompleted as object ??
            ResponseMcpCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseOutputAudioDone as object ??
            ResponseOutputAudioDelta as object ??
            ResponseOutputAudioTranscriptDone as object ??
            ResponseOutputAudioTranscriptDelta as object ??
            ResponseOutputItemAdded as object ??
            ResponseDone as object ??
            ResponseCreated as object ??
            InputAudioTranscriptionCompleted as object ??
            InputAudioBufferCommitted as object ??
            InputAudioBufferSpeechStopped as object ??
            InputAudioBufferSpeechStarted as object ??
            ConversationItemAdded as object ??
            ConversationCreated as object ??
            SessionUpdated as object ??
            SessionCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            ConversationCreated?.ToString() ??
            ConversationItemAdded?.ToString() ??
            InputAudioBufferSpeechStarted?.ToString() ??
            InputAudioBufferSpeechStopped?.ToString() ??
            InputAudioBufferCommitted?.ToString() ??
            InputAudioTranscriptionCompleted?.ToString() ??
            ResponseCreated?.ToString() ??
            ResponseDone?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputAudioTranscriptDelta?.ToString() ??
            ResponseOutputAudioTranscriptDone?.ToString() ??
            ResponseOutputAudioDelta?.ToString() ??
            ResponseOutputAudioDone?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseMcpCallArgumentsDone?.ToString() ??
            ResponseMcpCallCompleted?.ToString() ??
            ResponseMcpCallFailed?.ToString() ??
            McpListToolsCompleted?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Xai.Realtime.SessionCreatedEvent, TResult>? sessionCreated = null,
            global::System.Func<global::Xai.Realtime.SessionUpdatedEvent, TResult>? sessionUpdated = null,
            global::System.Func<global::Xai.Realtime.ConversationCreatedEvent, TResult>? conversationCreated = null,
            global::System.Func<global::Xai.Realtime.ConversationItemAddedEvent, TResult>? conversationItemAdded = null,
            global::System.Func<global::Xai.Realtime.InputAudioBufferSpeechStartedEvent, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::Xai.Realtime.InputAudioBufferCommittedEvent, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::Xai.Realtime.InputAudioTranscriptionCompletedEvent, TResult>? inputAudioTranscriptionCompleted = null,
            global::System.Func<global::Xai.Realtime.ResponseCreatedEvent, TResult>? responseCreated = null,
            global::System.Func<global::Xai.Realtime.ResponseDoneEvent, TResult>? responseDone = null,
            global::System.Func<global::Xai.Realtime.ResponseOutputItemAddedEvent, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent, TResult>? responseOutputAudioTranscriptDelta = null,
            global::System.Func<global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent, TResult>? responseOutputAudioTranscriptDone = null,
            global::System.Func<global::Xai.Realtime.ResponseOutputAudioDeltaEvent, TResult>? responseOutputAudioDelta = null,
            global::System.Func<global::Xai.Realtime.ResponseOutputAudioDoneEvent, TResult>? responseOutputAudioDone = null,
            global::System.Func<global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::Xai.Realtime.ResponseMcpCallCompletedEvent, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::Xai.Realtime.ResponseMcpCallFailedEvent, TResult>? responseMcpCallFailed = null,
            global::System.Func<global::Xai.Realtime.McpListToolsCompletedEvent, TResult>? mcpListToolsCompleted = null,
            global::System.Func<global::Xai.Realtime.ErrorEvent, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsConversationCreated && conversationCreated != null)
            {
                return conversationCreated(ConversationCreated!);
            }
            else if (IsConversationItemAdded && conversationItemAdded != null)
            {
                return conversationItemAdded(ConversationItemAdded!);
            }
            else if (IsInputAudioBufferSpeechStarted && inputAudioBufferSpeechStarted != null)
            {
                return inputAudioBufferSpeechStarted(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped && inputAudioBufferSpeechStopped != null)
            {
                return inputAudioBufferSpeechStopped(InputAudioBufferSpeechStopped!);
            }
            else if (IsInputAudioBufferCommitted && inputAudioBufferCommitted != null)
            {
                return inputAudioBufferCommitted(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioTranscriptionCompleted && inputAudioTranscriptionCompleted != null)
            {
                return inputAudioTranscriptionCompleted(InputAudioTranscriptionCompleted!);
            }
            else if (IsResponseCreated && responseCreated != null)
            {
                return responseCreated(ResponseCreated!);
            }
            else if (IsResponseDone && responseDone != null)
            {
                return responseDone(ResponseDone!);
            }
            else if (IsResponseOutputItemAdded && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputAudioTranscriptDelta && responseOutputAudioTranscriptDelta != null)
            {
                return responseOutputAudioTranscriptDelta(ResponseOutputAudioTranscriptDelta!);
            }
            else if (IsResponseOutputAudioTranscriptDone && responseOutputAudioTranscriptDone != null)
            {
                return responseOutputAudioTranscriptDone(ResponseOutputAudioTranscriptDone!);
            }
            else if (IsResponseOutputAudioDelta && responseOutputAudioDelta != null)
            {
                return responseOutputAudioDelta(ResponseOutputAudioDelta!);
            }
            else if (IsResponseOutputAudioDone && responseOutputAudioDone != null)
            {
                return responseOutputAudioDone(ResponseOutputAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseMcpCallArgumentsDone && responseMcpCallArgumentsDone != null)
            {
                return responseMcpCallArgumentsDone(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallCompleted && responseMcpCallCompleted != null)
            {
                return responseMcpCallCompleted(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed && responseMcpCallFailed != null)
            {
                return responseMcpCallFailed(ResponseMcpCallFailed!);
            }
            else if (IsMcpListToolsCompleted && mcpListToolsCompleted != null)
            {
                return mcpListToolsCompleted(McpListToolsCompleted!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Xai.Realtime.SessionCreatedEvent>? sessionCreated = null,

            global::System.Action<global::Xai.Realtime.SessionUpdatedEvent>? sessionUpdated = null,

            global::System.Action<global::Xai.Realtime.ConversationCreatedEvent>? conversationCreated = null,

            global::System.Action<global::Xai.Realtime.ConversationItemAddedEvent>? conversationItemAdded = null,

            global::System.Action<global::Xai.Realtime.InputAudioBufferSpeechStartedEvent>? inputAudioBufferSpeechStarted = null,

            global::System.Action<global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent>? inputAudioBufferSpeechStopped = null,

            global::System.Action<global::Xai.Realtime.InputAudioBufferCommittedEvent>? inputAudioBufferCommitted = null,

            global::System.Action<global::Xai.Realtime.InputAudioTranscriptionCompletedEvent>? inputAudioTranscriptionCompleted = null,

            global::System.Action<global::Xai.Realtime.ResponseCreatedEvent>? responseCreated = null,

            global::System.Action<global::Xai.Realtime.ResponseDoneEvent>? responseDone = null,

            global::System.Action<global::Xai.Realtime.ResponseOutputItemAddedEvent>? responseOutputItemAdded = null,

            global::System.Action<global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent>? responseOutputAudioTranscriptDelta = null,

            global::System.Action<global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent>? responseOutputAudioTranscriptDone = null,

            global::System.Action<global::Xai.Realtime.ResponseOutputAudioDeltaEvent>? responseOutputAudioDelta = null,

            global::System.Action<global::Xai.Realtime.ResponseOutputAudioDoneEvent>? responseOutputAudioDone = null,

            global::System.Action<global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent>? responseMcpCallArgumentsDone = null,

            global::System.Action<global::Xai.Realtime.ResponseMcpCallCompletedEvent>? responseMcpCallCompleted = null,

            global::System.Action<global::Xai.Realtime.ResponseMcpCallFailedEvent>? responseMcpCallFailed = null,

            global::System.Action<global::Xai.Realtime.McpListToolsCompletedEvent>? mcpListToolsCompleted = null,

            global::System.Action<global::Xai.Realtime.ErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsConversationCreated)
            {
                conversationCreated?.Invoke(ConversationCreated!);
            }
            else if (IsConversationItemAdded)
            {
                conversationItemAdded?.Invoke(ConversationItemAdded!);
            }
            else if (IsInputAudioBufferSpeechStarted)
            {
                inputAudioBufferSpeechStarted?.Invoke(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped)
            {
                inputAudioBufferSpeechStopped?.Invoke(InputAudioBufferSpeechStopped!);
            }
            else if (IsInputAudioBufferCommitted)
            {
                inputAudioBufferCommitted?.Invoke(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioTranscriptionCompleted)
            {
                inputAudioTranscriptionCompleted?.Invoke(InputAudioTranscriptionCompleted!);
            }
            else if (IsResponseCreated)
            {
                responseCreated?.Invoke(ResponseCreated!);
            }
            else if (IsResponseDone)
            {
                responseDone?.Invoke(ResponseDone!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputAudioTranscriptDelta)
            {
                responseOutputAudioTranscriptDelta?.Invoke(ResponseOutputAudioTranscriptDelta!);
            }
            else if (IsResponseOutputAudioTranscriptDone)
            {
                responseOutputAudioTranscriptDone?.Invoke(ResponseOutputAudioTranscriptDone!);
            }
            else if (IsResponseOutputAudioDelta)
            {
                responseOutputAudioDelta?.Invoke(ResponseOutputAudioDelta!);
            }
            else if (IsResponseOutputAudioDone)
            {
                responseOutputAudioDone?.Invoke(ResponseOutputAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseMcpCallArgumentsDone)
            {
                responseMcpCallArgumentsDone?.Invoke(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallCompleted)
            {
                responseMcpCallCompleted?.Invoke(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed)
            {
                responseMcpCallFailed?.Invoke(ResponseMcpCallFailed!);
            }
            else if (IsMcpListToolsCompleted)
            {
                mcpListToolsCompleted?.Invoke(McpListToolsCompleted!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Xai.Realtime.SessionCreatedEvent>? sessionCreated = null,
            global::System.Action<global::Xai.Realtime.SessionUpdatedEvent>? sessionUpdated = null,
            global::System.Action<global::Xai.Realtime.ConversationCreatedEvent>? conversationCreated = null,
            global::System.Action<global::Xai.Realtime.ConversationItemAddedEvent>? conversationItemAdded = null,
            global::System.Action<global::Xai.Realtime.InputAudioBufferSpeechStartedEvent>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::Xai.Realtime.InputAudioBufferCommittedEvent>? inputAudioBufferCommitted = null,
            global::System.Action<global::Xai.Realtime.InputAudioTranscriptionCompletedEvent>? inputAudioTranscriptionCompleted = null,
            global::System.Action<global::Xai.Realtime.ResponseCreatedEvent>? responseCreated = null,
            global::System.Action<global::Xai.Realtime.ResponseDoneEvent>? responseDone = null,
            global::System.Action<global::Xai.Realtime.ResponseOutputItemAddedEvent>? responseOutputItemAdded = null,
            global::System.Action<global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent>? responseOutputAudioTranscriptDelta = null,
            global::System.Action<global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent>? responseOutputAudioTranscriptDone = null,
            global::System.Action<global::Xai.Realtime.ResponseOutputAudioDeltaEvent>? responseOutputAudioDelta = null,
            global::System.Action<global::Xai.Realtime.ResponseOutputAudioDoneEvent>? responseOutputAudioDone = null,
            global::System.Action<global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::Xai.Realtime.ResponseMcpCallCompletedEvent>? responseMcpCallCompleted = null,
            global::System.Action<global::Xai.Realtime.ResponseMcpCallFailedEvent>? responseMcpCallFailed = null,
            global::System.Action<global::Xai.Realtime.McpListToolsCompletedEvent>? mcpListToolsCompleted = null,
            global::System.Action<global::Xai.Realtime.ErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsConversationCreated)
            {
                conversationCreated?.Invoke(ConversationCreated!);
            }
            else if (IsConversationItemAdded)
            {
                conversationItemAdded?.Invoke(ConversationItemAdded!);
            }
            else if (IsInputAudioBufferSpeechStarted)
            {
                inputAudioBufferSpeechStarted?.Invoke(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped)
            {
                inputAudioBufferSpeechStopped?.Invoke(InputAudioBufferSpeechStopped!);
            }
            else if (IsInputAudioBufferCommitted)
            {
                inputAudioBufferCommitted?.Invoke(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioTranscriptionCompleted)
            {
                inputAudioTranscriptionCompleted?.Invoke(InputAudioTranscriptionCompleted!);
            }
            else if (IsResponseCreated)
            {
                responseCreated?.Invoke(ResponseCreated!);
            }
            else if (IsResponseDone)
            {
                responseDone?.Invoke(ResponseDone!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputAudioTranscriptDelta)
            {
                responseOutputAudioTranscriptDelta?.Invoke(ResponseOutputAudioTranscriptDelta!);
            }
            else if (IsResponseOutputAudioTranscriptDone)
            {
                responseOutputAudioTranscriptDone?.Invoke(ResponseOutputAudioTranscriptDone!);
            }
            else if (IsResponseOutputAudioDelta)
            {
                responseOutputAudioDelta?.Invoke(ResponseOutputAudioDelta!);
            }
            else if (IsResponseOutputAudioDone)
            {
                responseOutputAudioDone?.Invoke(ResponseOutputAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseMcpCallArgumentsDone)
            {
                responseMcpCallArgumentsDone?.Invoke(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallCompleted)
            {
                responseMcpCallCompleted?.Invoke(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed)
            {
                responseMcpCallFailed?.Invoke(ResponseMcpCallFailed!);
            }
            else if (IsMcpListToolsCompleted)
            {
                mcpListToolsCompleted?.Invoke(McpListToolsCompleted!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionCreated,
                typeof(global::Xai.Realtime.SessionCreatedEvent),
                SessionUpdated,
                typeof(global::Xai.Realtime.SessionUpdatedEvent),
                ConversationCreated,
                typeof(global::Xai.Realtime.ConversationCreatedEvent),
                ConversationItemAdded,
                typeof(global::Xai.Realtime.ConversationItemAddedEvent),
                InputAudioBufferSpeechStarted,
                typeof(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent),
                InputAudioBufferSpeechStopped,
                typeof(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent),
                InputAudioBufferCommitted,
                typeof(global::Xai.Realtime.InputAudioBufferCommittedEvent),
                InputAudioTranscriptionCompleted,
                typeof(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent),
                ResponseCreated,
                typeof(global::Xai.Realtime.ResponseCreatedEvent),
                ResponseDone,
                typeof(global::Xai.Realtime.ResponseDoneEvent),
                ResponseOutputItemAdded,
                typeof(global::Xai.Realtime.ResponseOutputItemAddedEvent),
                ResponseOutputAudioTranscriptDelta,
                typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent),
                ResponseOutputAudioTranscriptDone,
                typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent),
                ResponseOutputAudioDelta,
                typeof(global::Xai.Realtime.ResponseOutputAudioDeltaEvent),
                ResponseOutputAudioDone,
                typeof(global::Xai.Realtime.ResponseOutputAudioDoneEvent),
                ResponseFunctionCallArgumentsDone,
                typeof(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent),
                ResponseMcpCallArgumentsDone,
                typeof(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent),
                ResponseMcpCallCompleted,
                typeof(global::Xai.Realtime.ResponseMcpCallCompletedEvent),
                ResponseMcpCallFailed,
                typeof(global::Xai.Realtime.ResponseMcpCallFailedEvent),
                McpListToolsCompleted,
                typeof(global::Xai.Realtime.McpListToolsCompletedEvent),
                Error,
                typeof(global::Xai.Realtime.ErrorEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.SessionCreatedEvent?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.SessionUpdatedEvent?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ConversationCreatedEvent?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ConversationItemAddedEvent?>.Default.Equals(ConversationItemAdded, other.ConversationItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.InputAudioBufferSpeechStartedEvent?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.InputAudioBufferCommittedEvent?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.InputAudioTranscriptionCompletedEvent?>.Default.Equals(InputAudioTranscriptionCompleted, other.InputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseCreatedEvent?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseDoneEvent?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseOutputItemAddedEvent?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent?>.Default.Equals(ResponseOutputAudioTranscriptDelta, other.ResponseOutputAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent?>.Default.Equals(ResponseOutputAudioTranscriptDone, other.ResponseOutputAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseOutputAudioDeltaEvent?>.Default.Equals(ResponseOutputAudioDelta, other.ResponseOutputAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseOutputAudioDoneEvent?>.Default.Equals(ResponseOutputAudioDone, other.ResponseOutputAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent?>.Default.Equals(ResponseMcpCallArgumentsDone, other.ResponseMcpCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseMcpCallCompletedEvent?>.Default.Equals(ResponseMcpCallCompleted, other.ResponseMcpCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ResponseMcpCallFailedEvent?>.Default.Equals(ResponseMcpCallFailed, other.ResponseMcpCallFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.McpListToolsCompletedEvent?>.Default.Equals(McpListToolsCompleted, other.McpListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.Realtime.ErrorEvent?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
