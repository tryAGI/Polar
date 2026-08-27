
#nullable enable

namespace Polar
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhysicalInfo
    {
        /// <summary>
        /// User's weight in kilograms.<br/>
        /// Example: 70.5
        /// </summary>
        /// <example>70.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// User's height in centimeters.<br/>
        /// Example: 175.0
        /// </summary>
        /// <example>175.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public float? Height { get; set; }

        /// <summary>
        /// Creation timestamp of the physical info.<br/>
        /// Example: 2024-06-01T12:00:00Z
        /// </summary>
        /// <example>2024-06-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Last modification timestamp of the physical info.<br/>
        /// Example: 2024-06-10T12:00:00Z
        /// </summary>
        /// <example>2024-06-10T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        public global::System.DateTime? Modified { get; set; }

        /// <summary>
        /// User's date of birth.<br/>
        /// Example: 1990-01-01
        /// </summary>
        /// <example>1990-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("birthday")]
        public global::System.DateTime? Birthday { get; set; }

        /// <summary>
        /// User's gender.<br/>
        /// Example: MALE
        /// </summary>
        /// <example>MALE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.PhysicalInfoGenderJsonConverter))]
        public global::Polar.PhysicalInfoGender? Gender { get; set; }

        /// <summary>
        /// User's maximum heart rate.<br/>
        /// Example: 190
        /// </summary>
        /// <example>190</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_heart_rate")]
        public int? MaximumHeartRate { get; set; }

        /// <summary>
        /// User's resting heart rate.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resting_heart_rate")]
        public int? RestingHeartRate { get; set; }

        /// <summary>
        /// User's aerobic threshold.<br/>
        /// Example: 140
        /// </summary>
        /// <example>140</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aerobic_threshold")]
        public int? AerobicThreshold { get; set; }

        /// <summary>
        /// User's anaerobic threshold.<br/>
        /// Example: 170
        /// </summary>
        /// <example>170</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("anaerobic_threshold")]
        public int? AnaerobicThreshold { get; set; }

        /// <summary>
        /// User's VO2 max value.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vo2_max")]
        public int? Vo2Max { get; set; }

        /// <summary>
        /// Source of the weight information.<br/>
        /// Example: SOURCE_USER
        /// </summary>
        /// <example>SOURCE_USER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.PhysicalInfoWeightSourceJsonConverter))]
        public global::Polar.PhysicalInfoWeightSource? WeightSource { get; set; }

        /// <summary>
        /// User's training background.<br/>
        /// Example: REGULAR
        /// </summary>
        /// <example>REGULAR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.PhysicalInfoTrainingBackgroundJsonConverter))]
        public global::Polar.PhysicalInfoTrainingBackground? TrainingBackground { get; set; }

        /// <summary>
        /// User's typical day description.<br/>
        /// Example: MOSTLY_MOVING
        /// </summary>
        /// <example>MOSTLY_MOVING</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("typical_day")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.PhysicalInfoTypicalDayJsonConverter))]
        public global::Polar.PhysicalInfoTypicalDay? TypicalDay { get; set; }

        /// <summary>
        /// User's sleep goal as ISO 8601 duration.<br/>
        /// Example: PT8H
        /// </summary>
        /// <example>PT8H</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_goal")]
        public string? SleepGoal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalInfo" /> class.
        /// </summary>
        /// <param name="weight">
        /// User's weight in kilograms.<br/>
        /// Example: 70.5
        /// </param>
        /// <param name="height">
        /// User's height in centimeters.<br/>
        /// Example: 175.0
        /// </param>
        /// <param name="created">
        /// Creation timestamp of the physical info.<br/>
        /// Example: 2024-06-01T12:00:00Z
        /// </param>
        /// <param name="modified">
        /// Last modification timestamp of the physical info.<br/>
        /// Example: 2024-06-10T12:00:00Z
        /// </param>
        /// <param name="birthday">
        /// User's date of birth.<br/>
        /// Example: 1990-01-01
        /// </param>
        /// <param name="gender">
        /// User's gender.<br/>
        /// Example: MALE
        /// </param>
        /// <param name="maximumHeartRate">
        /// User's maximum heart rate.<br/>
        /// Example: 190
        /// </param>
        /// <param name="restingHeartRate">
        /// User's resting heart rate.<br/>
        /// Example: 60
        /// </param>
        /// <param name="aerobicThreshold">
        /// User's aerobic threshold.<br/>
        /// Example: 140
        /// </param>
        /// <param name="anaerobicThreshold">
        /// User's anaerobic threshold.<br/>
        /// Example: 170
        /// </param>
        /// <param name="vo2Max">
        /// User's VO2 max value.<br/>
        /// Example: 50
        /// </param>
        /// <param name="weightSource">
        /// Source of the weight information.<br/>
        /// Example: SOURCE_USER
        /// </param>
        /// <param name="trainingBackground">
        /// User's training background.<br/>
        /// Example: REGULAR
        /// </param>
        /// <param name="typicalDay">
        /// User's typical day description.<br/>
        /// Example: MOSTLY_MOVING
        /// </param>
        /// <param name="sleepGoal">
        /// User's sleep goal as ISO 8601 duration.<br/>
        /// Example: PT8H
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhysicalInfo(
            float? weight,
            float? height,
            global::System.DateTime? created,
            global::System.DateTime? modified,
            global::System.DateTime? birthday,
            global::Polar.PhysicalInfoGender? gender,
            int? maximumHeartRate,
            int? restingHeartRate,
            int? aerobicThreshold,
            int? anaerobicThreshold,
            int? vo2Max,
            global::Polar.PhysicalInfoWeightSource? weightSource,
            global::Polar.PhysicalInfoTrainingBackground? trainingBackground,
            global::Polar.PhysicalInfoTypicalDay? typicalDay,
            string? sleepGoal)
        {
            this.Weight = weight;
            this.Height = height;
            this.Created = created;
            this.Modified = modified;
            this.Birthday = birthday;
            this.Gender = gender;
            this.MaximumHeartRate = maximumHeartRate;
            this.RestingHeartRate = restingHeartRate;
            this.AerobicThreshold = aerobicThreshold;
            this.AnaerobicThreshold = anaerobicThreshold;
            this.Vo2Max = vo2Max;
            this.WeightSource = weightSource;
            this.TrainingBackground = trainingBackground;
            this.TypicalDay = typicalDay;
            this.SleepGoal = sleepGoal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalInfo" /> class.
        /// </summary>
        public PhysicalInfo()
        {
        }

    }
}