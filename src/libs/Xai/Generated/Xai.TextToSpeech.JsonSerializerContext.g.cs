
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Xai.TextToSpeech
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Xai.TextToSpeech.JsonConverters.TextDeltaPayloadTypeJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.TextDeltaPayloadTypeNullableJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.TextDonePayloadTypeJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.TextDonePayloadTypeNullableJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.AudioDeltaEventTypeJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.AudioDeltaEventTypeNullableJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.AudioDoneEventTypeJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.AudioDoneEventTypeNullableJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.ErrorEventTypeJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.ErrorEventTypeNullableJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Xai.TextToSpeech.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.TextDeltaPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.TextDeltaPayloadType), TypeInfoPropertyName = "TextDeltaPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.TextDonePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.TextDonePayloadType), TypeInfoPropertyName = "TextDonePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.AudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.AudioDeltaEventType), TypeInfoPropertyName = "AudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.AudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.AudioDoneEventType), TypeInfoPropertyName = "AudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.ErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.ErrorEventType), TypeInfoPropertyName = "ErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Xai.TextToSpeech.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    public sealed partial class TextToSpeechStreamingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}