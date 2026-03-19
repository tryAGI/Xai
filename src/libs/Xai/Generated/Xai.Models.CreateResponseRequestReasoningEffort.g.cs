
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateResponseRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseRequestReasoningEffort value)
        {
            return value switch
            {
                CreateResponseRequestReasoningEffort.Low => "low",
                CreateResponseRequestReasoningEffort.Medium => "medium",
                CreateResponseRequestReasoningEffort.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "low" => CreateResponseRequestReasoningEffort.Low,
                "medium" => CreateResponseRequestReasoningEffort.Medium,
                "high" => CreateResponseRequestReasoningEffort.High,
                _ => null,
            };
        }
    }
}