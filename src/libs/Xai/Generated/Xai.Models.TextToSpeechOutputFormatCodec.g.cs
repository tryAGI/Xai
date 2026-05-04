
#nullable enable

namespace Xai
{
    /// <summary>
    /// Audio codec for the output.
    /// </summary>
    public enum TextToSpeechOutputFormatCodec
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechOutputFormatCodecExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechOutputFormatCodec value)
        {
            return value switch
            {
                TextToSpeechOutputFormatCodec.Alaw => "alaw",
                TextToSpeechOutputFormatCodec.Mp3 => "mp3",
                TextToSpeechOutputFormatCodec.Mulaw => "mulaw",
                TextToSpeechOutputFormatCodec.Pcm => "pcm",
                TextToSpeechOutputFormatCodec.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechOutputFormatCodec? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => TextToSpeechOutputFormatCodec.Alaw,
                "mp3" => TextToSpeechOutputFormatCodec.Mp3,
                "mulaw" => TextToSpeechOutputFormatCodec.Mulaw,
                "pcm" => TextToSpeechOutputFormatCodec.Pcm,
                "wav" => TextToSpeechOutputFormatCodec.Wav,
                _ => null,
            };
        }
    }
}