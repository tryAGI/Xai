
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
    public static class ChatCompletionStreamChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionStreamChoiceFinishReason value)
        {
            return value switch
            {
                ChatCompletionStreamChoiceFinishReason.Stop => "stop",
                ChatCompletionStreamChoiceFinishReason.Length => "length",
                ChatCompletionStreamChoiceFinishReason.ToolCalls => "tool_calls",
                ChatCompletionStreamChoiceFinishReason.ContentFilter => "content_filter",
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
                "stop" => ChatCompletionStreamChoiceFinishReason.Stop,
                "length" => ChatCompletionStreamChoiceFinishReason.Length,
                "tool_calls" => ChatCompletionStreamChoiceFinishReason.ToolCalls,
                "content_filter" => ChatCompletionStreamChoiceFinishReason.ContentFilter,
                _ => null,
            };
        }
    }
}