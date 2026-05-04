
#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    ///
    /// </summary>
    public enum TextDeltaPayloadType
    {
        /// <summary>
        ///
        /// </summary>
        TextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextDeltaPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextDeltaPayloadType value)
        {
            return value switch
            {
                TextDeltaPayloadType.TextDelta => "text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextDeltaPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "text.delta" => TextDeltaPayloadType.TextDelta,
                _ => null,
            };
        }
    }
}