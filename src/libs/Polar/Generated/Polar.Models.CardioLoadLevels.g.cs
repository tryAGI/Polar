
#nullable enable

namespace Polar
{
    /// <summary>
    /// Cardio load levels indicate how hard a training session was compared to your session average from the past 90 days.
    /// </summary>
    public sealed partial class CardioLoadLevels
    {
        /// <summary>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("very_low")]
        public float? VeryLow { get; set; }

        /// <summary>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("low")]
        public float? Low { get; set; }

        /// <summary>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        public float? Medium { get; set; }

        /// <summary>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("high")]
        public float? High { get; set; }

        /// <summary>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("very-high")]
        public float? VeryHigh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CardioLoadLevels" /> class.
        /// </summary>
        /// <param name="veryLow">
        /// Example: 0.1
        /// </param>
        /// <param name="low">
        /// Example: 0.1
        /// </param>
        /// <param name="medium">
        /// Example: 0.1
        /// </param>
        /// <param name="high">
        /// Example: 0.1
        /// </param>
        /// <param name="veryHigh">
        /// Example: 0.1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CardioLoadLevels(
            float? veryLow,
            float? low,
            float? medium,
            float? high,
            float? veryHigh)
        {
            this.VeryLow = veryLow;
            this.Low = low;
            this.Medium = medium;
            this.High = high;
            this.VeryHigh = veryHigh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardioLoadLevels" /> class.
        /// </summary>
        public CardioLoadLevels()
        {
        }
    }
}