
#nullable enable

namespace Polar
{
    /// <summary>
    /// Nightly Recharge list
    /// </summary>
    public sealed partial class Recharges
    {
        /// <summary>
        /// List of Nightly Recharge objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharges")]
        public global::System.Collections.Generic.IList<global::Polar.NightlyRecharge>? Recharges1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Recharges" /> class.
        /// </summary>
        /// <param name="recharges1">
        /// List of Nightly Recharge objects
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Recharges(
            global::System.Collections.Generic.IList<global::Polar.NightlyRecharge>? recharges1)
        {
            this.Recharges1 = recharges1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recharges" /> class.
        /// </summary>
        public Recharges()
        {
        }
    }
}