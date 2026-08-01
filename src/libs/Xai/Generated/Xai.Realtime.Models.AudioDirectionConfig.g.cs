
#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// Audio direction (input or output) configuration.
    /// </summary>
    public sealed partial class AudioDirectionConfig
    {
        /// <summary>
        /// Audio format specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::Xai.Realtime.AudioFormatConfig? Format { get; set; }

        /// <summary>
        /// How audio is transported over the WebSocket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.Realtime.JsonConverters.AudioTransportJsonConverter))]
        public global::Xai.Realtime.AudioTransport? Transport { get; set; }

        /// <summary>
        /// Hints and options for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::Xai.Realtime.AudioTranscriptionConfig? Transcription { get; set; }

        /// <summary>
        /// Audio output speed from 0.7 to 1.5. Only applies to output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDirectionConfig" /> class.
        /// </summary>
        /// <param name="format">
        /// Audio format specification.
        /// </param>
        /// <param name="transport">
        /// How audio is transported over the WebSocket.
        /// </param>
        /// <param name="transcription">
        /// Hints and options for input audio transcription.
        /// </param>
        /// <param name="speed">
        /// Audio output speed from 0.7 to 1.5. Only applies to output audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioDirectionConfig(
            global::Xai.Realtime.AudioFormatConfig? format,
            global::Xai.Realtime.AudioTransport? transport,
            global::Xai.Realtime.AudioTranscriptionConfig? transcription,
            double? speed)
        {
            this.Format = format;
            this.Transport = transport;
            this.Transcription = transcription;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDirectionConfig" /> class.
        /// </summary>
        public AudioDirectionConfig()
        {
        }

    }
}