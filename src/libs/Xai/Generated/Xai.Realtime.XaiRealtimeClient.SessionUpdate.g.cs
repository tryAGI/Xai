
#nullable enable

namespace Xai.Realtime
{
    public sealed partial class XaiRealtimeClient
    {
        /// <summary>
        /// Update session configuration (voice, instructions, tools, audio format, turn detection).
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendSessionUpdateAsync(
            global::Xai.Realtime.SessionUpdatePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Xai.Realtime.SessionUpdatePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}