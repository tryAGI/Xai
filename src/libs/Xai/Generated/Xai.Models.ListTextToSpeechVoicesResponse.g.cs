
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTextToSpeechVoicesResponse
    {
        /// <summary>
        /// List of available built-in TTS voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Xai.TextToSpeechVoice> Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTextToSpeechVoicesResponse" /> class.
        /// </summary>
        /// <param name="voices">
        /// List of available built-in TTS voices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTextToSpeechVoicesResponse(
            global::System.Collections.Generic.IList<global::Xai.TextToSpeechVoice> voices)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTextToSpeechVoicesResponse" /> class.
        /// </summary>
        public ListTextToSpeechVoicesResponse()
        {
        }
    }
}