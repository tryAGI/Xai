
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
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Opus,
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
    public static class CreateSpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestResponseFormat value)
        {
            return value switch
            {
                CreateSpeechRequestResponseFormat.Flac => "flac",
                CreateSpeechRequestResponseFormat.Mp3 => "mp3",
                CreateSpeechRequestResponseFormat.Opus => "opus",
                CreateSpeechRequestResponseFormat.Pcm => "pcm",
                CreateSpeechRequestResponseFormat.Wav => "wav",
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
                "flac" => CreateSpeechRequestResponseFormat.Flac,
                "mp3" => CreateSpeechRequestResponseFormat.Mp3,
                "opus" => CreateSpeechRequestResponseFormat.Opus,
                "pcm" => CreateSpeechRequestResponseFormat.Pcm,
                "wav" => CreateSpeechRequestResponseFormat.Wav,
                _ => null,
            };
        }
    }
}