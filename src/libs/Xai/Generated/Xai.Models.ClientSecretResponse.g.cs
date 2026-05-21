
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSecretResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public global::Xai.ClientSecretResponseClientSecret? ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSecretResponse" /> class.
        /// </summary>
        /// <param name="clientSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSecretResponse(
            global::Xai.ClientSecretResponseClientSecret? clientSecret)
        {
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSecretResponse" /> class.
        /// </summary>
        public ClientSecretResponse()
        {
        }

    }
}