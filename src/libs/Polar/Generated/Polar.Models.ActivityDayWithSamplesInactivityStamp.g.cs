
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityDayWithSamplesInactivityStamp
    {
        /// <summary>
        /// time of inactivity stamp<br/>
        /// Example: 2022-02-10T16:04
        /// </summary>
        /// <example>2022-02-10T16:04</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stamp")]
        public string? Stamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDayWithSamplesInactivityStamp" /> class.
        /// </summary>
        /// <param name="stamp">
        /// time of inactivity stamp<br/>
        /// Example: 2022-02-10T16:04
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityDayWithSamplesInactivityStamp(
            string? stamp)
        {
            this.Stamp = stamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDayWithSamplesInactivityStamp" /> class.
        /// </summary>
        public ActivityDayWithSamplesInactivityStamp()
        {
        }
    }
}