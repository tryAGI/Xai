
#nullable enable

namespace Xai
{
    /// <summary>
    /// Resolution of the generated video.<br/>
    /// Default Value: 480p
    /// </summary>
    public enum CreateVideoRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x480p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestResolution value)
        {
            return value switch
            {
                CreateVideoRequestResolution.x480p => "480p",
                CreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => CreateVideoRequestResolution.x480p,
                "720p" => CreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}