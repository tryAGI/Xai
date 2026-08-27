
#nullable enable

namespace Xai
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateCustomVoiceRequestAge
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
    public static class UpdateCustomVoiceRequestAgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomVoiceRequestAge value)
        {
            return value switch
            {
                UpdateCustomVoiceRequestAge.MiddleAged => "middle-aged",
                UpdateCustomVoiceRequestAge.Old => "old",
                UpdateCustomVoiceRequestAge.Young => "young",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomVoiceRequestAge? ToEnum(string value)
        {
            return value switch
            {
                "middle-aged" => UpdateCustomVoiceRequestAge.MiddleAged,
                "old" => UpdateCustomVoiceRequestAge.Old,
                "young" => UpdateCustomVoiceRequestAge.Young,
                _ => null,
            };
        }
    }
}