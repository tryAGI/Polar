
#nullable enable

namespace Polar
{
    /// <summary>
    /// Model contains number of steps in certain time period.
    /// </summary>
    public sealed partial class ActivityZoneSample
    {
        /// <summary>
        /// List of heart rate zones with duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity-zones")]
        public global::System.Collections.Generic.IList<global::Polar.DurationZone>? ActivityZones { get; set; }

        /// <summary>
        /// Start time of sample segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZoneSample" /> class.
        /// </summary>
        /// <param name="activityZones">
        /// List of heart rate zones with duration.
        /// </param>
        /// <param name="time">
        /// Start time of sample segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityZoneSample(
            global::System.Collections.Generic.IList<global::Polar.DurationZone>? activityZones,
            string? time)
        {
            this.ActivityZones = activityZones;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZoneSample" /> class.
        /// </summary>
        public ActivityZoneSample()
        {
        }
    }
}