
#nullable enable

namespace Polar
{
    /// <summary>
    /// Sleep list
    /// </summary>
    public sealed partial class Nights
    {
        /// <summary>
        /// List of sleep objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nights")]
        public global::System.Collections.Generic.IList<global::Polar.Sleep>? Nights1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Nights" /> class.
        /// </summary>
        /// <param name="nights1">
        /// List of sleep objects
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Nights(
            global::System.Collections.Generic.IList<global::Polar.Sleep>? nights1)
        {
            this.Nights1 = nights1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Nights" /> class.
        /// </summary>
        public Nights()
        {
        }
    }
}