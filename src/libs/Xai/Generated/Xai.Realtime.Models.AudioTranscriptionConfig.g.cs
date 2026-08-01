
#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// Hints and options for input audio transcription.
    /// </summary>
    public sealed partial class AudioTranscriptionConfig
    {
        /// <summary>
        /// Transcription model. Use grok-transcribe to receive cumulative transcript updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// BCP-47 language hint for the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hint")]
        public string? LanguageHint { get; set; }

        /// <summary>
        /// Up to 100 important terms, with up to 50 characters per term, that should be transcribed accurately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// Transcription model. Use grok-transcribe to receive cumulative transcript updates.
        /// </param>
        /// <param name="languageHint">
        /// BCP-47 language hint for the input audio.
        /// </param>
        /// <param name="keyterms">
        /// Up to 100 important terms, with up to 50 characters per term, that should be transcribed accurately.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionConfig(
            string? model,
            string? languageHint,
            global::System.Collections.Generic.IList<string>? keyterms)
        {
            this.Model = model;
            this.LanguageHint = languageHint;
            this.Keyterms = keyterms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionConfig" /> class.
        /// </summary>
        public AudioTranscriptionConfig()
        {
        }

    }
}