
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputMessageRole value)
        {
            return value switch
            {
                ResponseInputMessageRole.Assistant => "assistant",
                ResponseInputMessageRole.System => "system",
                ResponseInputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ResponseInputMessageRole.Assistant,
                "system" => ResponseInputMessageRole.System,
                "user" => ResponseInputMessageRole.User,
                _ => null,
            };
        }
    }
}