
#nullable enable

namespace Polar
{
    /// <summary>
    /// Activity day samples.
    /// </summary>
    public sealed partial class ActivityDayWithSamples
    {
        /// <summary>
        /// Activity day date<br/>
        /// Example: 2022-02-10
        /// </summary>
        /// <example>2022-02-10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Activity step samples for a day. Contains total number of steps and list of individual step samples with time and number of steps in that time period. Note that consecutive repeated (same steps count) samples are filtered out from the list to reduce the payload size. If time between two consecutive samples is larger than interval_ms, one or more samples have been filtered out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::Polar.ActivitySteps2? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_zones")]
        public global::Polar.ActivityZoneSamples2? ActivityZones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_stamps")]
        public global::System.Collections.Generic.IList<global::Polar.ActivityDayWithSamplesInactivityStamp>? InactivityStamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDayWithSamples" /> class.
        /// </summary>
        /// <param name="date">
        /// Activity day date<br/>
        /// Example: 2022-02-10
        /// </param>
        /// <param name="steps">
        /// Activity step samples for a day. Contains total number of steps and list of individual step samples with time and number of steps in that time period. Note that consecutive repeated (same steps count) samples are filtered out from the list to reduce the payload size. If time between two consecutive samples is larger than interval_ms, one or more samples have been filtered out.
        /// </param>
        /// <param name="activityZones"></param>
        /// <param name="inactivityStamps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityDayWithSamples(
            string? date,
            global::Polar.ActivitySteps2? steps,
            global::Polar.ActivityZoneSamples2? activityZones,
            global::System.Collections.Generic.IList<global::Polar.ActivityDayWithSamplesInactivityStamp>? inactivityStamps)
        {
            this.Date = date;
            this.Steps = steps;
            this.ActivityZones = activityZones;
            this.InactivityStamps = inactivityStamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDayWithSamples" /> class.
        /// </summary>
        public ActivityDayWithSamples()
        {
        }
    }
}