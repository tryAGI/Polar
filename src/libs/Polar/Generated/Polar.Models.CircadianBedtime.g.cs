
#nullable enable

namespace Polar
{
    /// <summary>
    /// Circadian bedtime period data<br/>
    /// Example: {"validity":"VALIDITY_ESTIMATE","quality":"CIRCADIAN_BEDTIME_QUALITY_COMPROMISED","result_type":"CIRCADIAN_BEDTIME_TYPE_HISTORY","period_start_time":"2022-11-20T21:18:30","period_end_time":"2022-11-21T05:18:30","preferred_sleep_period_start_time":"2022-11-20T21:18:30","preferred_sleep_period_end_time":"2022-11-21T05:18:30","sleep_gate_start_time":"2022-11-20T21:03:30","sleep_gate_end_time":"2022-11-20T21:33:30","sleep_timezone_offset_minutes":120}
    /// </summary>
    public sealed partial class CircadianBedtime
    {
        /// <summary>
        /// Validity<br/>
        /// Example: VALIDITY_ESTIMATE
        /// </summary>
        /// <example>VALIDITY_ESTIMATE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.CircadianBedtimeValidityJsonConverter))]
        public global::Polar.CircadianBedtimeValidity? Validity { get; set; }

        /// <summary>
        /// Quality<br/>
        /// Example: CIRCADIAN_BEDTIME_QUALITY_COMPROMISED
        /// </summary>
        /// <example>CIRCADIAN_BEDTIME_QUALITY_COMPROMISED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.CircadianBedtimeQualityJsonConverter))]
        public global::Polar.CircadianBedtimeQuality? Quality { get; set; }

        /// <summary>
        /// Result type<br/>
        /// Example: CIRCADIAN_BEDTIME_TYPE_HISTORY
        /// </summary>
        /// <example>CIRCADIAN_BEDTIME_TYPE_HISTORY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.CircadianBedtimeResultTypeJsonConverter))]
        public global::Polar.CircadianBedtimeResultType? ResultType { get; set; }

        /// <summary>
        /// Circadian bedtime period start time (UTC)<br/>
        /// Example: 2022-11-20T21:18:30
        /// </summary>
        /// <example>2022-11-20T21:18:30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start_time")]
        public global::System.DateTime? PeriodStartTime { get; set; }

        /// <summary>
        /// Circadian bedtime period end time (UTC)<br/>
        /// Example: 2022-11-21T05:18:30
        /// </summary>
        /// <example>2022-11-21T05:18:30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_end_time")]
        public global::System.DateTime? PeriodEndTime { get; set; }

        /// <summary>
        /// Circadian bedtime preferred sleep period start time (UTC)<br/>
        /// Example: 2022-11-20T21:18:30
        /// </summary>
        /// <example>2022-11-20T21:18:30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_sleep_period_start_time")]
        public global::System.DateTime? PreferredSleepPeriodStartTime { get; set; }

        /// <summary>
        /// Circadian bedtime preferred sleep period end time (UTC)<br/>
        /// Example: 2022-11-21T05:18:30
        /// </summary>
        /// <example>2022-11-21T05:18:30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_sleep_period_end_time")]
        public global::System.DateTime? PreferredSleepPeriodEndTime { get; set; }

        /// <summary>
        /// Circadian bedtime sleep gate (suggested fall a sleep window) start time (UTC)<br/>
        /// Example: 2022-11-20T21:18:30
        /// </summary>
        /// <example>2022-11-20T21:18:30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_gate_start_time")]
        public global::System.DateTime? SleepGateStartTime { get; set; }

        /// <summary>
        /// Circadian bedtime sleep gate (suggested fall a sleep window) end time (UTC)<br/>
        /// Example: 2022-11-21T05:18:30
        /// </summary>
        /// <example>2022-11-21T05:18:30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_gate_end_time")]
        public global::System.DateTime? SleepGateEndTime { get; set; }

        /// <summary>
        /// Sleep timezone offset minutes<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_timezone_offset_minutes")]
        public double? SleepTimezoneOffsetMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CircadianBedtime" /> class.
        /// </summary>
        /// <param name="validity">
        /// Validity<br/>
        /// Example: VALIDITY_ESTIMATE
        /// </param>
        /// <param name="quality">
        /// Quality<br/>
        /// Example: CIRCADIAN_BEDTIME_QUALITY_COMPROMISED
        /// </param>
        /// <param name="resultType">
        /// Result type<br/>
        /// Example: CIRCADIAN_BEDTIME_TYPE_HISTORY
        /// </param>
        /// <param name="periodStartTime">
        /// Circadian bedtime period start time (UTC)<br/>
        /// Example: 2022-11-20T21:18:30
        /// </param>
        /// <param name="periodEndTime">
        /// Circadian bedtime period end time (UTC)<br/>
        /// Example: 2022-11-21T05:18:30
        /// </param>
        /// <param name="preferredSleepPeriodStartTime">
        /// Circadian bedtime preferred sleep period start time (UTC)<br/>
        /// Example: 2022-11-20T21:18:30
        /// </param>
        /// <param name="preferredSleepPeriodEndTime">
        /// Circadian bedtime preferred sleep period end time (UTC)<br/>
        /// Example: 2022-11-21T05:18:30
        /// </param>
        /// <param name="sleepGateStartTime">
        /// Circadian bedtime sleep gate (suggested fall a sleep window) start time (UTC)<br/>
        /// Example: 2022-11-20T21:18:30
        /// </param>
        /// <param name="sleepGateEndTime">
        /// Circadian bedtime sleep gate (suggested fall a sleep window) end time (UTC)<br/>
        /// Example: 2022-11-21T05:18:30
        /// </param>
        /// <param name="sleepTimezoneOffsetMinutes">
        /// Sleep timezone offset minutes<br/>
        /// Example: 120
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CircadianBedtime(
            global::Polar.CircadianBedtimeValidity? validity,
            global::Polar.CircadianBedtimeQuality? quality,
            global::Polar.CircadianBedtimeResultType? resultType,
            global::System.DateTime? periodStartTime,
            global::System.DateTime? periodEndTime,
            global::System.DateTime? preferredSleepPeriodStartTime,
            global::System.DateTime? preferredSleepPeriodEndTime,
            global::System.DateTime? sleepGateStartTime,
            global::System.DateTime? sleepGateEndTime,
            double? sleepTimezoneOffsetMinutes)
        {
            this.Validity = validity;
            this.Quality = quality;
            this.ResultType = resultType;
            this.PeriodStartTime = periodStartTime;
            this.PeriodEndTime = periodEndTime;
            this.PreferredSleepPeriodStartTime = preferredSleepPeriodStartTime;
            this.PreferredSleepPeriodEndTime = preferredSleepPeriodEndTime;
            this.SleepGateStartTime = sleepGateStartTime;
            this.SleepGateEndTime = sleepGateEndTime;
            this.SleepTimezoneOffsetMinutes = sleepTimezoneOffsetMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CircadianBedtime" /> class.
        /// </summary>
        public CircadianBedtime()
        {
        }
    }
}