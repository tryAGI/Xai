#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Xai.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.Realtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Xai.Realtime.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Xai.Realtime.SessionCreatedEvent? sessionCreated = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.SessionCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.SessionCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.SessionCreatedEvent)}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.SessionUpdatedEvent? sessionUpdated = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.SessionUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.SessionUpdatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.SessionUpdatedEvent)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ConversationCreatedEvent? conversationCreated = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ConversationCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ConversationCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ConversationCreatedEvent)}");
                conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ConversationItemAddedEvent? conversationItemAdded = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ConversationItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ConversationItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ConversationItemAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ConversationItemAddedEvent)}");
                conversationItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.InputAudioBufferSpeechStartedEvent? inputAudioBufferSpeechStarted = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.InputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.InputAudioBufferSpeechStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent)}");
                inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent? inputAudioBufferSpeechStopped = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.InputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent)}");
                inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.InputAudioBufferCommittedEvent? inputAudioBufferCommitted = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.InputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.InputAudioBufferCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.InputAudioBufferCommittedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.InputAudioBufferCommittedEvent)}");
                inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.InputAudioTranscriptionCompletedEvent? inputAudioTranscriptionCompleted = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.InputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.InputAudioTranscriptionCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent)}");
                inputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseCreatedEvent? responseCreated = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseCreatedEvent)}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseDoneEvent? responseDone = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseDoneEvent)}");
                responseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseOutputItemAddedEvent? responseOutputItemAdded = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputItemAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseOutputItemAddedEvent)}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent? responseOutputAudioTranscriptDelta = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent)}");
                responseOutputAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent? responseOutputAudioTranscriptDone = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent)}");
                responseOutputAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseOutputAudioDeltaEvent? responseOutputAudioDelta = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputAudioDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseOutputAudioDeltaEvent)}");
                responseOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseOutputAudioDoneEvent? responseOutputAudioDone = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseOutputAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputAudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseOutputAudioDoneEvent)}");
                responseOutputAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent)}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent? responseMcpCallArgumentsDone = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseMcpCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent)}");
                responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseMcpCallCompletedEvent? responseMcpCallCompleted = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseMcpCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseMcpCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseMcpCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseMcpCallCompletedEvent)}");
                responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ResponseMcpCallFailedEvent? responseMcpCallFailed = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.ResponseMcpCallFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseMcpCallFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseMcpCallFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ResponseMcpCallFailedEvent)}");
                responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.McpListToolsCompletedEvent? mcpListToolsCompleted = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.McpListToolsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.McpListToolsCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.McpListToolsCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.McpListToolsCompletedEvent)}");
                mcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.Realtime.ErrorEvent? error = default;
            if (discriminator?.Type == global::Xai.Realtime.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.Realtime.ErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Xai.Realtime.ServerEvent(
                discriminator?.Type,
                sessionCreated,

                sessionUpdated,

                conversationCreated,

                conversationItemAdded,

                inputAudioBufferSpeechStarted,

                inputAudioBufferSpeechStopped,

                inputAudioBufferCommitted,

                inputAudioTranscriptionCompleted,

                responseCreated,

                responseDone,

                responseOutputItemAdded,

                responseOutputAudioTranscriptDelta,

                responseOutputAudioTranscriptDone,

                responseOutputAudioDelta,

                responseOutputAudioDone,

                responseFunctionCallArgumentsDone,

                responseMcpCallArgumentsDone,

                responseMcpCallCompleted,

                responseMcpCallFailed,

                mcpListToolsCompleted,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.Realtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.SessionCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.SessionCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.SessionCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.SessionUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.SessionUpdatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.SessionUpdatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated, typeInfo);
            }
            else if (value.IsConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ConversationCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ConversationCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ConversationCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated, typeInfo);
            }
            else if (value.IsConversationItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ConversationItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ConversationItemAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ConversationItemAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemAdded, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.InputAudioBufferSpeechStartedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.InputAudioBufferSpeechStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.InputAudioBufferSpeechStoppedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.InputAudioBufferCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.InputAudioBufferCommittedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.InputAudioBufferCommittedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted, typeInfo);
            }
            else if (value.IsInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.InputAudioTranscriptionCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.InputAudioTranscriptionCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioTranscriptionCompleted, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputItemAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseOutputItemAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeInfo);
            }
            else if (value.IsResponseOutputAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioTranscriptDelta, typeInfo);
            }
            else if (value.IsResponseOutputAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseOutputAudioTranscriptDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioTranscriptDone, typeInfo);
            }
            else if (value.IsResponseOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputAudioDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseOutputAudioDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioDelta, typeInfo);
            }
            else if (value.IsResponseOutputAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseOutputAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseOutputAudioDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseOutputAudioDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioDone, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseFunctionCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseMcpCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDone, typeInfo);
            }
            else if (value.IsResponseMcpCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseMcpCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseMcpCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseMcpCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallCompleted, typeInfo);
            }
            else if (value.IsResponseMcpCallFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ResponseMcpCallFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ResponseMcpCallFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ResponseMcpCallFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallFailed, typeInfo);
            }
            else if (value.IsMcpListToolsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.McpListToolsCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.McpListToolsCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.McpListToolsCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsCompleted, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.Realtime.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.Realtime.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.Realtime.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
        }
    }
}