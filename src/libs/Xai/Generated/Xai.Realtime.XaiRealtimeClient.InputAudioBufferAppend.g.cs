
#nullable enable

namespace Xai.Realtime
{
    public sealed partial class XaiRealtimeClient
    {
        /// <summary>
        /// Append base64-encoded audio data to the input buffer.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendInputAudioBufferAppendAsync(
            global::Xai.Realtime.InputAudioBufferAppendPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Xai.Realtime.InputAudioBufferAppendPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}