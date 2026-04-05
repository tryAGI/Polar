
#nullable enable

namespace Polar
{
    /// <summary>
    /// Cardio load model.
    /// </summary>
    public sealed partial class CardioLoad
    {
        /// <summary>
        /// Date in format YYYY-MM-DD.<br/>
        /// Example: 2023-01-01
        /// </summary>
        /// <example>2023-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Text representation of cardio load status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardio_load_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.CardioLoadStatusEnumJsonConverter))]
        public global::Polar.CardioLoadStatusEnum? CardioLoadStatus { get; set; }

        /// <summary>
        /// Cardio load (training impulse, TRIMP) shows your cardiac response to a training session.<br/>
        /// Example: 0.2
        /// </summary>
        /// <example>0.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardio_load")]
        public float? CardioLoad1 { get; set; }

        /// <summary>
        /// Strain shows how much you have strained yourself with training lately. It shows your average daily load from the past 7 days.<br/>
        /// Example: 0.3
        /// </summary>
        /// <example>0.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain")]
        public float? Strain { get; set; }

        /// <summary>
        /// Tolerance describes how prepared you are to endure cardio training. It shows your average daily load from the past 28 days.<br/>
        /// Example: 0.4
        /// </summary>
        /// <example>0.4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tolerance")]
        public float? Tolerance { get; set; }

        /// <summary>
        /// Ratio between strain and tolerance.<br/>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardio_load_ratio")]
        public float? CardioLoadRatio { get; set; }

        /// <summary>
        /// Cardio load levels indicate how hard a training session was compared to your session average from the past 90 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardio_load_level")]
        public global::Polar.CardioLoadLevels? CardioLoadLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CardioLoad" /> class.
        /// </summary>
        /// <param name="date">
        /// Date in format YYYY-MM-DD.<br/>
        /// Example: 2023-01-01
        /// </param>
        /// <param name="cardioLoadStatus">
        /// Text representation of cardio load status.
        /// </param>
        /// <param name="cardioLoad1">
        /// Cardio load (training impulse, TRIMP) shows your cardiac response to a training session.<br/>
        /// Example: 0.2
        /// </param>
        /// <param name="strain">
        /// Strain shows how much you have strained yourself with training lately. It shows your average daily load from the past 7 days.<br/>
        /// Example: 0.3
        /// </param>
        /// <param name="tolerance">
        /// Tolerance describes how prepared you are to endure cardio training. It shows your average daily load from the past 28 days.<br/>
        /// Example: 0.4
        /// </param>
        /// <param name="cardioLoadRatio">
        /// Ratio between strain and tolerance.<br/>
        /// Example: 0.1
        /// </param>
        /// <param name="cardioLoadLevel">
        /// Cardio load levels indicate how hard a training session was compared to your session average from the past 90 days.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CardioLoad(
            global::System.DateTime? date,
            global::Polar.CardioLoadStatusEnum? cardioLoadStatus,
            float? cardioLoad1,
            float? strain,
            float? tolerance,
            float? cardioLoadRatio,
            global::Polar.CardioLoadLevels? cardioLoadLevel)
        {
            this.Date = date;
            this.CardioLoadStatus = cardioLoadStatus;
            this.CardioLoad1 = cardioLoad1;
            this.Strain = strain;
            this.Tolerance = tolerance;
            this.CardioLoadRatio = cardioLoadRatio;
            this.CardioLoadLevel = cardioLoadLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardioLoad" /> class.
        /// </summary>
        public CardioLoad()
        {
        }
    }
}