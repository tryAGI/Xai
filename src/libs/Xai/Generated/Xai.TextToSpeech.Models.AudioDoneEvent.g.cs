
#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    /// All audio for the current utterance has been sent.
    /// </summary>
    public sealed partial class AudioDoneEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.TextToSpeech.JsonConverters.AudioDoneEventTypeJsonConverter))]
        public global::Xai.TextToSpeech.AudioDoneEventType Type { get; set; }

        /// <summary>
        /// Trace ID for debugging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDoneEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="traceId">
        /// Trace ID for debugging.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioDoneEvent(
            global::Xai.TextToSpeech.AudioDoneEventType type,
            string? traceId)
        {
            this.Type = type;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDoneEvent" /> class.
        /// </summary>
        public AudioDoneEvent()
        {
        }
    }
}