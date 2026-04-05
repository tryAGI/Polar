
#nullable enable

namespace Polar
{
    /// <summary>
    /// List containing the times (in zone) in different heart rate zones (i.e. Heart rate between lower and upper values). Zone is null if no zone information available.
    /// </summary>
    public sealed partial class Zones
    {
        /// <summary>
        /// List of heart rate zones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone")]
        public global::System.Collections.Generic.IList<global::Polar.Zone>? Zone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Zones" /> class.
        /// </summary>
        /// <param name="zone">
        /// List of heart rate zones.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Zones(
            global::System.Collections.Generic.IList<global::Polar.Zone>? zone)
        {
            this.Zone = zone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zones" /> class.
        /// </summary>
        public Zones()
        {
        }
    }
}