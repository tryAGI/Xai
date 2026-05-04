
#nullable enable

namespace Xai.TextToSpeech
{
    public sealed partial class XaiTextToSpeechStreamingClient
    {
        /// <summary>
        /// Send a chunk of text to synthesize.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendTextDeltaAsync(
            global::Xai.TextToSpeech.TextDeltaPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Xai.TextToSpeech.TextDeltaPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}