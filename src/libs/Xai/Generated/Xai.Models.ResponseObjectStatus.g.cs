
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
        Cancelled,
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
                ResponseObjectStatus.Cancelled => "cancelled",
                ResponseObjectStatus.Completed => "completed",
                ResponseObjectStatus.Failed => "failed",
                ResponseObjectStatus.InProgress => "in_progress",
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
                "cancelled" => ResponseObjectStatus.Cancelled,
                "completed" => ResponseObjectStatus.Completed,
                "failed" => ResponseObjectStatus.Failed,
                "in_progress" => ResponseObjectStatus.InProgress,
                _ => null,
            };
        }
    }
}