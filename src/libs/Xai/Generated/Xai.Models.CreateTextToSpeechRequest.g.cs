
#nullable enable

namespace Xai
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToSpeechRequest
    {
        /// <summary>
        /// The text to convert to speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Built-in voice ID or custom voice ID. Defaults to eve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// BCP-47 language code or auto for automatic language detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::Xai.TextToSpeechOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Latency optimization level for synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimize_streaming_latency")]
        public int? OptimizeStreamingLatency { get; set; }

        /// <summary>
        /// Whether to normalize written-form text into spoken-form before synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_normalization")]
        public bool? TextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to convert to speech.
        /// </param>
        /// <param name="language">
        /// BCP-47 language code or auto for automatic language detection.
        /// </param>
        /// <param name="voiceId">
        /// Built-in voice ID or custom voice ID. Defaults to eve.
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="optimizeStreamingLatency">
        /// Latency optimization level for synthesis.
        /// </param>
        /// <param name="textNormalization">
        /// Whether to normalize written-form text into spoken-form before synthesis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequest(
            string text,
            string language,
            string? voiceId,
            global::Xai.TextToSpeechOutputFormat? outputFormat,
            int? optimizeStreamingLatency,
            bool? textNormalization)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.OutputFormat = outputFormat;
            this.OptimizeStreamingLatency = optimizeStreamingLatency;
            this.TextNormalization = textNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequest" /> class.
        /// </summary>
        public CreateTextToSpeechRequest()
        {
        }
    }
}