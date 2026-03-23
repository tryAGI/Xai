
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
        B64Json,
        /// <summary>
        /// 
        /// </summary>
        Url,
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
                CreateImageRequestResponseFormat.B64Json => "b64_json",
                CreateImageRequestResponseFormat.Url => "url",
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
                "b64_json" => CreateImageRequestResponseFormat.B64Json,
                "url" => CreateImageRequestResponseFormat.Url,
                _ => null,
            };
        }
    }
}