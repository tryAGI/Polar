
#nullable enable

namespace Polar
{
    /// <summary>
    /// Payload example for webhook payload for event type ACTIVITY_SUMMARY
    /// </summary>
    public sealed partial class WebhookPayloadActivitySummary
    {
        /// <summary>
        /// Type of available data.<br/>
        /// Example: ACTIVITY_SUMMARY
        /// </summary>
        /// <example>ACTIVITY_SUMMARY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// Id of the user who has new data.<br/>
        /// Example: 475
        /// </summary>
        /// <example>475</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// Date of the available activity summary data.<br/>
        /// Example: 2022-09-31
        /// </summary>
        /// <example>2022-09-31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Time when webhook notification is sent.<br/>
        /// Example: 2022-10-02T14:22:24Z
        /// </summary>
        /// <example>2022-10-02T14:22:24Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Url to the new available data.<br/>
        /// Example: https://www.polaraccesslink.com/v3/users/activities/2022-09-31
        /// </summary>
        /// <example>https://www.polaraccesslink.com/v3/users/activities/2022-09-31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPayloadActivitySummary" /> class.
        /// </summary>
        /// <param name="event">
        /// Type of available data.<br/>
        /// Example: ACTIVITY_SUMMARY
        /// </param>
        /// <param name="userId">
        /// Id of the user who has new data.<br/>
        /// Example: 475
        /// </param>
        /// <param name="date">
        /// Date of the available activity summary data.<br/>
        /// Example: 2022-09-31
        /// </param>
        /// <param name="timestamp">
        /// Time when webhook notification is sent.<br/>
        /// Example: 2022-10-02T14:22:24Z
        /// </param>
        /// <param name="url">
        /// Url to the new available data.<br/>
        /// Example: https://www.polaraccesslink.com/v3/users/activities/2022-09-31
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPayloadActivitySummary(
            string? @event,
            long? userId,
            string? date,
            global::System.DateTime? timestamp,
            string? url)
        {
            this.Event = @event;
            this.UserId = userId;
            this.Date = date;
            this.Timestamp = timestamp;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPayloadActivitySummary" /> class.
        /// </summary>
        public WebhookPayloadActivitySummary()
        {
        }
    }
}