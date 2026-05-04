#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Xai.TextToSpeech.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.TextToSpeech.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Xai.TextToSpeech.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.TextToSpeech.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.TextToSpeech.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.TextToSpeech.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Xai.TextToSpeech.AudioDeltaEvent? audioDelta = default;
            if (discriminator?.Type == global::Xai.TextToSpeech.ServerEventDiscriminatorType.AudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.TextToSpeech.AudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.TextToSpeech.AudioDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.TextToSpeech.AudioDeltaEvent)}");
                audioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.TextToSpeech.AudioDoneEvent? audioDone = default;
            if (discriminator?.Type == global::Xai.TextToSpeech.ServerEventDiscriminatorType.AudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.TextToSpeech.AudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.TextToSpeech.AudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.TextToSpeech.AudioDoneEvent)}");
                audioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Xai.TextToSpeech.ErrorEvent? error = default;
            if (discriminator?.Type == global::Xai.TextToSpeech.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.TextToSpeech.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.TextToSpeech.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Xai.TextToSpeech.ErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Xai.TextToSpeech.ServerEvent(
                discriminator?.Type,
                audioDelta,

                audioDone,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.TextToSpeech.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.TextToSpeech.AudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.TextToSpeech.AudioDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.TextToSpeech.AudioDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioDelta!, typeInfo);
            }
            else if (value.IsAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.TextToSpeech.AudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.TextToSpeech.AudioDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.TextToSpeech.AudioDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioDone!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Xai.TextToSpeech.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Xai.TextToSpeech.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Xai.TextToSpeech.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}