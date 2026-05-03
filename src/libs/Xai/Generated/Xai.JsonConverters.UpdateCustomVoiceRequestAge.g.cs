#nullable enable

namespace Xai.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateCustomVoiceRequestAgeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.UpdateCustomVoiceRequestAge>
    {
        /// <inheritdoc />
        public override global::Xai.UpdateCustomVoiceRequestAge Read(
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
                        return global::Xai.UpdateCustomVoiceRequestAgeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.UpdateCustomVoiceRequestAge)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.UpdateCustomVoiceRequestAge);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.UpdateCustomVoiceRequestAge value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Xai.UpdateCustomVoiceRequestAgeExtensions.ToValueString(value));
        }
    }
}
