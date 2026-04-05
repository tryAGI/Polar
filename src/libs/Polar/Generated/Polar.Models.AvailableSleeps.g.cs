
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvailableSleeps
    {
        /// <summary>
        /// List of available sleep data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        public global::System.Collections.Generic.IList<global::Polar.AvailableSleep>? Available { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableSleeps" /> class.
        /// </summary>
        /// <param name="available">
        /// List of available sleep data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailableSleeps(
            global::System.Collections.Generic.IList<global::Polar.AvailableSleep>? available)
        {
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableSleeps" /> class.
        /// </summary>
        public AvailableSleeps()
        {
        }
    }
}