
#nullable enable

namespace Xai
{
    /// <summary>
    /// Current status of the video generation.
    /// </summary>
    public enum VideoStatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoStatusResponseStatus value)
        {
            return value switch
            {
                VideoStatusResponseStatus.Pending => "pending",
                VideoStatusResponseStatus.Done => "done",
                VideoStatusResponseStatus.Expired => "expired",
                VideoStatusResponseStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => VideoStatusResponseStatus.Pending,
                "done" => VideoStatusResponseStatus.Done,
                "expired" => VideoStatusResponseStatus.Expired,
                "failed" => VideoStatusResponseStatus.Failed,
                _ => null,
            };
        }
    }
}