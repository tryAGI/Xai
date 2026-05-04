
#nullable enable

namespace Xai.TextToSpeech
{
    public sealed partial class AudioDeltaEvent
    {
        /// <summary>
        /// Gets the decoded bytes for <see cref="Delta" />.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonIgnore]
        public global::System.ReadOnlyMemory<byte> DeltaBytes => Delta is null
            ? default
            : global::System.Convert.FromBase64String(Delta);
    }
}