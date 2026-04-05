
#nullable enable

namespace Polar
{
    /// <summary>
    /// Physical information transaction container
    /// </summary>
    public sealed partial class PhysicalInformations
    {
        /// <summary>
        /// Absolute links to individual physical information within the transaction<br/>
        /// Example: [https://www.polaraccesslink.com/v3/users/12/physical-information-transactions/12/physical-informations/56, https://www.polaraccesslink.com/v3/users/12/physical-information-transactions/12/physical-informations/120]
        /// </summary>
        /// <example>[https://www.polaraccesslink.com/v3/users/12/physical-information-transactions/12/physical-informations/56, https://www.polaraccesslink.com/v3/users/12/physical-information-transactions/12/physical-informations/120]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("physical-informations")]
        public global::System.Collections.Generic.IList<string>? PhysicalInformations1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalInformations" /> class.
        /// </summary>
        /// <param name="physicalInformations1">
        /// Absolute links to individual physical information within the transaction<br/>
        /// Example: [https://www.polaraccesslink.com/v3/users/12/physical-information-transactions/12/physical-informations/56, https://www.polaraccesslink.com/v3/users/12/physical-information-transactions/12/physical-informations/120]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhysicalInformations(
            global::System.Collections.Generic.IList<string>? physicalInformations1)
        {
            this.PhysicalInformations1 = physicalInformations1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalInformations" /> class.
        /// </summary>
        public PhysicalInformations()
        {
        }
    }
}