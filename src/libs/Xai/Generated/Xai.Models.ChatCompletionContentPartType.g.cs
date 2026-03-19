
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionContentPartType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartType value)
        {
            return value switch
            {
                ChatCompletionContentPartType.Text => "text",
                ChatCompletionContentPartType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionContentPartType.Text,
                "image_url" => ChatCompletionContentPartType.ImageUrl,
                _ => null,
            };
        }
    }
}