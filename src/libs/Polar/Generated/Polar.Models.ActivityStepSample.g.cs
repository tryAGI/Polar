
#nullable enable

namespace Polar
{
    /// <summary>
    /// Model contains number of steps in certain time period.
    /// </summary>
    public sealed partial class ActivityStepSample
    {
        /// <summary>
        /// Number of steps in sample segment. If element is null, step samples are not available for current segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Start time of sample segment.<br/>
        /// Example: 12:37:33.000
        /// </summary>
        /// <example>12:37:33.000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStepSample" /> class.
        /// </summary>
        /// <param name="steps">
        /// Number of steps in sample segment. If element is null, step samples are not available for current segment.
        /// </param>
        /// <param name="time">
        /// Start time of sample segment.<br/>
        /// Example: 12:37:33.000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityStepSample(
            int? steps,
            string? time)
        {
            this.Steps = steps;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStepSample" /> class.
        /// </summary>
        public ActivityStepSample()
        {
        }
    }
}