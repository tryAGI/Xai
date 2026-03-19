
#nullable enable

namespace Xai
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_api_key")]
        public string? RedactedApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acls")]
        public global::System.Collections.Generic.IList<string>? Acls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="redactedApiKey"></param>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="createTime"></param>
        /// <param name="modifyTime"></param>
        /// <param name="acls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyInfo(
            string? name,
            string? redactedApiKey,
            string? userId,
            string? teamId,
            string? createTime,
            string? modifyTime,
            global::System.Collections.Generic.IList<string>? acls)
        {
            this.Name = name;
            this.RedactedApiKey = redactedApiKey;
            this.UserId = userId;
            this.TeamId = teamId;
            this.CreateTime = createTime;
            this.ModifyTime = modifyTime;
            this.Acls = acls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfo" /> class.
        /// </summary>
        public ApiKeyInfo()
        {
        }
    }
}