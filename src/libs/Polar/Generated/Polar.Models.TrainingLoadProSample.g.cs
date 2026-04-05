
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingLoadProSample
    {
        /// <summary>
        /// Date in format YYYY-MM-DD.<br/>
        /// Example: 2023-01-01
        /// </summary>
        /// <example>2023-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// User cardio load value.<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardio-load")]
        public float? CardioLoad { get; set; }

        /// <summary>
        /// User muscle load value.<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("muscle-load")]
        public float? MuscleLoad { get; set; }

        /// <summary>
        /// User perceived load value.<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("perceived-load")]
        public float? PerceivedLoad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardio-load-interpretation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.TrainingLoadProLoadEnumJsonConverter))]
        public global::Polar.TrainingLoadProLoadEnum? CardioLoadInterpretation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("muscle-load-interpretation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.TrainingLoadProLoadEnumJsonConverter))]
        public global::Polar.TrainingLoadProLoadEnum? MuscleLoadInterpretation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perceived-load-interpretation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.TrainingLoadProLoadEnumJsonConverter))]
        public global::Polar.TrainingLoadProLoadEnum? PerceivedLoadInterpretation { get; set; }

        /// <summary>
        /// Quantifies internal training load of a session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user-rpe")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.TrainingLoadProRpeEnumJsonConverter))]
        public global::Polar.TrainingLoadProRpeEnum? UserRpe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingLoadProSample" /> class.
        /// </summary>
        /// <param name="date">
        /// Date in format YYYY-MM-DD.<br/>
        /// Example: 2023-01-01
        /// </param>
        /// <param name="cardioLoad">
        /// User cardio load value.<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="muscleLoad">
        /// User muscle load value.<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="perceivedLoad">
        /// User perceived load value.<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="cardioLoadInterpretation"></param>
        /// <param name="muscleLoadInterpretation"></param>
        /// <param name="perceivedLoadInterpretation"></param>
        /// <param name="userRpe">
        /// Quantifies internal training load of a session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingLoadProSample(
            global::System.DateTime? date,
            float? cardioLoad,
            float? muscleLoad,
            float? perceivedLoad,
            global::Polar.TrainingLoadProLoadEnum? cardioLoadInterpretation,
            global::Polar.TrainingLoadProLoadEnum? muscleLoadInterpretation,
            global::Polar.TrainingLoadProLoadEnum? perceivedLoadInterpretation,
            global::Polar.TrainingLoadProRpeEnum? userRpe)
        {
            this.Date = date;
            this.CardioLoad = cardioLoad;
            this.MuscleLoad = muscleLoad;
            this.PerceivedLoad = perceivedLoad;
            this.CardioLoadInterpretation = cardioLoadInterpretation;
            this.MuscleLoadInterpretation = muscleLoadInterpretation;
            this.PerceivedLoadInterpretation = perceivedLoadInterpretation;
            this.UserRpe = userRpe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingLoadProSample" /> class.
        /// </summary>
        public TrainingLoadProSample()
        {
        }
    }
}