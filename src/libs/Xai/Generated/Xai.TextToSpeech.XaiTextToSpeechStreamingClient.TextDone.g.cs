
#nullable enable

namespace Xai.TextToSpeech
{
    public sealed partial class XaiTextToSpeechStreamingClient
    {
        /// <summary>
        /// Signal that the current utterance is complete.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendTextDoneAsync(
            global::Xai.TextToSpeech.TextDonePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Xai.TextToSpeech.TextDonePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}