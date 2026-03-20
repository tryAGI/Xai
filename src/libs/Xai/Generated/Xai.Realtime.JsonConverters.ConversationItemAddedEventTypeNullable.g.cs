#nullable enable

namespace Xai.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationItemAddedEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.Realtime.ConversationItemAddedEventType?>
    {
        /// <inheritdoc />
        public override global::Xai.Realtime.ConversationItemAddedEventType? Read(
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
                        return global::Xai.Realtime.ConversationItemAddedEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.Realtime.ConversationItemAddedEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.Realtime.ConversationItemAddedEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.Realtime.ConversationItemAddedEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Xai.Realtime.ConversationItemAddedEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
