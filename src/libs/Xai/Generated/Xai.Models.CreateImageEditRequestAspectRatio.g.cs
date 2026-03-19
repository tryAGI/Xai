
#nullable enable

namespace Xai
{
    /// <summary>
    /// Aspect ratio override for the output.
    /// </summary>
    public enum CreateImageEditRequestAspectRatio
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
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestAspectRatio value)
        {
            return value switch
            {
                CreateImageEditRequestAspectRatio.x1_1 => "1:1",
                CreateImageEditRequestAspectRatio.x16_9 => "16:9",
                CreateImageEditRequestAspectRatio.x9_16 => "9:16",
                CreateImageEditRequestAspectRatio.x4_3 => "4:3",
                CreateImageEditRequestAspectRatio.x3_4 => "3:4",
                CreateImageEditRequestAspectRatio.x3_2 => "3:2",
                CreateImageEditRequestAspectRatio.x2_3 => "2:3",
                CreateImageEditRequestAspectRatio.x2_1 => "2:1",
                CreateImageEditRequestAspectRatio.x1_2 => "1:2",
                CreateImageEditRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "1:1" => CreateImageEditRequestAspectRatio.x1_1,
                "16:9" => CreateImageEditRequestAspectRatio.x16_9,
                "9:16" => CreateImageEditRequestAspectRatio.x9_16,
                "4:3" => CreateImageEditRequestAspectRatio.x4_3,
                "3:4" => CreateImageEditRequestAspectRatio.x3_4,
                "3:2" => CreateImageEditRequestAspectRatio.x3_2,
                "2:3" => CreateImageEditRequestAspectRatio.x2_3,
                "2:1" => CreateImageEditRequestAspectRatio.x2_1,
                "1:2" => CreateImageEditRequestAspectRatio.x1_2,
                "auto" => CreateImageEditRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}