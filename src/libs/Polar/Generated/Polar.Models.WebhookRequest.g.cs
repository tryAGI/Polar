
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRequest
    {
        /// <summary>
        /// Type of events to subscribe.<br/>
        /// Example: [EXERCISE]
        /// </summary>
        /// <example>[EXERCISE]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Polar.WebhookType> Events { get; set; }

        /// <summary>
        /// Url where the webhook notification is sent.<br/>
        /// Example: https://myapp.example.com/acl_webhook
        /// </summary>
        /// <example>https://myapp.example.com/acl_webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRequest" /> class.
        /// </summary>
        /// <param name="events">
        /// Type of events to subscribe.<br/>
        /// Example: [EXERCISE]
        /// </param>
        /// <param name="url">
        /// Url where the webhook notification is sent.<br/>
        /// Example: https://myapp.example.com/acl_webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRequest(
            global::System.Collections.Generic.IList<global::Polar.WebhookType> events,
            string url)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRequest" /> class.
        /// </summary>
        public WebhookRequest()
        {
        }
    }
}