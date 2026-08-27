
#nullable enable

namespace Xai
{
    /// <summary>
    /// Voice gender label.
    /// </summary>
    public enum CreateCustomVoiceRequestGender
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
    public static class CreateCustomVoiceRequestGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomVoiceRequestGender value)
        {
            return value switch
            {
                CreateCustomVoiceRequestGender.Female => "female",
                CreateCustomVoiceRequestGender.Male => "male",
                CreateCustomVoiceRequestGender.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomVoiceRequestGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => CreateCustomVoiceRequestGender.Female,
                "male" => CreateCustomVoiceRequestGender.Male,
                "neutral" => CreateCustomVoiceRequestGender.Neutral,
                _ => null,
            };
        }
    }
}