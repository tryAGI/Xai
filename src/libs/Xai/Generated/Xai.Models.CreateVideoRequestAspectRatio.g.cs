
#nullable enable

namespace Xai
{
    /// <summary>
    /// Aspect ratio of the generated video. Defaults to 16:9.
    /// </summary>
    public enum CreateVideoRequestAspectRatio
    {
        /// <summary>
        /// 9.
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestAspectRatio value)
        {
            return value switch
            {
                CreateVideoRequestAspectRatio.x16_9 => "16:9",
                CreateVideoRequestAspectRatio.x1_1 => "1:1",
                CreateVideoRequestAspectRatio.x2_3 => "2:3",
                CreateVideoRequestAspectRatio.x3_2 => "3:2",
                CreateVideoRequestAspectRatio.x3_4 => "3:4",
                CreateVideoRequestAspectRatio.x4_3 => "4:3",
                CreateVideoRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateVideoRequestAspectRatio.x16_9,
                "1:1" => CreateVideoRequestAspectRatio.x1_1,
                "2:3" => CreateVideoRequestAspectRatio.x2_3,
                "3:2" => CreateVideoRequestAspectRatio.x3_2,
                "3:4" => CreateVideoRequestAspectRatio.x3_4,
                "4:3" => CreateVideoRequestAspectRatio.x4_3,
                "9:16" => CreateVideoRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}