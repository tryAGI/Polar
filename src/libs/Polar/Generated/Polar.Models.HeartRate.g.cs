
#nullable enable

namespace Polar
{
    /// <summary>
    /// Heart-rate statistics information
    /// </summary>
    public sealed partial class HeartRate
    {
        /// <summary>
        /// Average heart-rate<br/>
        /// Example: 129
        /// </summary>
        /// <example>129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("average")]
        public int? Average { get; set; }

        /// <summary>
        /// Maximum heart-rate<br/>
        /// Example: 147
        /// </summary>
        /// <example>147</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum")]
        public int? Maximum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRate" /> class.
        /// </summary>
        /// <param name="average">
        /// Average heart-rate<br/>
        /// Example: 129
        /// </param>
        /// <param name="maximum">
        /// Maximum heart-rate<br/>
        /// Example: 147
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRate(
            int? average,
            int? maximum)
        {
            this.Average = average;
            this.Maximum = maximum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRate" /> class.
        /// </summary>
        public HeartRate()
        {
        }
    }
}