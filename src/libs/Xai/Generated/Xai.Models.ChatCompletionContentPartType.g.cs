
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
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
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
                ChatCompletionContentPartType.ImageUrl => "image_url",
                ChatCompletionContentPartType.Text => "text",
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
                "image_url" => ChatCompletionContentPartType.ImageUrl,
                "text" => ChatCompletionContentPartType.Text,
                _ => null,
            };
        }
    }
}