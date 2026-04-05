
#nullable enable

namespace Polar
{
    /// <summary>
    /// Model contains the time spent in certain activity zone.
    /// </summary>
    public sealed partial class DurationZone
    {
        /// <summary>
        /// Activity zone index<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Time duration spent in the zone ISO 8601<br/>
        /// Example: PT51M5S
        /// </summary>
        /// <example>PT51M5S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inzone")]
        public string? Inzone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DurationZone" /> class.
        /// </summary>
        /// <param name="index">
        /// Activity zone index<br/>
        /// Example: 1
        /// </param>
        /// <param name="inzone">
        /// Time duration spent in the zone ISO 8601<br/>
        /// Example: PT51M5S
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DurationZone(
            int? index,
            string? inzone)
        {
            this.Index = index;
            this.Inzone = inzone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DurationZone" /> class.
        /// </summary>
        public DurationZone()
        {
        }
    }
}