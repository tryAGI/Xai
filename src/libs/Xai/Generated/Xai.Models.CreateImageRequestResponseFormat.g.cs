
#nullable enable

namespace Xai
{
    /// <summary>
    /// The format of the generated image.<br/>
    /// Default Value: url
    /// </summary>
    public enum CreateImageRequestResponseFormat
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
    public static class CreateImageRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestResponseFormat value)
        {
            return value switch
            {
                CreateImageRequestResponseFormat.Url => "url",
                CreateImageRequestResponseFormat.B64Json => "b64_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => CreateImageRequestResponseFormat.Url,
                "b64_json" => CreateImageRequestResponseFormat.B64Json,
                _ => null,
            };
        }
    }
}