
#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// How audio is transported over the WebSocket.
    /// </summary>
    public enum AudioTransport
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTransport value)
        {
            return value switch
            {
                AudioTransport.Binary => "binary",
                AudioTransport.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTransport? ToEnum(string value)
        {
            return value switch
            {
                "binary" => AudioTransport.Binary,
                "json" => AudioTransport.Json,
                _ => null,
            };
        }
    }
}