
#nullable enable

namespace Polar
{
    /// <summary>
    /// Exercise transaction container
    /// </summary>
    public sealed partial class Exercises
    {
        /// <summary>
        /// Absolute links to individual exercises within the transaction<br/>
        /// Example: [https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56, https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/120]
        /// </summary>
        /// <example>[https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56, https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/120]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercises")]
        public global::System.Collections.Generic.IList<string>? Exercises1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Exercises" /> class.
        /// </summary>
        /// <param name="exercises1">
        /// Absolute links to individual exercises within the transaction<br/>
        /// Example: [https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/56, https://www.polaraccesslink.com/v3/users/12/exercise-transactions/34/exercises/120]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Exercises(
            global::System.Collections.Generic.IList<string>? exercises1)
        {
            this.Exercises1 = exercises1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exercises" /> class.
        /// </summary>
        public Exercises()
        {
        }
    }
}