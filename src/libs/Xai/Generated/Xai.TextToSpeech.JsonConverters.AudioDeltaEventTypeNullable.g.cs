#nullable enable

namespace Xai.TextToSpeech.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioDeltaEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.TextToSpeech.AudioDeltaEventType?>
    {
        /// <inheritdoc />
        public override global::Xai.TextToSpeech.AudioDeltaEventType? Read(
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
                        return global::Xai.TextToSpeech.AudioDeltaEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.TextToSpeech.AudioDeltaEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.TextToSpeech.AudioDeltaEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.TextToSpeech.AudioDeltaEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Xai.TextToSpeech.AudioDeltaEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
