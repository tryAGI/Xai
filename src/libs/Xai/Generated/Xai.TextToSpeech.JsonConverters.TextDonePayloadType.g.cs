#nullable enable

namespace Xai.TextToSpeech.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextDonePayloadTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.TextToSpeech.TextDonePayloadType>
    {
        /// <inheritdoc />
        public override global::Xai.TextToSpeech.TextDonePayloadType Read(
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
                        return global::Xai.TextToSpeech.TextDonePayloadTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.TextToSpeech.TextDonePayloadType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.TextToSpeech.TextDonePayloadType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.TextToSpeech.TextDonePayloadType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Xai.TextToSpeech.TextDonePayloadTypeExtensions.ToValueString(value));
        }
    }
}
