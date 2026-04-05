
#nullable enable

namespace Polar
{
    /// <summary>
    /// Exercise route point/location.
    /// </summary>
    public sealed partial class Location
    {
        /// <summary>
        /// The latitude, expressed in degrees.<br/>
        /// Example: 60.21982833
        /// </summary>
        /// <example>60.21982833</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// The longitude, expressed in degrees.<br/>
        /// Example: 25.13925
        /// </summary>
        /// <example>25.13925</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// The time, expressed as a duration.<br/>
        /// Example: PT210.026S
        /// </summary>
        /// <example>PT210.026S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// Satellites. A byte-sized value with a maximum of 63.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("satellites")]
        public long? Satellites { get; set; }

        /// <summary>
        /// Fix. A byte-sized value with a maximum of three.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix")]
        public long? Fix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="latitude">
        /// The latitude, expressed in degrees.<br/>
        /// Example: 60.21982833
        /// </param>
        /// <param name="longitude">
        /// The longitude, expressed in degrees.<br/>
        /// Example: 25.13925
        /// </param>
        /// <param name="time">
        /// The time, expressed as a duration.<br/>
        /// Example: PT210.026S
        /// </param>
        /// <param name="satellites">
        /// Satellites. A byte-sized value with a maximum of 63.<br/>
        /// Example: 4
        /// </param>
        /// <param name="fix">
        /// Fix. A byte-sized value with a maximum of three.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Location(
            double? latitude,
            double? longitude,
            string? time,
            long? satellites,
            long? fix)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Time = time;
            this.Satellites = satellites;
            this.Fix = fix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        public Location()
        {
        }
    }
}