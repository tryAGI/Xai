
#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// Add a conversation item.
    /// </summary>
    public sealed partial class ConversationItemCreatePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.Realtime.JsonConverters.ConversationItemCreatePayloadTypeJsonConverter))]
        public global::Xai.Realtime.ConversationItemCreatePayloadType Type { get; set; }

        /// <summary>
        /// Optional event ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// A conversation item (message or function output).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Xai.Realtime.ConversationItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatePayload" /> class.
        /// </summary>
        /// <param name="item">
        /// A conversation item (message or function output).
        /// </param>
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional event ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationItemCreatePayload(
            global::Xai.Realtime.ConversationItem item,
            global::Xai.Realtime.ConversationItemCreatePayloadType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatePayload" /> class.
        /// </summary>
        public ConversationItemCreatePayload()
        {
        }
    }
}