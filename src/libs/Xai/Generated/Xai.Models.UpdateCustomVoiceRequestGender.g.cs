
#nullable enable

namespace Xai
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateCustomVoiceRequestGender
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
    public static class UpdateCustomVoiceRequestGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomVoiceRequestGender value)
        {
            return value switch
            {
                UpdateCustomVoiceRequestGender.Female => "female",
                UpdateCustomVoiceRequestGender.Male => "male",
                UpdateCustomVoiceRequestGender.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomVoiceRequestGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => UpdateCustomVoiceRequestGender.Female,
                "male" => UpdateCustomVoiceRequestGender.Male,
                "neutral" => UpdateCustomVoiceRequestGender.Neutral,
                _ => null,
            };
        }
    }
}