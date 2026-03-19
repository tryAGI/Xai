#nullable enable

namespace Xai.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionNamedToolChoiceTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.ChatCompletionNamedToolChoiceType>
    {
        /// <inheritdoc />
        public override global::Xai.ChatCompletionNamedToolChoiceType Read(
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
                        return global::Xai.ChatCompletionNamedToolChoiceTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.ChatCompletionNamedToolChoiceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.ChatCompletionNamedToolChoiceType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.ChatCompletionNamedToolChoiceType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Xai.ChatCompletionNamedToolChoiceTypeExtensions.ToValueString(value));
        }
    }
}
