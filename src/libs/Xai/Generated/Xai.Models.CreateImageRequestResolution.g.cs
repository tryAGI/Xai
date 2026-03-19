
#nullable enable

namespace Xai
{
    /// <summary>
    /// Resolution of the generated image.
    /// </summary>
    public enum CreateImageRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestResolution value)
        {
            return value switch
            {
                CreateImageRequestResolution.x1k => "1k",
                CreateImageRequestResolution.x2k => "2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => CreateImageRequestResolution.x1k,
                "2k" => CreateImageRequestResolution.x2k,
                _ => null,
            };
        }
    }
}