
#nullable enable

namespace Xai
{
    /// <summary>
    /// Default Value: url
    /// </summary>
    public enum CreateImageEditRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        B64Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestResponseFormat value)
        {
            return value switch
            {
                CreateImageEditRequestResponseFormat.Url => "url",
                CreateImageEditRequestResponseFormat.B64Json => "b64_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => CreateImageEditRequestResponseFormat.Url,
                "b64_json" => CreateImageEditRequestResponseFormat.B64Json,
                _ => null,
            };
        }
    }
}