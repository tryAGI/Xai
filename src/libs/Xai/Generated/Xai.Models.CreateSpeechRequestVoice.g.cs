
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
        Ara,
        /// <summary>
        /// 
        /// </summary>
        Eve,
        /// <summary>
        /// 
        /// </summary>
        Leo,
        /// <summary>
        /// 
        /// </summary>
        Rex,
        /// <summary>
        /// 
        /// </summary>
        Sal,
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
                CreateSpeechRequestVoice.Ara => "Ara",
                CreateSpeechRequestVoice.Eve => "Eve",
                CreateSpeechRequestVoice.Leo => "Leo",
                CreateSpeechRequestVoice.Rex => "Rex",
                CreateSpeechRequestVoice.Sal => "Sal",
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
                "Ara" => CreateSpeechRequestVoice.Ara,
                "Eve" => CreateSpeechRequestVoice.Eve,
                "Leo" => CreateSpeechRequestVoice.Leo,
                "Rex" => CreateSpeechRequestVoice.Rex,
                "Sal" => CreateSpeechRequestVoice.Sal,
                _ => null,
            };
        }
    }
}