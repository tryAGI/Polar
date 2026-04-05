
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityMeasurement
    {
        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_time_delta_ms")]
        public int? RecordingTimeDeltaMs { get; set; }

        /// <summary>
        /// Example: ECG_QUALITY_HIGH
        /// </summary>
        /// <example>ECG_QUALITY_HIGH</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.QualityMeasurementQualityLevelJsonConverter))]
        public global::Polar.QualityMeasurementQualityLevel? QualityLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityMeasurement" /> class.
        /// </summary>
        /// <param name="recordingTimeDeltaMs">
        /// Example: 123
        /// </param>
        /// <param name="qualityLevel">
        /// Example: ECG_QUALITY_HIGH
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityMeasurement(
            int? recordingTimeDeltaMs,
            global::Polar.QualityMeasurementQualityLevel? qualityLevel)
        {
            this.RecordingTimeDeltaMs = recordingTimeDeltaMs;
            this.QualityLevel = qualityLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityMeasurement" /> class.
        /// </summary>
        public QualityMeasurement()
        {
        }
    }
}