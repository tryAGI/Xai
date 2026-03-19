
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionChoiceFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChoiceFinishReason value)
        {
            return value switch
            {
                ChatCompletionChoiceFinishReason.Stop => "stop",
                ChatCompletionChoiceFinishReason.Length => "length",
                ChatCompletionChoiceFinishReason.ToolCalls => "tool_calls",
                ChatCompletionChoiceFinishReason.ContentFilter => "content_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "stop" => ChatCompletionChoiceFinishReason.Stop,
                "length" => ChatCompletionChoiceFinishReason.Length,
                "tool_calls" => ChatCompletionChoiceFinishReason.ToolCalls,
                "content_filter" => ChatCompletionChoiceFinishReason.ContentFilter,
                _ => null,
            };
        }
    }
}