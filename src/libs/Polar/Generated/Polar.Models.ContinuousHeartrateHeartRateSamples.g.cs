
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContinuousHeartrateHeartRateSamples
    {
        /// <summary>
        /// heart rate rpm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate")]
        public int? HeartRate { get; set; }

        /// <summary>
        /// Measurement time of heart rate. Device time used for measurement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_time")]
        public global::System.DateTime? SampleTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousHeartrateHeartRateSamples" /> class.
        /// </summary>
        /// <param name="heartRate">
        /// heart rate rpm
        /// </param>
        /// <param name="sampleTime">
        /// Measurement time of heart rate. Device time used for measurement
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContinuousHeartrateHeartRateSamples(
            int? heartRate,
            global::System.DateTime? sampleTime)
        {
            this.HeartRate = heartRate;
            this.SampleTime = sampleTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousHeartrateHeartRateSamples" /> class.
        /// </summary>
        public ContinuousHeartrateHeartRateSamples()
        {
        }
    }
}