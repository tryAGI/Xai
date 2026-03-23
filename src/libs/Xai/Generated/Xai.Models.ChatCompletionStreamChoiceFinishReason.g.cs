
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionStreamChoiceFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionStreamChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionStreamChoiceFinishReason value)
        {
            return value switch
            {
                ChatCompletionStreamChoiceFinishReason.ContentFilter => "content_filter",
                ChatCompletionStreamChoiceFinishReason.Length => "length",
                ChatCompletionStreamChoiceFinishReason.Stop => "stop",
                ChatCompletionStreamChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionStreamChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChatCompletionStreamChoiceFinishReason.ContentFilter,
                "length" => ChatCompletionStreamChoiceFinishReason.Length,
                "stop" => ChatCompletionStreamChoiceFinishReason.Stop,
                "tool_calls" => ChatCompletionStreamChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}