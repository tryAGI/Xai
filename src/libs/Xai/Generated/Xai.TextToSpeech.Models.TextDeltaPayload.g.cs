
#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    /// A chunk of text to synthesize. Individual deltas are capped at 15,000 characters.
    /// </summary>
    public sealed partial class TextDeltaPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.TextToSpeech.JsonConverters.TextDeltaPayloadTypeJsonConverter))]
        public global::Xai.TextToSpeech.TextDeltaPayloadType Type { get; set; }

        /// <summary>
        /// Text chunk to synthesize.
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
        /// Initializes a new instance of the <see cref="TextDeltaPayload" /> class.
        /// </summary>
        /// <param name="delta">
        /// Text chunk to synthesize.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextDeltaPayload(
            string delta,
            global::Xai.TextToSpeech.TextDeltaPayloadType type)
        {
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextDeltaPayload" /> class.
        /// </summary>
        public TextDeltaPayload()
        {
        }

    }
}