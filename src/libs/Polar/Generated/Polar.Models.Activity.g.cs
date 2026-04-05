
#nullable enable

namespace Polar
{
    /// <summary>
    /// Summary of user's daily activity
    /// </summary>
    public sealed partial class Activity
    {
        /// <summary>
        /// Activity summary id<br/>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Absolute link to user owning the activity<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </summary>
        /// <example>https://www.polaraccesslink/v3/users/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("polar-user")]
        public string? PolarUser { get; set; }

        /// <summary>
        /// Id of the activity-transaction this training was transferred in<br/>
        /// Example: 179879
        /// </summary>
        /// <example>179879</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction-id")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Date when activity summary was recorded, in format YYYY-MM-DD<br/>
        /// Example: 2010-12-31
        /// </summary>
        /// <example>2010-12-31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// The time activity summary was created in AccessLink, in format YYYY-MM-DDTHH:mm:ss.SSS<br/>
        /// Example: 2016-04-27T20:11:33.000Z
        /// </summary>
        /// <example>2016-04-27T20:11:33.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Total daily calories in kilo calories including BMR<br/>
        /// Example: 2329
        /// </summary>
        /// <example>2329</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public int? Calories { get; set; }

        /// <summary>
        /// Total daily calories not including BMR. Precise calculation requires that user's physical data is entered into Polar Flow<br/>
        /// Example: 428
        /// </summary>
        /// <example>428</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active-calories")]
        public int? ActiveCalories { get; set; }

        /// <summary>
        /// The time interval as specified in ISO 8601<br/>
        /// Example: PT2H44M
        /// </summary>
        /// <example>PT2H44M</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// You could consider this as a kind of activity unit. If you take one step the active-steps should increase by one and any activity comparable to one physical step would also increase the number by one<br/>
        /// Example: 250
        /// </summary>
        /// <example>250</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active-steps")]
        public int? ActiveSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="id">
        /// Activity summary id<br/>
        /// Example: 1234
        /// </param>
        /// <param name="polarUser">
        /// Absolute link to user owning the activity<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </param>
        /// <param name="transactionId">
        /// Id of the activity-transaction this training was transferred in<br/>
        /// Example: 179879
        /// </param>
        /// <param name="date">
        /// Date when activity summary was recorded, in format YYYY-MM-DD<br/>
        /// Example: 2010-12-31
        /// </param>
        /// <param name="created">
        /// The time activity summary was created in AccessLink, in format YYYY-MM-DDTHH:mm:ss.SSS<br/>
        /// Example: 2016-04-27T20:11:33.000Z
        /// </param>
        /// <param name="calories">
        /// Total daily calories in kilo calories including BMR<br/>
        /// Example: 2329
        /// </param>
        /// <param name="activeCalories">
        /// Total daily calories not including BMR. Precise calculation requires that user's physical data is entered into Polar Flow<br/>
        /// Example: 428
        /// </param>
        /// <param name="duration">
        /// The time interval as specified in ISO 8601<br/>
        /// Example: PT2H44M
        /// </param>
        /// <param name="activeSteps">
        /// You could consider this as a kind of activity unit. If you take one step the active-steps should increase by one and any activity comparable to one physical step would also increase the number by one<br/>
        /// Example: 250
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Activity(
            long? id,
            string? polarUser,
            long? transactionId,
            string? date,
            string? created,
            int? calories,
            int? activeCalories,
            string? duration,
            int? activeSteps)
        {
            this.Id = id;
            this.PolarUser = polarUser;
            this.TransactionId = transactionId;
            this.Date = date;
            this.Created = created;
            this.Calories = calories;
            this.ActiveCalories = activeCalories;
            this.Duration = duration;
            this.ActiveSteps = activeSteps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        public Activity()
        {
        }
    }
}