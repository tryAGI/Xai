
#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    /// A base64-encoded audio chunk in the codec specified at connection time.
    /// </summary>
    public sealed partial class AudioDeltaEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.TextToSpeech.JsonConverters.AudioDeltaEventTypeJsonConverter))]
        public global::Xai.TextToSpeech.AudioDeltaEventType Type { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// Base64-encoded audio bytes.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioDeltaEvent(
            string delta,
            global::Xai.TextToSpeech.AudioDeltaEventType type)
        {
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeltaEvent" /> class.
        /// </summary>
        public AudioDeltaEvent()
        {
        }

    }
}