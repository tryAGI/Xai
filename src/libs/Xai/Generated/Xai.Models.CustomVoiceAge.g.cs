
#nullable enable

namespace Xai
{
    /// <summary>
    /// Voice age label.
    /// </summary>
    public enum CustomVoiceAge
    {
        /// <summary>
        ///
        /// </summary>
        MiddleAged,
        /// <summary>
        ///
        /// </summary>
        Old,
        /// <summary>
        ///
        /// </summary>
        Young,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomVoiceAgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomVoiceAge value)
        {
            return value switch
            {
                CustomVoiceAge.MiddleAged => "middle-aged",
                CustomVoiceAge.Old => "old",
                CustomVoiceAge.Young => "young",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomVoiceAge? ToEnum(string value)
        {
            return value switch
            {
                "middle-aged" => CustomVoiceAge.MiddleAged,
                "old" => CustomVoiceAge.Old,
                "young" => CustomVoiceAge.Young,
                _ => null,
            };
        }
    }
}