#nullable enable

namespace Xai.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCustomVoiceRequestGenderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.CreateCustomVoiceRequestGender?>
    {
        /// <inheritdoc />
        public override global::Xai.CreateCustomVoiceRequestGender? Read(
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
                        return global::Xai.CreateCustomVoiceRequestGenderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.CreateCustomVoiceRequestGender)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.CreateCustomVoiceRequestGender?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.CreateCustomVoiceRequestGender? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Xai.CreateCustomVoiceRequestGenderExtensions.ToValueString(value.Value));
            }
        }
    }
}
