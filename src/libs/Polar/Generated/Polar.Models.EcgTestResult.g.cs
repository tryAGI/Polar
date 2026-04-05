
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EcgTestResult
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
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_heart_rate_bpm")]
        public int? AverageHeartRateBpm { get; set; }

        /// <summary>
        /// Example: 0.0
        /// </summary>
        /// <example>0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_variability_ms")]
        public float? HeartRateVariabilityMs { get; set; }

        /// <summary>
        /// Example: ECG_HRV_LEVEL_NO_BASELINE
        /// </summary>
        /// <example>ECG_HRV_LEVEL_NO_BASELINE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_variability_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.EcgTestResultHeartRateVariabilityLevelJsonConverter))]
        public global::Polar.EcgTestResultHeartRateVariabilityLevel? HeartRateVariabilityLevel { get; set; }

        /// <summary>
        /// Example: 100.0
        /// </summary>
        /// <example>100.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rri_ms")]
        public float? RriMs { get; set; }

        /// <summary>
        /// Example: 100.0
        /// </summary>
        /// <example>100.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulse_transit_time_systolic_ms")]
        public float? PulseTransitTimeSystolicMs { get; set; }

        /// <summary>
        /// Example: 100.0
        /// </summary>
        /// <example>100.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulse_transit_time_diastolic_ms")]
        public float? PulseTransitTimeDiastolicMs { get; set; }

        /// <summary>
        /// Example: 100.0
        /// </summary>
        /// <example>100.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulse_transit_time_quality_index")]
        public float? PulseTransitTimeQualityIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Polar.EcgSample>? Samples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_measurements")]
        public global::System.Collections.Generic.IList<global::Polar.QualityMeasurement>? QualityMeasurements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EcgTestResult" /> class.
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
        /// <param name="averageHeartRateBpm">
        /// Example: 60
        /// </param>
        /// <param name="heartRateVariabilityMs">
        /// Example: 0.0
        /// </param>
        /// <param name="heartRateVariabilityLevel">
        /// Example: ECG_HRV_LEVEL_NO_BASELINE
        /// </param>
        /// <param name="rriMs">
        /// Example: 100.0
        /// </param>
        /// <param name="pulseTransitTimeSystolicMs">
        /// Example: 100.0
        /// </param>
        /// <param name="pulseTransitTimeDiastolicMs">
        /// Example: 100.0
        /// </param>
        /// <param name="pulseTransitTimeQualityIndex">
        /// Example: 100.0
        /// </param>
        /// <param name="samples"></param>
        /// <param name="qualityMeasurements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EcgTestResult(
            string? sourceDeviceId,
            long? testTime,
            int? timeZoneOffset,
            int? averageHeartRateBpm,
            float? heartRateVariabilityMs,
            global::Polar.EcgTestResultHeartRateVariabilityLevel? heartRateVariabilityLevel,
            float? rriMs,
            float? pulseTransitTimeSystolicMs,
            float? pulseTransitTimeDiastolicMs,
            float? pulseTransitTimeQualityIndex,
            global::System.Collections.Generic.IList<global::Polar.EcgSample>? samples,
            global::System.Collections.Generic.IList<global::Polar.QualityMeasurement>? qualityMeasurements)
        {
            this.SourceDeviceId = sourceDeviceId;
            this.TestTime = testTime;
            this.TimeZoneOffset = timeZoneOffset;
            this.AverageHeartRateBpm = averageHeartRateBpm;
            this.HeartRateVariabilityMs = heartRateVariabilityMs;
            this.HeartRateVariabilityLevel = heartRateVariabilityLevel;
            this.RriMs = rriMs;
            this.PulseTransitTimeSystolicMs = pulseTransitTimeSystolicMs;
            this.PulseTransitTimeDiastolicMs = pulseTransitTimeDiastolicMs;
            this.PulseTransitTimeQualityIndex = pulseTransitTimeQualityIndex;
            this.Samples = samples;
            this.QualityMeasurements = qualityMeasurements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EcgTestResult" /> class.
        /// </summary>
        public EcgTestResult()
        {
        }
    }
}