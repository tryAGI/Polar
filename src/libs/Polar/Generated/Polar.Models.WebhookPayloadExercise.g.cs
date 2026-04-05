
#nullable enable

namespace Polar
{
    /// <summary>
    /// Payload example for webhook payload for event type EXERCISE
    /// </summary>
    public sealed partial class WebhookPayloadExercise
    {
        /// <summary>
        /// Type of available data.<br/>
        /// Example: EXERCISE
        /// </summary>
        /// <example>EXERCISE</example>
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
        /// Id of the available data.<br/>
        /// Example: aQlC83
        /// </summary>
        /// <example>aQlC83</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// Time when webhook notification is sent.<br/>
        /// Example: 2018-05-15T14:22:24Z
        /// </summary>
        /// <example>2018-05-15T14:22:24Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Url to the new available data.<br/>
        /// Example: https://www.polaraccesslink.com/v3/exercises/aQlC83
        /// </summary>
        /// <example>https://www.polaraccesslink.com/v3/exercises/aQlC83</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPayloadExercise" /> class.
        /// </summary>
        /// <param name="event">
        /// Type of available data.<br/>
        /// Example: EXERCISE
        /// </param>
        /// <param name="userId">
        /// Id of the user who has new data.<br/>
        /// Example: 475
        /// </param>
        /// <param name="entityId">
        /// Id of the available data.<br/>
        /// Example: aQlC83
        /// </param>
        /// <param name="timestamp">
        /// Time when webhook notification is sent.<br/>
        /// Example: 2018-05-15T14:22:24Z
        /// </param>
        /// <param name="url">
        /// Url to the new available data.<br/>
        /// Example: https://www.polaraccesslink.com/v3/exercises/aQlC83
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPayloadExercise(
            string? @event,
            long? userId,
            string? entityId,
            global::System.DateTime? timestamp,
            string? url)
        {
            this.Event = @event;
            this.UserId = userId;
            this.EntityId = entityId;
            this.Timestamp = timestamp;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPayloadExercise" /> class.
        /// </summary>
        public WebhookPayloadExercise()
        {
        }
    }
}