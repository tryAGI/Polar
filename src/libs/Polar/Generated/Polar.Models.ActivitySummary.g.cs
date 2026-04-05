
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivitySummary
    {
        /// <summary>
        /// Start time of the activity in UTC<br/>
        /// Example: 2025-08-13T08:15:30
        /// </summary>
        /// <example>2025-08-13T08:15:30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// End time of the activity in UTC<br/>
        /// Example: 2025-08-13T23:59:59
        /// </summary>
        /// <example>2025-08-13T23:59:59</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// The duration of the activity in ISO8601 format<br/>
        /// Example: PT3H11M
        /// </summary>
        /// <example>PT3H11M</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_duration")]
        public string? ActiveDuration { get; set; }

        /// <summary>
        /// The duration of the inactivity in ISO8601 format<br/>
        /// Example: PT18H23M30S
        /// </summary>
        /// <example>PT18H23M30S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactive_duration")]
        public string? InactiveDuration { get; set; }

        /// <summary>
        /// Daily activity score / percentage<br/>
        /// Example: 89.1
        /// </summary>
        /// <example>89.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_activity")]
        public float? DailyActivity { get; set; }

        /// <summary>
        /// Total calories burned during the day<br/>
        /// Example: 2500
        /// </summary>
        /// <example>2500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public int? Calories { get; set; }

        /// <summary>
        /// Active calories burned during the day, excluding BMR<br/>
        /// Example: 1500
        /// </summary>
        /// <example>1500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_calories")]
        public int? ActiveCalories { get; set; }

        /// <summary>
        /// Total number of steps taken during the day<br/>
        /// Example: 8823
        /// </summary>
        /// <example>8823</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Number of inactivity alerts received during the day<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_alert_count")]
        public int? InactivityAlertCount { get; set; }

        /// <summary>
        /// Distance covered based on steps taken, in meters<br/>
        /// Example: 4590.53
        /// </summary>
        /// <example>4590.53</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_from_steps")]
        public float? DistanceFromSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySummary" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start time of the activity in UTC<br/>
        /// Example: 2025-08-13T08:15:30
        /// </param>
        /// <param name="endTime">
        /// End time of the activity in UTC<br/>
        /// Example: 2025-08-13T23:59:59
        /// </param>
        /// <param name="activeDuration">
        /// The duration of the activity in ISO8601 format<br/>
        /// Example: PT3H11M
        /// </param>
        /// <param name="inactiveDuration">
        /// The duration of the inactivity in ISO8601 format<br/>
        /// Example: PT18H23M30S
        /// </param>
        /// <param name="dailyActivity">
        /// Daily activity score / percentage<br/>
        /// Example: 89.1
        /// </param>
        /// <param name="calories">
        /// Total calories burned during the day<br/>
        /// Example: 2500
        /// </param>
        /// <param name="activeCalories">
        /// Active calories burned during the day, excluding BMR<br/>
        /// Example: 1500
        /// </param>
        /// <param name="steps">
        /// Total number of steps taken during the day<br/>
        /// Example: 8823
        /// </param>
        /// <param name="inactivityAlertCount">
        /// Number of inactivity alerts received during the day<br/>
        /// Example: 1
        /// </param>
        /// <param name="distanceFromSteps">
        /// Distance covered based on steps taken, in meters<br/>
        /// Example: 4590.53
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivitySummary(
            string? startTime,
            string? endTime,
            string? activeDuration,
            string? inactiveDuration,
            float? dailyActivity,
            int? calories,
            int? activeCalories,
            int? steps,
            int? inactivityAlertCount,
            float? distanceFromSteps)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ActiveDuration = activeDuration;
            this.InactiveDuration = inactiveDuration;
            this.DailyActivity = dailyActivity;
            this.Calories = calories;
            this.ActiveCalories = activeCalories;
            this.Steps = steps;
            this.InactivityAlertCount = inactivityAlertCount;
            this.DistanceFromSteps = distanceFromSteps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySummary" /> class.
        /// </summary>
        public ActivitySummary()
        {
        }
    }
}