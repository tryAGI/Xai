
#nullable enable

namespace Xai
{
    /// <summary>
    /// The audio format of the output.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateSpeechRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Wav,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestResponseFormat value)
        {
            return value switch
            {
                CreateSpeechRequestResponseFormat.Mp3 => "mp3",
                CreateSpeechRequestResponseFormat.Wav => "wav",
                CreateSpeechRequestResponseFormat.Opus => "opus",
                CreateSpeechRequestResponseFormat.Flac => "flac",
                CreateSpeechRequestResponseFormat.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateSpeechRequestResponseFormat.Mp3,
                "wav" => CreateSpeechRequestResponseFormat.Wav,
                "opus" => CreateSpeechRequestResponseFormat.Opus,
                "flac" => CreateSpeechRequestResponseFormat.Flac,
                "pcm" => CreateSpeechRequestResponseFormat.Pcm,
                _ => null,
            };
        }
    }
}