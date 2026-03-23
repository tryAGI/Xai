
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
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
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
                BatchRequestMetadataState.Cancelled => "cancelled",
                BatchRequestMetadataState.Failed => "failed",
                BatchRequestMetadataState.Pending => "pending",
                BatchRequestMetadataState.Succeeded => "succeeded",
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
                "cancelled" => BatchRequestMetadataState.Cancelled,
                "failed" => BatchRequestMetadataState.Failed,
                "pending" => BatchRequestMetadataState.Pending,
                "succeeded" => BatchRequestMetadataState.Succeeded,
                _ => null,
            };
        }
    }
}