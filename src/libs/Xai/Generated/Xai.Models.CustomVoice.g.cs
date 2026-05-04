
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomVoice
    {
        /// <summary>
        /// 8-character lowercase alphanumeric voice identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Free-text description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Voice gender label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CustomVoiceGenderJsonConverter))]
        public global::Xai.CustomVoiceGender? Gender { get; set; }

        /// <summary>
        /// Free-text accent label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Voice age label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.CustomVoiceAgeJsonConverter))]
        public global::Xai.CustomVoiceAge? Age { get; set; }

        /// <summary>
        /// ISO 639 or BCP-47 language code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Intended use case label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        public string? UseCase { get; set; }

        /// <summary>
        /// Tonal label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        public string? Tone { get; set; }

        /// <summary>
        /// RFC 3339 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// 8-character lowercase alphanumeric voice identifier.
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 timestamp.
        /// </param>
        /// <param name="name">
        /// Display name.
        /// </param>
        /// <param name="description">
        /// Free-text description.
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
        /// ISO 639 or BCP-47 language code.
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
        public CustomVoice(
            string voiceId,
            string createdAt,
            string? name,
            string? description,
            global::Xai.CustomVoiceGender? gender,
            string? accent,
            global::Xai.CustomVoiceAge? age,
            string? language,
            string? useCase,
            string? tone)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name;
            this.Description = description;
            this.Gender = gender;
            this.Accent = accent;
            this.Age = age;
            this.Language = language;
            this.UseCase = useCase;
            this.Tone = tone;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVoice" /> class.
        /// </summary>
        public CustomVoice()
        {
        }
    }
}