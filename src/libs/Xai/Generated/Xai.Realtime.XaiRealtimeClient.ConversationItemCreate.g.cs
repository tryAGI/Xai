
#nullable enable

namespace Xai.Realtime
{
    public sealed partial class XaiRealtimeClient
    {
        /// <summary>
        /// Add a user message or function call output to the conversation.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendConversationItemCreateAsync(
            global::Xai.Realtime.ConversationItemCreatePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Xai.Realtime.ConversationItemCreatePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}