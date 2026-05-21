
#nullable enable

namespace Xai.Realtime
{
    /// <summary>
    /// An error occurred.
    /// </summary>
    public sealed partial class ErrorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.Realtime.JsonConverters.ErrorEventTypeJsonConverter))]
        public global::Xai.Realtime.ErrorEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Error details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Xai.Realtime.RealtimeError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="error">
        /// Error details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorEvent(
            global::Xai.Realtime.ErrorEventType? type,
            string? eventId,
            global::Xai.Realtime.RealtimeError? error)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        public ErrorEvent()
        {
        }

    }
}