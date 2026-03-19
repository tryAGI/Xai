
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchRequestMetadataState
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchRequestMetadataStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchRequestMetadataState value)
        {
            return value switch
            {
                BatchRequestMetadataState.Pending => "pending",
                BatchRequestMetadataState.Succeeded => "succeeded",
                BatchRequestMetadataState.Failed => "failed",
                BatchRequestMetadataState.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchRequestMetadataState? ToEnum(string value)
        {
            return value switch
            {
                "pending" => BatchRequestMetadataState.Pending,
                "succeeded" => BatchRequestMetadataState.Succeeded,
                "failed" => BatchRequestMetadataState.Failed,
                "cancelled" => BatchRequestMetadataState.Cancelled,
                _ => null,
            };
        }
    }
}