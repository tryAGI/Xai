
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionContentPartImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartImageUrlDetail value)
        {
            return value switch
            {
                ChatCompletionContentPartImageUrlDetail.Auto => "auto",
                ChatCompletionContentPartImageUrlDetail.High => "high",
                ChatCompletionContentPartImageUrlDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionContentPartImageUrlDetail.Auto,
                "high" => ChatCompletionContentPartImageUrlDetail.High,
                "low" => ChatCompletionContentPartImageUrlDetail.Low,
                _ => null,
            };
        }
    }
}