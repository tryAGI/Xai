
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseObjectStatus value)
        {
            return value switch
            {
                ResponseObjectStatus.Completed => "completed",
                ResponseObjectStatus.Failed => "failed",
                ResponseObjectStatus.InProgress => "in_progress",
                ResponseObjectStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseObjectStatus.Completed,
                "failed" => ResponseObjectStatus.Failed,
                "in_progress" => ResponseObjectStatus.InProgress,
                "cancelled" => ResponseObjectStatus.Cancelled,
                _ => null,
            };
        }
    }
}