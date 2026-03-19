
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechRequest
    {
        /// <summary>
        /// The model to use for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The text to generate audio for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The voice to use for synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateSpeechRequestVoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Xai.CreateSpeechRequestVoice Voice { get; set; }

        /// <summary>
        /// The audio format of the output.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter))]
        public global::Xai.CreateSpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The speed of the generated audio (0.25-4.0).<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for text-to-speech.
        /// </param>
        /// <param name="input">
        /// The text to generate audio for.
        /// </param>
        /// <param name="voice">
        /// The voice to use for synthesis.
        /// </param>
        /// <param name="responseFormat">
        /// The audio format of the output.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="speed">
        /// The speed of the generated audio (0.25-4.0).<br/>
        /// Default Value: 1.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechRequest(
            string model,
            string input,
            global::Xai.CreateSpeechRequestVoice voice,
            global::Xai.CreateSpeechRequestResponseFormat? responseFormat,
            double? speed)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice;
            this.ResponseFormat = responseFormat;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        public CreateSpeechRequest()
        {
        }
    }
}