
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatedWebhookData
    {
        /// <summary>
        /// Id of the new webhook.<br/>
        /// Example: abdf33
        /// </summary>
        /// <example>abdf33</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Subscribed event types.<br/>
        /// Example: [EXERCISE]
        /// </summary>
        /// <example>[EXERCISE]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Polar.WebhookType>? Events { get; set; }

        /// <summary>
        /// Url where the webhook notification is sent.<br/>
        /// Example: https://myapp.example.com/acl_webhook
        /// </summary>
        /// <example>https://myapp.example.com/acl_webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Signing key for verifying that sender is actually Polar.<br/>
        /// Example: abe1f3ae-fd33-11e8-8eb2-f2801f1b9fd1
        /// </summary>
        /// <example>abe1f3ae-fd33-11e8-8eb2-f2801f1b9fd1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature_secret_key")]
        public string? SignatureSecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedWebhookData" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the new webhook.<br/>
        /// Example: abdf33
        /// </param>
        /// <param name="events">
        /// Subscribed event types.<br/>
        /// Example: [EXERCISE]
        /// </param>
        /// <param name="url">
        /// Url where the webhook notification is sent.<br/>
        /// Example: https://myapp.example.com/acl_webhook
        /// </param>
        /// <param name="signatureSecretKey">
        /// Signing key for verifying that sender is actually Polar.<br/>
        /// Example: abe1f3ae-fd33-11e8-8eb2-f2801f1b9fd1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatedWebhookData(
            string? id,
            global::System.Collections.Generic.IList<global::Polar.WebhookType>? events,
            string? url,
            string? signatureSecretKey)
        {
            this.Id = id;
            this.Events = events;
            this.Url = url;
            this.SignatureSecretKey = signatureSecretKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedWebhookData" /> class.
        /// </summary>
        public CreatedWebhookData()
        {
        }
    }
}