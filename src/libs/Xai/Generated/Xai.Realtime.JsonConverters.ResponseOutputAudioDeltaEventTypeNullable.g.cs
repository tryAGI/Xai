#nullable enable

namespace Xai.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseOutputAudioDeltaEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.Realtime.ResponseOutputAudioDeltaEventType?>
    {
        /// <inheritdoc />
        public override global::Xai.Realtime.ResponseOutputAudioDeltaEventType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Xai.Realtime.ResponseOutputAudioDeltaEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.Realtime.ResponseOutputAudioDeltaEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.Realtime.ResponseOutputAudioDeltaEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.Realtime.ResponseOutputAudioDeltaEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Xai.Realtime.ResponseOutputAudioDeltaEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
