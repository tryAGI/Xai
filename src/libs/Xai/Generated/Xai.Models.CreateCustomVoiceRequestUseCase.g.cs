
#nullable enable

namespace Xai
{
    /// <summary>
    /// Intended use case label.
    /// </summary>
    public enum CreateCustomVoiceRequestUseCase
    {
        /// <summary>
        /// 
        /// </summary>
        Advertisement,
        /// <summary>
        /// 
        /// </summary>
        Characters,
        /// <summary>
        /// 
        /// </summary>
        Conversational,
        /// <summary>
        /// 
        /// </summary>
        Educational,
        /// <summary>
        /// 
        /// </summary>
        Entertainment,
        /// <summary>
        /// 
        /// </summary>
        Narration,
        /// <summary>
        /// 
        /// </summary>
        SocialMedia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCustomVoiceRequestUseCaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomVoiceRequestUseCase value)
        {
            return value switch
            {
                CreateCustomVoiceRequestUseCase.Advertisement => "advertisement",
                CreateCustomVoiceRequestUseCase.Characters => "characters",
                CreateCustomVoiceRequestUseCase.Conversational => "conversational",
                CreateCustomVoiceRequestUseCase.Educational => "educational",
                CreateCustomVoiceRequestUseCase.Entertainment => "entertainment",
                CreateCustomVoiceRequestUseCase.Narration => "narration",
                CreateCustomVoiceRequestUseCase.SocialMedia => "social_media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomVoiceRequestUseCase? ToEnum(string value)
        {
            return value switch
            {
                "advertisement" => CreateCustomVoiceRequestUseCase.Advertisement,
                "characters" => CreateCustomVoiceRequestUseCase.Characters,
                "conversational" => CreateCustomVoiceRequestUseCase.Conversational,
                "educational" => CreateCustomVoiceRequestUseCase.Educational,
                "entertainment" => CreateCustomVoiceRequestUseCase.Entertainment,
                "narration" => CreateCustomVoiceRequestUseCase.Narration,
                "social_media" => CreateCustomVoiceRequestUseCase.SocialMedia,
                _ => null,
            };
        }
    }
}