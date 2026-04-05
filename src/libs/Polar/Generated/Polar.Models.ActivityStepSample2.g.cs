
#nullable enable

namespace Polar
{
    /// <summary>
    /// Model contains number of steps in certain time period.
    /// </summary>
    public sealed partial class ActivityStepSample2
    {
        /// <summary>
        /// Number of steps in sample segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Start time of sample segment.<br/>
        /// Example: 2025-08-14T00:02
        /// </summary>
        /// <example>2025-08-14T00:02</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStepSample2" /> class.
        /// </summary>
        /// <param name="steps">
        /// Number of steps in sample segment.
        /// </param>
        /// <param name="timestamp">
        /// Start time of sample segment.<br/>
        /// Example: 2025-08-14T00:02
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityStepSample2(
            int? steps,
            string? timestamp)
        {
            this.Steps = steps;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStepSample2" /> class.
        /// </summary>
        public ActivityStepSample2()
        {
        }
    }
}