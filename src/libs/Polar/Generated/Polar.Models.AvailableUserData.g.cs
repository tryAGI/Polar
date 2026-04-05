
#nullable enable

namespace Polar
{
    /// <summary>
    /// Model contains information of the data available.
    /// </summary>
    public sealed partial class AvailableUserData
    {
        /// <summary>
        /// User identifier who has available data.<br/>
        /// Example: 475
        /// </summary>
        /// <example>475</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user-id")]
        public long? UserId { get; set; }

        /// <summary>
        /// Type of available data.<br/>
        /// Example: ACTIVITY_SUMMARY
        /// </summary>
        /// <example>ACTIVITY_SUMMARY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data-type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.AvailableUserDataDataTypeJsonConverter))]
        public global::Polar.AvailableUserDataDataType? DataType { get; set; }

        /// <summary>
        /// URI pointing to transaction initiation endpoint for user<br/>
        /// Example: https://www.polaraccesslink.com/v3/users/475/activity-transactions
        /// </summary>
        /// <example>https://www.polaraccesslink.com/v3/users/475/activity-transactions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableUserData" /> class.
        /// </summary>
        /// <param name="userId">
        /// User identifier who has available data.<br/>
        /// Example: 475
        /// </param>
        /// <param name="dataType">
        /// Type of available data.<br/>
        /// Example: ACTIVITY_SUMMARY
        /// </param>
        /// <param name="url">
        /// URI pointing to transaction initiation endpoint for user<br/>
        /// Example: https://www.polaraccesslink.com/v3/users/475/activity-transactions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailableUserData(
            long? userId,
            global::Polar.AvailableUserDataDataType? dataType,
            string? url)
        {
            this.UserId = userId;
            this.DataType = dataType;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableUserData" /> class.
        /// </summary>
        public AvailableUserData()
        {
        }
    }
}