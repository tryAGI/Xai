
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageRole value)
        {
            return value switch
            {
                ChatCompletionMessageRole.System => "system",
                ChatCompletionMessageRole.User => "user",
                ChatCompletionMessageRole.Assistant => "assistant",
                ChatCompletionMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionMessageRole.System,
                "user" => ChatCompletionMessageRole.User,
                "assistant" => ChatCompletionMessageRole.Assistant,
                "tool" => ChatCompletionMessageRole.Tool,
                _ => null,
            };
        }
    }
}