
#nullable enable

namespace Polar
{
    /// <summary>
    /// Hourly data for the alertness period
    /// </summary>
    public sealed partial class AlertnessHourlyData
    {
        /// <summary>
        /// Validity<br/>
        /// Example: VALIDITY_ESTIMATE
        /// </summary>
        /// <example>VALIDITY_ESTIMATE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AlertnessHourlyDataValidityJsonConverter))]
        public global::Polar.AlertnessHourlyDataValidity? Validity { get; set; }

        /// <summary>
        /// Alertness level<br/>
        /// Example: ALERTNESS_LEVEL_VERY_HIGH
        /// </summary>
        /// <example>ALERTNESS_LEVEL_VERY_HIGH</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertness_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AlertnessHourlyDataAlertnessLevelJsonConverter))]
        public global::Polar.AlertnessHourlyDataAlertnessLevel? AlertnessLevel { get; set; }

        /// <summary>
        /// Alertness period start time (UTC)<br/>
        /// Example: 2022-11-21T04:00:00
        /// </summary>
        /// <example>2022-11-21T04:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Alertness period end time (UTC)<br/>
        /// Example: 2022-11-21T05:00:00
        /// </summary>
        /// <example>2022-11-21T05:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertnessHourlyData" /> class.
        /// </summary>
        /// <param name="validity">
        /// Validity<br/>
        /// Example: VALIDITY_ESTIMATE
        /// </param>
        /// <param name="alertnessLevel">
        /// Alertness level<br/>
        /// Example: ALERTNESS_LEVEL_VERY_HIGH
        /// </param>
        /// <param name="startTime">
        /// Alertness period start time (UTC)<br/>
        /// Example: 2022-11-21T04:00:00
        /// </param>
        /// <param name="endTime">
        /// Alertness period end time (UTC)<br/>
        /// Example: 2022-11-21T05:00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertnessHourlyData(
            global::Polar.AlertnessHourlyDataValidity? validity,
            global::Polar.AlertnessHourlyDataAlertnessLevel? alertnessLevel,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime)
        {
            this.Validity = validity;
            this.AlertnessLevel = alertnessLevel;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertnessHourlyData" /> class.
        /// </summary>
        public AlertnessHourlyData()
        {
        }
    }
}