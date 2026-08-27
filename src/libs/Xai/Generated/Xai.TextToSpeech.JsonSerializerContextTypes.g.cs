
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Xai.TextToSpeech
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.TextDeltaPayload? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.TextDeltaPayloadType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.TextDonePayload? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.TextDonePayloadType? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.AudioDeltaEvent? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.AudioDeltaEventType? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.AudioDoneEvent? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.AudioDoneEventType? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.ErrorEvent? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.ErrorEventType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.ServerEvent? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.ServerEventDiscriminator? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Xai.TextToSpeech.ServerEventDiscriminatorType? Type13 { get; set; }

    }
}