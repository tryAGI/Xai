
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomVoiceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.UpdateCustomVoiceRequestGenderJsonConverter))]
        public global::Xai.UpdateCustomVoiceRequestGender? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.UpdateCustomVoiceRequestAgeJsonConverter))]
        public global::Xai.UpdateCustomVoiceRequestAge? Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.UpdateCustomVoiceRequestUseCaseJsonConverter))]
        public global::Xai.UpdateCustomVoiceRequestUseCase? UseCase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.UpdateCustomVoiceRequestToneJsonConverter))]
        public global::Xai.UpdateCustomVoiceRequestTone? Tone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomVoiceRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="gender"></param>
        /// <param name="accent"></param>
        /// <param name="age"></param>
        /// <param name="language"></param>
        /// <param name="useCase"></param>
        /// <param name="tone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomVoiceRequest(
            string? name,
            string? description,
            global::Xai.UpdateCustomVoiceRequestGender? gender,
            string? accent,
            global::Xai.UpdateCustomVoiceRequestAge? age,
            string? language,
            global::Xai.UpdateCustomVoiceRequestUseCase? useCase,
            global::Xai.UpdateCustomVoiceRequestTone? tone)
        {
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
        /// Initializes a new instance of the <see cref="UpdateCustomVoiceRequest" /> class.
        /// </summary>
        public UpdateCustomVoiceRequest()
        {
        }
    }
}