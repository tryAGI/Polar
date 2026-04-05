
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkinTemperature
    {
        /// <summary>
        /// Example: 36.5
        /// </summary>
        /// <example>36.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_time_skin_temperature_celsius")]
        public float? SleepTimeSkinTemperatureCelsius { get; set; }

        /// <summary>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviation_from_baseline_celsius")]
        public float? DeviationFromBaselineCelsius { get; set; }

        /// <summary>
        /// Example: 2023-10-20
        /// </summary>
        /// <example>2023-10-20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_date")]
        public global::System.DateTime? SleepDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkinTemperature" /> class.
        /// </summary>
        /// <param name="sleepTimeSkinTemperatureCelsius">
        /// Example: 36.5
        /// </param>
        /// <param name="deviationFromBaselineCelsius">
        /// Example: 0.5
        /// </param>
        /// <param name="sleepDate">
        /// Example: 2023-10-20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkinTemperature(
            float? sleepTimeSkinTemperatureCelsius,
            float? deviationFromBaselineCelsius,
            global::System.DateTime? sleepDate)
        {
            this.SleepTimeSkinTemperatureCelsius = sleepTimeSkinTemperatureCelsius;
            this.DeviationFromBaselineCelsius = deviationFromBaselineCelsius;
            this.SleepDate = sleepDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkinTemperature" /> class.
        /// </summary>
        public SkinTemperature()
        {
        }
    }
}