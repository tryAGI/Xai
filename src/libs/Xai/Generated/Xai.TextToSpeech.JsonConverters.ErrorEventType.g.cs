#nullable enable

namespace Xai.TextToSpeech.JsonConverters
{
    /// <inheritdoc />
    public sealed class ErrorEventTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.TextToSpeech.ErrorEventType>
    {
        /// <inheritdoc />
        public override global::Xai.TextToSpeech.ErrorEventType Read(
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
                        return global::Xai.TextToSpeech.ErrorEventTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.TextToSpeech.ErrorEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.TextToSpeech.ErrorEventType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.TextToSpeech.ErrorEventType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Xai.TextToSpeech.ErrorEventTypeExtensions.ToValueString(value));
        }
    }
}
