#nullable enable

namespace Xai.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchDocumentsRequestModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Xai.SearchDocumentsRequestMode?>
    {
        /// <inheritdoc />
        public override global::Xai.SearchDocumentsRequestMode? Read(
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
                        return global::Xai.SearchDocumentsRequestModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Xai.SearchDocumentsRequestMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Xai.SearchDocumentsRequestMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Xai.SearchDocumentsRequestMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Xai.SearchDocumentsRequestModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
