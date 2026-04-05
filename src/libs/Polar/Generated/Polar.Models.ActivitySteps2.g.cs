
#nullable enable

namespace Polar
{
    /// <summary>
    /// Activity step samples for a day. Contains total number of steps and list of individual step samples with time and number of steps in that time period. Note that consecutive repeated (same steps count) samples are filtered out from the list to reduce the payload size. If time between two consecutive samples is larger than interval_ms, one or more samples have been filtered out.
    /// </summary>
    public sealed partial class ActivitySteps2
    {
        /// <summary>
        /// Sample interval in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_ms")]
        public int? IntervalMs { get; set; }

        /// <summary>
        /// Total number of steps in activity day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_steps")]
        public int? TotalSteps { get; set; }

        /// <summary>
        /// List of individual step sample objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Polar.ActivityStepSample2>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySteps2" /> class.
        /// </summary>
        /// <param name="intervalMs">
        /// Sample interval in milliseconds.
        /// </param>
        /// <param name="totalSteps">
        /// Total number of steps in activity day.
        /// </param>
        /// <param name="samples">
        /// List of individual step sample objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivitySteps2(
            int? intervalMs,
            int? totalSteps,
            global::System.Collections.Generic.IList<global::Polar.ActivityStepSample2>? samples)
        {
            this.IntervalMs = intervalMs;
            this.TotalSteps = totalSteps;
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySteps2" /> class.
        /// </summary>
        public ActivitySteps2()
        {
        }
    }
}