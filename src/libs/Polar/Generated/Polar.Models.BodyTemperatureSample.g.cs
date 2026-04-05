
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTemperatureSample
    {
        /// <summary>
        /// Example: 36.5
        /// </summary>
        /// <example>36.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_celsius")]
        public float? TemperatureCelsius { get; set; }

        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_time_delta_milliseconds")]
        public long? RecordingTimeDeltaMilliseconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTemperatureSample" /> class.
        /// </summary>
        /// <param name="temperatureCelsius">
        /// Example: 36.5
        /// </param>
        /// <param name="recordingTimeDeltaMilliseconds">
        /// Example: 123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyTemperatureSample(
            float? temperatureCelsius,
            long? recordingTimeDeltaMilliseconds)
        {
            this.TemperatureCelsius = temperatureCelsius;
            this.RecordingTimeDeltaMilliseconds = recordingTimeDeltaMilliseconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTemperatureSample" /> class.
        /// </summary>
        public BodyTemperatureSample()
        {
        }
    }
}