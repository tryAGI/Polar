
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInfoDataItem
    {
        /// <summary>
        /// Id of the webhook.<br/>
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
        /// Is the webhook active.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInfoDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the webhook.<br/>
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
        /// <param name="active">
        /// Is the webhook active.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookInfoDataItem(
            string? id,
            global::System.Collections.Generic.IList<global::Polar.WebhookType>? events,
            string? url,
            bool? active)
        {
            this.Id = id;
            this.Events = events;
            this.Url = url;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInfoDataItem" /> class.
        /// </summary>
        public WebhookInfoDataItem()
        {
        }
    }
}