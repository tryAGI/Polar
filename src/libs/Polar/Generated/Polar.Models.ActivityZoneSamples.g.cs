
#nullable enable

namespace Polar
{
    /// <summary>
    /// List containing the times (in zone) in different heart rate zones (i.e. Heart rate between lower and upper values). Zone is null if no zone information available.
    /// </summary>
    public sealed partial class ActivityZoneSamples
    {
        /// <summary>
        /// Activity zone sample date<br/>
        /// Example: 2022-02-10
        /// </summary>
        /// <example>2022-02-10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Sample interval in minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// List of individual zone sample objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Polar.ActivityZoneSample>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZoneSamples" /> class.
        /// </summary>
        /// <param name="date">
        /// Activity zone sample date<br/>
        /// Example: 2022-02-10
        /// </param>
        /// <param name="interval">
        /// Sample interval in minutes.
        /// </param>
        /// <param name="samples">
        /// List of individual zone sample objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityZoneSamples(
            string? date,
            int? interval,
            global::System.Collections.Generic.IList<global::Polar.ActivityZoneSample>? samples)
        {
            this.Date = date;
            this.Interval = interval;
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZoneSamples" /> class.
        /// </summary>
        public ActivityZoneSamples()
        {
        }
    }
}