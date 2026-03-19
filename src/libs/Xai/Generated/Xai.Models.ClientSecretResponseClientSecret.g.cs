
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSecretResponseClientSecret
    {
        /// <summary>
        /// The ephemeral token value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Unix timestamp when the token expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Xai.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSecretResponseClientSecret" /> class.
        /// </summary>
        /// <param name="value">
        /// The ephemeral token value.
        /// </param>
        /// <param name="expiresAt">
        /// Unix timestamp when the token expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSecretResponseClientSecret(
            string? value,
            global::System.DateTimeOffset? expiresAt)
        {
            this.Value = value;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSecretResponseClientSecret" /> class.
        /// </summary>
        public ClientSecretResponseClientSecret()
        {
        }
    }
}