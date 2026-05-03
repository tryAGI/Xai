
#nullable enable

namespace Xai
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListCustomVoicesResponse
    {
        /// <summary>
        /// List of custom voices owned by the calling team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Xai.CustomVoice> Voices { get; set; }

        /// <summary>
        /// Opaque token to fetch the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_token")]
        public string? PaginationToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomVoicesResponse" /> class.
        /// </summary>
        /// <param name="voices">
        /// List of custom voices owned by the calling team.
        /// </param>
        /// <param name="paginationToken">
        /// Opaque token to fetch the next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCustomVoicesResponse(
            global::System.Collections.Generic.IList<global::Xai.CustomVoice> voices,
            string? paginationToken)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.PaginationToken = paginationToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomVoicesResponse" /> class.
        /// </summary>
        public ListCustomVoicesResponse()
        {
        }
    }
}