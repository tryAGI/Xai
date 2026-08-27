
#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// Reasoning effort for the selected speech-to-speech model. Reasoning defaults to high when omitted.
    /// </summary>
    public enum VoiceReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceReasoningEffort value)
        {
            return value switch
            {
                VoiceReasoningEffort.High => "high",
                VoiceReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => VoiceReasoningEffort.High,
                "none" => VoiceReasoningEffort.None,
                _ => null,
            };
        }
    }
}