
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageEditRequestResolution
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
    public static class CreateImageEditRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestResolution value)
        {
            return value switch
            {
                CreateImageEditRequestResolution.x1k => "1k",
                CreateImageEditRequestResolution.x2k => "2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => CreateImageEditRequestResolution.x1k,
                "2k" => CreateImageEditRequestResolution.x2k,
                _ => null,
            };
        }
    }
}