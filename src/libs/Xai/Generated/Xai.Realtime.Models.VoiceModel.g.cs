
#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// Speech-to-speech model selected during the WebSocket handshake. Use grok-voice-latest to follow xAI's recommended model or a versioned name for stability.
    /// </summary>
    public enum VoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        GrokVoiceLatest,
        /// <summary>
        /// 
        /// </summary>
        GrokVoiceThinkFast10,
        /// <summary>
        /// 
        /// </summary>
        GrokVoiceThinkFast20,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceModel value)
        {
            return value switch
            {
                VoiceModel.GrokVoiceLatest => "grok-voice-latest",
                VoiceModel.GrokVoiceThinkFast10 => "grok-voice-think-fast-1.0",
                VoiceModel.GrokVoiceThinkFast20 => "grok-voice-think-fast-2.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "grok-voice-latest" => VoiceModel.GrokVoiceLatest,
                "grok-voice-think-fast-1.0" => VoiceModel.GrokVoiceThinkFast10,
                "grok-voice-think-fast-2.0" => VoiceModel.GrokVoiceThinkFast20,
                _ => null,
            };
        }
    }
}