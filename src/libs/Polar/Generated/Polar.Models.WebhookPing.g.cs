
#nullable enable

namespace Polar
{
    /// <summary>
    /// AccessLink sends ping message as HTTP POST to callback URL being registered when creating new or modifying webhook. Ping message is sent to verify webhook URL. Receiving service must response to ping message with 200 OK or the webhook is not created/modified.
    /// </summary>
    public sealed partial class WebhookPing
    {
        /// <summary>
        /// Time when webhook ping is sent.<br/>
        /// Example: 2018-05-15T14:22:24Z
        /// </summary>
        /// <example>2018-05-15T14:22:24Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Only possible value is PING for ping message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.WebhookPingEventJsonConverter))]
        public global::Polar.WebhookPingEvent? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPing" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time when webhook ping is sent.<br/>
        /// Example: 2018-05-15T14:22:24Z
        /// </param>
        /// <param name="event">
        /// Only possible value is PING for ping message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPing(
            global::System.DateTime? timestamp,
            global::Polar.WebhookPingEvent? @event)
        {
            this.Timestamp = timestamp;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPing" /> class.
        /// </summary>
        public WebhookPing()
        {
        }
    }
}