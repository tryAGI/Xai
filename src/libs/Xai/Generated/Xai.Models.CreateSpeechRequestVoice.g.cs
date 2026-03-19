
#nullable enable

namespace Xai
{
    /// <summary>
    /// The voice to use for synthesis.
    /// </summary>
    public enum CreateSpeechRequestVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Eve,
        /// <summary>
        /// 
        /// </summary>
        Ara,
        /// <summary>
        /// 
        /// </summary>
        Rex,
        /// <summary>
        /// 
        /// </summary>
        Sal,
        /// <summary>
        /// 
        /// </summary>
        Leo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestVoice value)
        {
            return value switch
            {
                CreateSpeechRequestVoice.Eve => "Eve",
                CreateSpeechRequestVoice.Ara => "Ara",
                CreateSpeechRequestVoice.Rex => "Rex",
                CreateSpeechRequestVoice.Sal => "Sal",
                CreateSpeechRequestVoice.Leo => "Leo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestVoice? ToEnum(string value)
        {
            return value switch
            {
                "Eve" => CreateSpeechRequestVoice.Eve,
                "Ara" => CreateSpeechRequestVoice.Ara,
                "Rex" => CreateSpeechRequestVoice.Rex,
                "Sal" => CreateSpeechRequestVoice.Sal,
                "Leo" => CreateSpeechRequestVoice.Leo,
                _ => null,
            };
        }
    }
}