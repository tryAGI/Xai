
#nullable enable

namespace Xai
{
    /// <summary>
    /// Controls the amount of reasoning effort for reasoning models.
    /// </summary>
    public enum CreateChatCompletionRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestReasoningEffort value)
        {
            return value switch
            {
                CreateChatCompletionRequestReasoningEffort.High => "high",
                CreateChatCompletionRequestReasoningEffort.Low => "low",
                CreateChatCompletionRequestReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateChatCompletionRequestReasoningEffort.High,
                "low" => CreateChatCompletionRequestReasoningEffort.Low,
                "medium" => CreateChatCompletionRequestReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}