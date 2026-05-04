
#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextDonePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        TextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextDonePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextDonePayloadType value)
        {
            return value switch
            {
                TextDonePayloadType.TextDone => "text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextDonePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "text.done" => TextDonePayloadType.TextDone,
                _ => null,
            };
        }
    }
}