
#nullable enable

namespace Polar
{
    /// <summary>
    /// AvailableUserDatas is a container model for AvailableUserData. 
    /// </summary>
    public sealed partial class AvailableUserDatas
    {
        /// <summary>
        /// List of available user datas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available-user-data")]
        public global::System.Collections.Generic.IList<global::Polar.AvailableUserData>? AvailableUserData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableUserDatas" /> class.
        /// </summary>
        /// <param name="availableUserData">
        /// List of available user datas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailableUserDatas(
            global::System.Collections.Generic.IList<global::Polar.AvailableUserData>? availableUserData)
        {
            this.AvailableUserData = availableUserData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableUserDatas" /> class.
        /// </summary>
        public AvailableUserDatas()
        {
        }
    }
}