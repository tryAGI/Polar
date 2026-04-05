
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityZoneSample2
    {
        /// <summary>
        /// Activity zone type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.ActivityZoneSample2ZoneJsonConverter))]
        public global::Polar.ActivityZoneSample2Zone? Zone { get; set; }

        /// <summary>
        /// Example: 2025-08-14T00:08:30
        /// </summary>
        /// <example>2025-08-14T00:08:30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZoneSample2" /> class.
        /// </summary>
        /// <param name="zone">
        /// Activity zone type.
        /// </param>
        /// <param name="timestamp">
        /// Example: 2025-08-14T00:08:30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityZoneSample2(
            global::Polar.ActivityZoneSample2Zone? zone,
            string? timestamp)
        {
            this.Zone = zone;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityZoneSample2" /> class.
        /// </summary>
        public ActivityZoneSample2()
        {
        }
    }
}