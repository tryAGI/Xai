
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchResultSuccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_request_id")]
        public string? BatchRequestId { get; set; }

        /// <summary>
        /// The response payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public object? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResultSuccess" /> class.
        /// </summary>
        /// <param name="batchRequestId"></param>
        /// <param name="response">
        /// The response payload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchResultSuccess(
            string? batchRequestId,
            object? response)
        {
            this.BatchRequestId = batchRequestId;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResultSuccess" /> class.
        /// </summary>
        public BatchResultSuccess()
        {
        }
    }
}