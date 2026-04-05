
#nullable enable

namespace Polar
{
    /// <summary>
    /// Alertness period data<br/>
    /// Example: {"grade":9.9,"grade_validity_seconds":57600,"grade_type":"GRADE_TYPE_PRIMARY","grade_classification":"GRADE_CLASSIFICATION_STRONG","validity":"VALIDITY_ESTIMATE","sleep_inertia":"SLEEP_INERTIA_MILD","sleep_type":"SLEEP_TYPE_PRIMARY","result_type":"ALERTNESS_TYPE_HISTORY","period_start_time":"2022-11-20T20:52:20","period_end_time":"2022-11-21T19:15:52","sleep_period_start_time":"2022-11-20T20:52:20.57","sleep_period_end_time":"2022-11-21T04:11:20.57","sleep_timezone_offset_minutes":120,"hourly_data":[{"validity":"VALIDITY_ESTIMATE","alertness_level":"ALERTNESS_LEVEL_LOW","start_time":"2022-11-21T04:12:00","end_time":"2022-11-21T05:00:00"}]}
    /// </summary>
    public sealed partial class Alertness
    {
        /// <summary>
        /// Grade<br/>
        /// Example: 9.9
        /// </summary>
        /// <example>9.9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grade")]
        public double? Grade { get; set; }

        /// <summary>
        /// Grade validity seconds<br/>
        /// Example: 57600
        /// </summary>
        /// <example>57600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grade_validity_seconds")]
        public double? GradeValiditySeconds { get; set; }

        /// <summary>
        /// Grade type<br/>
        /// Example: GRADE_TYPE_PRIMARY
        /// </summary>
        /// <example>GRADE_TYPE_PRIMARY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grade_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AlertnessGradeTypeJsonConverter))]
        public global::Polar.AlertnessGradeType? GradeType { get; set; }

        /// <summary>
        /// Grade classification<br/>
        /// Example: GRADE_CLASSIFICATION_STRONG
        /// </summary>
        /// <example>GRADE_CLASSIFICATION_STRONG</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grade_classification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AlertnessGradeClassificationJsonConverter))]
        public global::Polar.AlertnessGradeClassification? GradeClassification { get; set; }

        /// <summary>
        /// Validity<br/>
        /// Example: VALIDITY_ESTIMATE
        /// </summary>
        /// <example>VALIDITY_ESTIMATE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AlertnessValidityJsonConverter))]
        public global::Polar.AlertnessValidity? Validity { get; set; }

        /// <summary>
        /// Sleep inertia<br/>
        /// Example: SLEEP_INERTIA_MILD
        /// </summary>
        /// <example>SLEEP_INERTIA_MILD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_inertia")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AlertnessSleepInertiaJsonConverter))]
        public global::Polar.AlertnessSleepInertia? SleepInertia { get; set; }

        /// <summary>
        /// Sleep type<br/>
        /// Example: SLEEP_TYPE_PRIMARY
        /// </summary>
        /// <example>SLEEP_TYPE_PRIMARY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AlertnessSleepTypeJsonConverter))]
        public global::Polar.AlertnessSleepType? SleepType { get; set; }

        /// <summary>
        /// Result type<br/>
        /// Example: ALERTNESS_TYPE_HISTORY
        /// </summary>
        /// <example>ALERTNESS_TYPE_HISTORY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AlertnessResultTypeJsonConverter))]
        public global::Polar.AlertnessResultType? ResultType { get; set; }

        /// <summary>
        /// Alertness period start time (UTC)<br/>
        /// Example: 2022-11-20T20:52:20
        /// </summary>
        /// <example>2022-11-20T20:52:20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start_time")]
        public global::System.DateTime? PeriodStartTime { get; set; }

        /// <summary>
        /// Alertness period end time (UTC)<br/>
        /// Example: 2022-11-21T19:15:52
        /// </summary>
        /// <example>2022-11-21T19:15:52</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_end_time")]
        public global::System.DateTime? PeriodEndTime { get; set; }

        /// <summary>
        /// Sleep period start time (UTC)<br/>
        /// Example: 2022-11-20T20:52:20.57
        /// </summary>
        /// <example>2022-11-20T20:52:20.57</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_period_start_time")]
        public global::System.DateTime? SleepPeriodStartTime { get; set; }

        /// <summary>
        /// Sleep period end time (UTC)<br/>
        /// Example: 2022-11-21T04:11:20.57
        /// </summary>
        /// <example>2022-11-21T04:11:20.57</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_period_end_time")]
        public global::System.DateTime? SleepPeriodEndTime { get; set; }

        /// <summary>
        /// Sleep timezone offset minutes<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_timezone_offset_minutes")]
        public double? SleepTimezoneOffsetMinutes { get; set; }

        /// <summary>
        /// Alertness hourly data for the alertness period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hourly_data")]
        public global::System.Collections.Generic.IList<global::Polar.AlertnessHourlyData>? HourlyData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Alertness" /> class.
        /// </summary>
        /// <param name="grade">
        /// Grade<br/>
        /// Example: 9.9
        /// </param>
        /// <param name="gradeValiditySeconds">
        /// Grade validity seconds<br/>
        /// Example: 57600
        /// </param>
        /// <param name="gradeType">
        /// Grade type<br/>
        /// Example: GRADE_TYPE_PRIMARY
        /// </param>
        /// <param name="gradeClassification">
        /// Grade classification<br/>
        /// Example: GRADE_CLASSIFICATION_STRONG
        /// </param>
        /// <param name="validity">
        /// Validity<br/>
        /// Example: VALIDITY_ESTIMATE
        /// </param>
        /// <param name="sleepInertia">
        /// Sleep inertia<br/>
        /// Example: SLEEP_INERTIA_MILD
        /// </param>
        /// <param name="sleepType">
        /// Sleep type<br/>
        /// Example: SLEEP_TYPE_PRIMARY
        /// </param>
        /// <param name="resultType">
        /// Result type<br/>
        /// Example: ALERTNESS_TYPE_HISTORY
        /// </param>
        /// <param name="periodStartTime">
        /// Alertness period start time (UTC)<br/>
        /// Example: 2022-11-20T20:52:20
        /// </param>
        /// <param name="periodEndTime">
        /// Alertness period end time (UTC)<br/>
        /// Example: 2022-11-21T19:15:52
        /// </param>
        /// <param name="sleepPeriodStartTime">
        /// Sleep period start time (UTC)<br/>
        /// Example: 2022-11-20T20:52:20.57
        /// </param>
        /// <param name="sleepPeriodEndTime">
        /// Sleep period end time (UTC)<br/>
        /// Example: 2022-11-21T04:11:20.57
        /// </param>
        /// <param name="sleepTimezoneOffsetMinutes">
        /// Sleep timezone offset minutes<br/>
        /// Example: 120
        /// </param>
        /// <param name="hourlyData">
        /// Alertness hourly data for the alertness period
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Alertness(
            double? grade,
            double? gradeValiditySeconds,
            global::Polar.AlertnessGradeType? gradeType,
            global::Polar.AlertnessGradeClassification? gradeClassification,
            global::Polar.AlertnessValidity? validity,
            global::Polar.AlertnessSleepInertia? sleepInertia,
            global::Polar.AlertnessSleepType? sleepType,
            global::Polar.AlertnessResultType? resultType,
            global::System.DateTime? periodStartTime,
            global::System.DateTime? periodEndTime,
            global::System.DateTime? sleepPeriodStartTime,
            global::System.DateTime? sleepPeriodEndTime,
            double? sleepTimezoneOffsetMinutes,
            global::System.Collections.Generic.IList<global::Polar.AlertnessHourlyData>? hourlyData)
        {
            this.Grade = grade;
            this.GradeValiditySeconds = gradeValiditySeconds;
            this.GradeType = gradeType;
            this.GradeClassification = gradeClassification;
            this.Validity = validity;
            this.SleepInertia = sleepInertia;
            this.SleepType = sleepType;
            this.ResultType = resultType;
            this.PeriodStartTime = periodStartTime;
            this.PeriodEndTime = periodEndTime;
            this.SleepPeriodStartTime = sleepPeriodStartTime;
            this.SleepPeriodEndTime = sleepPeriodEndTime;
            this.SleepTimezoneOffsetMinutes = sleepTimezoneOffsetMinutes;
            this.HourlyData = hourlyData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Alertness" /> class.
        /// </summary>
        public Alertness()
        {
        }
    }
}