
#nullable enable

namespace Xai
{
    /// <summary>
    /// Tonal label.
    /// </summary>
    public enum CreateCustomVoiceRequestTone
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
    public static class CreateCustomVoiceRequestToneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomVoiceRequestTone value)
        {
            return value switch
            {
                CreateCustomVoiceRequestTone.Authoritative => "authoritative",
                CreateCustomVoiceRequestTone.Calm => "calm",
                CreateCustomVoiceRequestTone.Casual => "casual",
                CreateCustomVoiceRequestTone.Expressive => "expressive",
                CreateCustomVoiceRequestTone.Friendly => "friendly",
                CreateCustomVoiceRequestTone.Professional => "professional",
                CreateCustomVoiceRequestTone.Warm => "warm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomVoiceRequestTone? ToEnum(string value)
        {
            return value switch
            {
                "authoritative" => CreateCustomVoiceRequestTone.Authoritative,
                "calm" => CreateCustomVoiceRequestTone.Calm,
                "casual" => CreateCustomVoiceRequestTone.Casual,
                "expressive" => CreateCustomVoiceRequestTone.Expressive,
                "friendly" => CreateCustomVoiceRequestTone.Friendly,
                "professional" => CreateCustomVoiceRequestTone.Professional,
                "warm" => CreateCustomVoiceRequestTone.Warm,
                _ => null,
            };
        }
    }
}