
#nullable enable

namespace Xai
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCustomVoiceRequest
    {
        /// <summary>
        /// Reference audio file. Maximum duration is 120 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Reference audio file. Maximum duration is 120 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Display name for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Free-text description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Voice gender label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateCustomVoiceRequestGenderJsonConverter))]
        public global::Xai.CreateCustomVoiceRequestGender? Gender { get; set; }

        /// <summary>
        /// Free-text accent label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Voice age label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateCustomVoiceRequestAgeJsonConverter))]
        public global::Xai.CreateCustomVoiceRequestAge? Age { get; set; }

        /// <summary>
        /// ISO 639 or BCP-47-style language code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Intended use case label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateCustomVoiceRequestUseCaseJsonConverter))]
        public global::Xai.CreateCustomVoiceRequestUseCase? UseCase { get; set; }

        /// <summary>
        /// Tonal label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CreateCustomVoiceRequestToneJsonConverter))]
        public global::Xai.CreateCustomVoiceRequestTone? Tone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomVoiceRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Reference audio file. Maximum duration is 120 seconds.
        /// </param>
        /// <param name="filename">
        /// Reference audio file. Maximum duration is 120 seconds.
        /// </param>
        /// <param name="name">
        /// Display name for the voice.
        /// </param>
        /// <param name="description">
        /// Free-text description of the voice.
        /// </param>
        /// <param name="gender">
        /// Voice gender label.
        /// </param>
        /// <param name="accent">
        /// Free-text accent label.
        /// </param>
        /// <param name="age">
        /// Voice age label.
        /// </param>
        /// <param name="language">
        /// ISO 639 or BCP-47-style language code.
        /// </param>
        /// <param name="useCase">
        /// Intended use case label.
        /// </param>
        /// <param name="tone">
        /// Tonal label.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCustomVoiceRequest(
            byte[] file,
            string filename,
            string? name,
            string? description,
            global::Xai.CreateCustomVoiceRequestGender? gender,
            string? accent,
            global::Xai.CreateCustomVoiceRequestAge? age,
            string? language,
            global::Xai.CreateCustomVoiceRequestUseCase? useCase,
            global::Xai.CreateCustomVoiceRequestTone? tone)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Name = name;
            this.Description = description;
            this.Gender = gender;
            this.Accent = accent;
            this.Age = age;
            this.Language = language;
            this.UseCase = useCase;
            this.Tone = tone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomVoiceRequest" /> class.
        /// </summary>
        public CreateCustomVoiceRequest()
        {
        }
    }
}