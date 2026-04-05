
#nullable enable

namespace Polar
{
    /// <summary>
    /// Activity transaction container
    /// </summary>
    public sealed partial class ActivityLog
    {
        /// <summary>
        /// Absolute links to individual activity summaries within the transaction<br/>
        /// Example: [https://www.polaraccesslink.com/v3/users/12/activity-transactions/34/activities/56, https://www.polaraccesslink.com/v3/users/12/activity-transactions/34/activities/120]
        /// </summary>
        /// <example>[https://www.polaraccesslink.com/v3/users/12/activity-transactions/34/activities/56, https://www.polaraccesslink.com/v3/users/12/activity-transactions/34/activities/120]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity-log")]
        public global::System.Collections.Generic.IList<string>? ActivityLog1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLog" /> class.
        /// </summary>
        /// <param name="activityLog1">
        /// Absolute links to individual activity summaries within the transaction<br/>
        /// Example: [https://www.polaraccesslink.com/v3/users/12/activity-transactions/34/activities/56, https://www.polaraccesslink.com/v3/users/12/activity-transactions/34/activities/120]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityLog(
            global::System.Collections.Generic.IList<string>? activityLog1)
        {
            this.ActivityLog1 = activityLog1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLog" /> class.
        /// </summary>
        public ActivityLog()
        {
        }
    }
}