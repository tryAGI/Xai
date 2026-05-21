
#nullable enable

namespace Xai
{
    /// <summary>
    /// Voice gender label.
    /// </summary>
    public enum CustomVoiceGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomVoiceGender value)
        {
            return value switch
            {
                CustomVoiceGender.Female => "female",
                CustomVoiceGender.Male => "male",
                CustomVoiceGender.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => CustomVoiceGender.Female,
                "male" => CustomVoiceGender.Male,
                "neutral" => CustomVoiceGender.Neutral,
                _ => null,
            };
        }
    }
}