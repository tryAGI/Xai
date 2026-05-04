
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCustomVoiceRequestTone
    {
        /// <summary>
        /// 
        /// </summary>
        Authoritative,
        /// <summary>
        /// 
        /// </summary>
        Calm,
        /// <summary>
        /// 
        /// </summary>
        Casual,
        /// <summary>
        /// 
        /// </summary>
        Expressive,
        /// <summary>
        /// 
        /// </summary>
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        Professional,
        /// <summary>
        /// 
        /// </summary>
        Warm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCustomVoiceRequestToneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomVoiceRequestTone value)
        {
            return value switch
            {
                UpdateCustomVoiceRequestTone.Authoritative => "authoritative",
                UpdateCustomVoiceRequestTone.Calm => "calm",
                UpdateCustomVoiceRequestTone.Casual => "casual",
                UpdateCustomVoiceRequestTone.Expressive => "expressive",
                UpdateCustomVoiceRequestTone.Friendly => "friendly",
                UpdateCustomVoiceRequestTone.Professional => "professional",
                UpdateCustomVoiceRequestTone.Warm => "warm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomVoiceRequestTone? ToEnum(string value)
        {
            return value switch
            {
                "authoritative" => UpdateCustomVoiceRequestTone.Authoritative,
                "calm" => UpdateCustomVoiceRequestTone.Calm,
                "casual" => UpdateCustomVoiceRequestTone.Casual,
                "expressive" => UpdateCustomVoiceRequestTone.Expressive,
                "friendly" => UpdateCustomVoiceRequestTone.Friendly,
                "professional" => UpdateCustomVoiceRequestTone.Professional,
                "warm" => UpdateCustomVoiceRequestTone.Warm,
                _ => null,
            };
        }
    }
}