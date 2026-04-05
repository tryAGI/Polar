
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EcgSample
    {
        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_time_delta_ms")]
        public int? RecordingTimeDeltaMs { get; set; }

        /// <summary>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amplitude_mv")]
        public float? AmplitudeMv { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EcgSample" /> class.
        /// </summary>
        /// <param name="recordingTimeDeltaMs">
        /// Example: 123
        /// </param>
        /// <param name="amplitudeMv">
        /// Example: 0.1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EcgSample(
            int? recordingTimeDeltaMs,
            float? amplitudeMv)
        {
            this.RecordingTimeDeltaMs = recordingTimeDeltaMs;
            this.AmplitudeMv = amplitudeMv;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EcgSample" /> class.
        /// </summary>
        public EcgSample()
        {
        }
    }
}