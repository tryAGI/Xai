
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_requests")]
        public int? NumRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pending")]
        public int? NumPending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_success")]
        public int? NumSuccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_error")]
        public int? NumError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_cancelled")]
        public int? NumCancelled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchState" /> class.
        /// </summary>
        /// <param name="numRequests"></param>
        /// <param name="numPending"></param>
        /// <param name="numSuccess"></param>
        /// <param name="numError"></param>
        /// <param name="numCancelled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchState(
            int? numRequests,
            int? numPending,
            int? numSuccess,
            int? numError,
            int? numCancelled)
        {
            this.NumRequests = numRequests;
            this.NumPending = numPending;
            this.NumSuccess = numSuccess;
            this.NumError = numError;
            this.NumCancelled = numCancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchState" /> class.
        /// </summary>
        public BatchState()
        {
        }

    }
}