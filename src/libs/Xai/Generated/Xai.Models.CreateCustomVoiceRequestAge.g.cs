
#nullable enable

namespace Xai
{
    /// <summary>
    /// Voice age label.
    /// </summary>
    public enum CreateCustomVoiceRequestAge
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
    public static class CreateCustomVoiceRequestAgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomVoiceRequestAge value)
        {
            return value switch
            {
                CreateCustomVoiceRequestAge.MiddleAged => "middle-aged",
                CreateCustomVoiceRequestAge.Old => "old",
                CreateCustomVoiceRequestAge.Young => "young",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomVoiceRequestAge? ToEnum(string value)
        {
            return value switch
            {
                "middle-aged" => CreateCustomVoiceRequestAge.MiddleAged,
                "old" => CreateCustomVoiceRequestAge.Old,
                "young" => CreateCustomVoiceRequestAge.Young,
                _ => null,
            };
        }
    }
}