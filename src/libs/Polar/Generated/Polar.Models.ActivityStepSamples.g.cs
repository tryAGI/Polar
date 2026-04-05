
#nullable enable

namespace Polar
{
    /// <summary>
    /// Wrapper model for partner step samples.
    /// </summary>
    public sealed partial class ActivityStepSamples
    {
        /// <summary>
        /// Activity step sample date<br/>
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
        /// List of individual step sample objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Polar.ActivityStepSample>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStepSamples" /> class.
        /// </summary>
        /// <param name="date">
        /// Activity step sample date<br/>
        /// Example: 2022-02-10
        /// </param>
        /// <param name="interval">
        /// Sample interval in minutes.
        /// </param>
        /// <param name="samples">
        /// List of individual step sample objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityStepSamples(
            string? date,
            int? interval,
            global::System.Collections.Generic.IList<global::Polar.ActivityStepSample>? samples)
        {
            this.Date = date;
            this.Interval = interval;
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStepSamples" /> class.
        /// </summary>
        public ActivityStepSamples()
        {
        }
    }
}