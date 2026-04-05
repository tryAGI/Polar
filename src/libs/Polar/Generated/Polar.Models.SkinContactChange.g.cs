
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkinContactChange
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skin_contact")]
        public bool? SkinContact { get; set; }

        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_time_delta_milliseconds")]
        public long? RecordingTimeDeltaMilliseconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkinContactChange" /> class.
        /// </summary>
        /// <param name="skinContact">
        /// Example: true
        /// </param>
        /// <param name="recordingTimeDeltaMilliseconds">
        /// Example: 123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkinContactChange(
            bool? skinContact,
            long? recordingTimeDeltaMilliseconds)
        {
            this.SkinContact = skinContact;
            this.RecordingTimeDeltaMilliseconds = recordingTimeDeltaMilliseconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkinContactChange" /> class.
        /// </summary>
        public SkinContactChange()
        {
        }
    }
}