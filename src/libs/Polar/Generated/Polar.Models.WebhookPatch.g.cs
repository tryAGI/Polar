
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPatch
    {
        /// <summary>
        /// Type of events to subscribe.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPatch" /> class.
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
        public WebhookPatch(
            global::System.Collections.Generic.IList<global::Polar.WebhookType>? events,
            string? url)
        {
            this.Events = events;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPatch" /> class.
        /// </summary>
        public WebhookPatch()
        {
        }
    }
}