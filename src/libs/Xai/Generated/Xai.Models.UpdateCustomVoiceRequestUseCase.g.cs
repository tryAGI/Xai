
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCustomVoiceRequestUseCase
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
    public static class UpdateCustomVoiceRequestUseCaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomVoiceRequestUseCase value)
        {
            return value switch
            {
                UpdateCustomVoiceRequestUseCase.Advertisement => "advertisement",
                UpdateCustomVoiceRequestUseCase.Characters => "characters",
                UpdateCustomVoiceRequestUseCase.Conversational => "conversational",
                UpdateCustomVoiceRequestUseCase.Educational => "educational",
                UpdateCustomVoiceRequestUseCase.Entertainment => "entertainment",
                UpdateCustomVoiceRequestUseCase.Narration => "narration",
                UpdateCustomVoiceRequestUseCase.SocialMedia => "social_media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomVoiceRequestUseCase? ToEnum(string value)
        {
            return value switch
            {
                "advertisement" => UpdateCustomVoiceRequestUseCase.Advertisement,
                "characters" => UpdateCustomVoiceRequestUseCase.Characters,
                "conversational" => UpdateCustomVoiceRequestUseCase.Conversational,
                "educational" => UpdateCustomVoiceRequestUseCase.Educational,
                "entertainment" => UpdateCustomVoiceRequestUseCase.Entertainment,
                "narration" => UpdateCustomVoiceRequestUseCase.Narration,
                "social_media" => UpdateCustomVoiceRequestUseCase.SocialMedia,
                _ => null,
            };
        }
    }
}