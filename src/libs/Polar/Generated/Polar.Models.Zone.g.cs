
#nullable enable

namespace Polar
{
    /// <summary>
    /// Heart-rate zone information
    /// </summary>
    public sealed partial class Zone
    {
        /// <summary>
        /// Zone list index<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Lower heart-rate boundary of the zone<br/>
        /// Example: 110
        /// </summary>
        /// <example>110</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lower-limit")]
        public int? LowerLimit { get; set; }

        /// <summary>
        /// Upper heart-rate boundary of the zone<br/>
        /// Example: 130
        /// </summary>
        /// <example>130</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper-limit")]
        public int? UpperLimit { get; set; }

        /// <summary>
        /// Time duration spent in the zone ISO 8601<br/>
        /// Example: PT4S
        /// </summary>
        /// <example>PT4S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("in-zone")]
        public string? InZone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Zone" /> class.
        /// </summary>
        /// <param name="index">
        /// Zone list index<br/>
        /// Example: 1
        /// </param>
        /// <param name="lowerLimit">
        /// Lower heart-rate boundary of the zone<br/>
        /// Example: 110
        /// </param>
        /// <param name="upperLimit">
        /// Upper heart-rate boundary of the zone<br/>
        /// Example: 130
        /// </param>
        /// <param name="inZone">
        /// Time duration spent in the zone ISO 8601<br/>
        /// Example: PT4S
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Zone(
            int? index,
            int? lowerLimit,
            int? upperLimit,
            string? inZone)
        {
            this.Index = index;
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
            this.InZone = inZone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zone" /> class.
        /// </summary>
        public Zone()
        {
        }
    }
}