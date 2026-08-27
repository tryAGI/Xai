#nullable enable

namespace Xai.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateCustomVoiceRequestToneNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.UpdateCustomVoiceRequestTone?>
    {
        /// <inheritdoc />
        public override global::Xai.UpdateCustomVoiceRequestTone? Read(
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
                        return global::Xai.UpdateCustomVoiceRequestToneExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.UpdateCustomVoiceRequestTone)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.UpdateCustomVoiceRequestTone?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.UpdateCustomVoiceRequestTone? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Xai.UpdateCustomVoiceRequestToneExtensions.ToValueString(value.Value));
            }
        }
    }
}
