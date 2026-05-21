
#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioDelta,
        /// <summary>
        /// 
        /// </summary>
        AudioDone,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.AudioDelta => "audio.delta",
                ServerEventDiscriminatorType.AudioDone => "audio.done",
                ServerEventDiscriminatorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio.delta" => ServerEventDiscriminatorType.AudioDelta,
                "audio.done" => ServerEventDiscriminatorType.AudioDone,
                "error" => ServerEventDiscriminatorType.Error,
                _ => null,
            };
        }
    }
}