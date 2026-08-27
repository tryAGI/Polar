
#nullable enable

namespace Polar
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContinuousHeartrateHeartRateSample
    {
        /// <summary>
        /// Heart rate in beats per minute (bpm).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate")]
        public int? HeartRate { get; set; }

        /// <summary>
        /// Measurement time of heart rate in HH:mm:ss format. Device time used for measurement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_time")]
        public string? SampleTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousHeartrateHeartRateSample" /> class.
        /// </summary>
        /// <param name="heartRate">
        /// Heart rate in beats per minute (bpm).
        /// </param>
        /// <param name="sampleTime">
        /// Measurement time of heart rate in HH:mm:ss format. Device time used for measurement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContinuousHeartrateHeartRateSample(
            int? heartRate,
            string? sampleTime)
        {
            this.HeartRate = heartRate;
            this.SampleTime = sampleTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousHeartrateHeartRateSample" /> class.
        /// </summary>
        public ContinuousHeartrateHeartRateSample()
        {
        }

    }
}