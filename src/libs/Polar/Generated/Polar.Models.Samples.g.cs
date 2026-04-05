
#nullable enable

namespace Polar
{
    /// <summary>
    /// List of URIs pointing to single sample type data.
    /// </summary>
    public sealed partial class Samples
    {
        /// <summary>
        /// List of URIs pointing to single sample type data.<br/>
        /// Example: [https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56/samples/0, https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56/samples/3]
        /// </summary>
        /// <example>[https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56/samples/0, https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56/samples/3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<string>? Samples1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Samples" /> class.
        /// </summary>
        /// <param name="samples1">
        /// List of URIs pointing to single sample type data.<br/>
        /// Example: [https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56/samples/0, https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56/samples/3]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Samples(
            global::System.Collections.Generic.IList<string>? samples1)
        {
            this.Samples1 = samples1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Samples" /> class.
        /// </summary>
        public Samples()
        {
        }
    }
}