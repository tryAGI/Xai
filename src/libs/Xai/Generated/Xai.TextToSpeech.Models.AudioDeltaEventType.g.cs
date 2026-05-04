
#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioDeltaEventType value)
        {
            return value switch
            {
                AudioDeltaEventType.AudioDelta => "audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "audio.delta" => AudioDeltaEventType.AudioDelta,
                _ => null,
            };
        }
    }
}