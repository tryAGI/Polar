
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvailableSleep
    {
        /// <summary>
        /// Result date of the sleep<br/>
        /// Example: 2020-01-01
        /// </summary>
        /// <example>2020-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Start timestamp of the sleep as ISO-8601 datetime string<br/>
        /// Example: 2020-01-01T00:39:07+03:00
        /// </summary>
        /// <example>2020-01-01T00:39:07+03:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// End timestamp of the sleep as ISO-8601 datetime string<br/>
        /// Example: 2020-01-01T09:39:07+03:00
        /// </summary>
        /// <example>2020-01-01T09:39:07+03:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableSleep" /> class.
        /// </summary>
        /// <param name="date">
        /// Result date of the sleep<br/>
        /// Example: 2020-01-01
        /// </param>
        /// <param name="startTime">
        /// Start timestamp of the sleep as ISO-8601 datetime string<br/>
        /// Example: 2020-01-01T00:39:07+03:00
        /// </param>
        /// <param name="endTime">
        /// End timestamp of the sleep as ISO-8601 datetime string<br/>
        /// Example: 2020-01-01T09:39:07+03:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailableSleep(
            global::System.DateTime? date,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime)
        {
            this.Date = date;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableSleep" /> class.
        /// </summary>
        public AvailableSleep()
        {
        }
    }
}