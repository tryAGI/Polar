
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Spo2TestResult
    {
        /// <summary>
        /// Example: 1111AAAA
        /// </summary>
        /// <example>1111AAAA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_device_id")]
        public string? SourceDeviceId { get; set; }

        /// <summary>
        /// Example: 1697787256
        /// </summary>
        /// <example>1697787256</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_time")]
        public long? TestTime { get; set; }

        /// <summary>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_zone_offset")]
        public int? TimeZoneOffset { get; set; }

        /// <summary>
        /// Example: SPO2_TEST_PASSED
        /// </summary>
        /// <example>SPO2_TEST_PASSED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.Spo2TestResultTestStatusJsonConverter))]
        public global::Polar.Spo2TestResultTestStatus? TestStatus { get; set; }

        /// <summary>
        /// Example: 95
        /// </summary>
        /// <example>95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blood_oxygen_percent")]
        public int? BloodOxygenPercent { get; set; }

        /// <summary>
        /// Example: SPO2_CLASS_NORMAL
        /// </summary>
        /// <example>SPO2_CLASS_NORMAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.Spo2TestResultSpo2ClassJsonConverter))]
        public global::Polar.Spo2TestResultSpo2Class? Spo2Class { get; set; }

        /// <summary>
        /// Example: DEVIATION_NO_BASELINE
        /// </summary>
        /// <example>DEVIATION_NO_BASELINE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_value_deviation_from_baseline")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.Spo2TestResultSpo2ValueDeviationFromBaselineJsonConverter))]
        public global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline? Spo2ValueDeviationFromBaseline { get; set; }

        /// <summary>
        /// Example: 90.0
        /// </summary>
        /// <example>90.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_quality_average_percent")]
        public float? Spo2QualityAveragePercent { get; set; }

        /// <summary>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_heart_rate_bpm")]
        public int? AverageHeartRateBpm { get; set; }

        /// <summary>
        /// Example: 100.0
        /// </summary>
        /// <example>100.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_variability_ms")]
        public float? HeartRateVariabilityMs { get; set; }

        /// <summary>
        /// Example: DEVIATION_NO_BASELINE
        /// </summary>
        /// <example>DEVIATION_NO_BASELINE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_hrv_deviation_from_baseline")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.Spo2TestResultSpo2HrvDeviationFromBaselineJsonConverter))]
        public global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline? Spo2HrvDeviationFromBaseline { get; set; }

        /// <summary>
        /// Example: 50.0
        /// </summary>
        /// <example>50.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("altitude_meters")]
        public float? AltitudeMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Spo2TestResult" /> class.
        /// </summary>
        /// <param name="sourceDeviceId">
        /// Example: 1111AAAA
        /// </param>
        /// <param name="testTime">
        /// Example: 1697787256
        /// </param>
        /// <param name="timeZoneOffset">
        /// Example: 180
        /// </param>
        /// <param name="testStatus">
        /// Example: SPO2_TEST_PASSED
        /// </param>
        /// <param name="bloodOxygenPercent">
        /// Example: 95
        /// </param>
        /// <param name="spo2Class">
        /// Example: SPO2_CLASS_NORMAL
        /// </param>
        /// <param name="spo2ValueDeviationFromBaseline">
        /// Example: DEVIATION_NO_BASELINE
        /// </param>
        /// <param name="spo2QualityAveragePercent">
        /// Example: 90.0
        /// </param>
        /// <param name="averageHeartRateBpm">
        /// Example: 60
        /// </param>
        /// <param name="heartRateVariabilityMs">
        /// Example: 100.0
        /// </param>
        /// <param name="spo2HrvDeviationFromBaseline">
        /// Example: DEVIATION_NO_BASELINE
        /// </param>
        /// <param name="altitudeMeters">
        /// Example: 50.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Spo2TestResult(
            string? sourceDeviceId,
            long? testTime,
            int? timeZoneOffset,
            global::Polar.Spo2TestResultTestStatus? testStatus,
            int? bloodOxygenPercent,
            global::Polar.Spo2TestResultSpo2Class? spo2Class,
            global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline? spo2ValueDeviationFromBaseline,
            float? spo2QualityAveragePercent,
            int? averageHeartRateBpm,
            float? heartRateVariabilityMs,
            global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline? spo2HrvDeviationFromBaseline,
            float? altitudeMeters)
        {
            this.SourceDeviceId = sourceDeviceId;
            this.TestTime = testTime;
            this.TimeZoneOffset = timeZoneOffset;
            this.TestStatus = testStatus;
            this.BloodOxygenPercent = bloodOxygenPercent;
            this.Spo2Class = spo2Class;
            this.Spo2ValueDeviationFromBaseline = spo2ValueDeviationFromBaseline;
            this.Spo2QualityAveragePercent = spo2QualityAveragePercent;
            this.AverageHeartRateBpm = averageHeartRateBpm;
            this.HeartRateVariabilityMs = heartRateVariabilityMs;
            this.Spo2HrvDeviationFromBaseline = spo2HrvDeviationFromBaseline;
            this.AltitudeMeters = altitudeMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spo2TestResult" /> class.
        /// </summary>
        public Spo2TestResult()
        {
        }
    }
}