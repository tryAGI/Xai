
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClientSecretRequestExpiresAfter
    {
        /// <summary>
        /// Number of seconds until the token expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public int? Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientSecretRequestExpiresAfter" /> class.
        /// </summary>
        /// <param name="seconds">
        /// Number of seconds until the token expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClientSecretRequestExpiresAfter(
            int? seconds)
        {
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientSecretRequestExpiresAfter" /> class.
        /// </summary>
        public CreateClientSecretRequestExpiresAfter()
        {
        }
    }
}