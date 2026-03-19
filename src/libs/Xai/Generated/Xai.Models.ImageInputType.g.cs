
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageInputType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageInputType value)
        {
            return value switch
            {
                ImageInputType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageInputType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ImageInputType.ImageUrl,
                _ => null,
            };
        }
    }
}