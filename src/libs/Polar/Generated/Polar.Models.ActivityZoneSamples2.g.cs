
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityZoneSamples2
    {
        /// <summary>
        /// List of activity zones samples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Polar.ActivityZoneSample2>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZoneSamples2" /> class.
        /// </summary>
        /// <param name="samples">
        /// List of activity zones samples.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityZoneSamples2(
            global::System.Collections.Generic.IList<global::Polar.ActivityZoneSample2>? samples)
        {
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZoneSamples2" /> class.
        /// </summary>
        public ActivityZoneSamples2()
        {
        }
    }
}