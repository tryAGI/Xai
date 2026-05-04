
#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        AudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioDoneEventType value)
        {
            return value switch
            {
                AudioDoneEventType.AudioDone => "audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "audio.done" => AudioDoneEventType.AudioDone,
                _ => null,
            };
        }
    }
}