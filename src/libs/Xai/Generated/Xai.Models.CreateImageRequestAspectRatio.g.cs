
#nullable enable

namespace Xai
{
    /// <summary>
    /// Aspect ratio of the generated image.
    /// </summary>
    public enum CreateImageRequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x2_1,
        /// <summary>
        /// 
        /// </summary>
        x1_2,
        /// <summary>
        /// 
        /// </summary>
        x195_9,
        /// <summary>
        /// 
        /// </summary>
        x9_195,
        /// <summary>
        /// 
        /// </summary>
        x20_9,
        /// <summary>
        /// 
        /// </summary>
        x9_20,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestAspectRatio value)
        {
            return value switch
            {
                CreateImageRequestAspectRatio.x1_1 => "1:1",
                CreateImageRequestAspectRatio.x16_9 => "16:9",
                CreateImageRequestAspectRatio.x9_16 => "9:16",
                CreateImageRequestAspectRatio.x4_3 => "4:3",
                CreateImageRequestAspectRatio.x3_4 => "3:4",
                CreateImageRequestAspectRatio.x3_2 => "3:2",
                CreateImageRequestAspectRatio.x2_3 => "2:3",
                CreateImageRequestAspectRatio.x2_1 => "2:1",
                CreateImageRequestAspectRatio.x1_2 => "1:2",
                CreateImageRequestAspectRatio.x195_9 => "19.5:9",
                CreateImageRequestAspectRatio.x9_195 => "9:19.5",
                CreateImageRequestAspectRatio.x20_9 => "20:9",
                CreateImageRequestAspectRatio.x9_20 => "9:20",
                CreateImageRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "1:1" => CreateImageRequestAspectRatio.x1_1,
                "16:9" => CreateImageRequestAspectRatio.x16_9,
                "9:16" => CreateImageRequestAspectRatio.x9_16,
                "4:3" => CreateImageRequestAspectRatio.x4_3,
                "3:4" => CreateImageRequestAspectRatio.x3_4,
                "3:2" => CreateImageRequestAspectRatio.x3_2,
                "2:3" => CreateImageRequestAspectRatio.x2_3,
                "2:1" => CreateImageRequestAspectRatio.x2_1,
                "1:2" => CreateImageRequestAspectRatio.x1_2,
                "19.5:9" => CreateImageRequestAspectRatio.x195_9,
                "9:19.5" => CreateImageRequestAspectRatio.x9_195,
                "20:9" => CreateImageRequestAspectRatio.x20_9,
                "9:20" => CreateImageRequestAspectRatio.x9_20,
                "auto" => CreateImageRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}