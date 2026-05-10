
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechOutputFormat
    {
        /// <summary>
        /// Audio codec for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.TextToSpeechOutputFormatCodecJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Xai.TextToSpeechOutputFormatCodec Codec { get; set; }

        /// <summary>
        /// Sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Bit rate in bps. Applies to MP3 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_rate")]
        public int? BitRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechOutputFormat" /> class.
        /// </summary>
        /// <param name="codec">
        /// Audio codec for the output.
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate in Hz.
        /// </param>
        /// <param name="bitRate">
        /// Bit rate in bps. Applies to MP3 only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechOutputFormat(
            global::Xai.TextToSpeechOutputFormatCodec codec,
            int? sampleRate,
            int? bitRate)
        {
            this.Codec = codec;
            this.SampleRate = sampleRate;
            this.BitRate = bitRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechOutputFormat" /> class.
        /// </summary>
        public TextToSpeechOutputFormat()
        {
        }

    }
}