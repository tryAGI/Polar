
#nullable enable

namespace Polar
{
    /// <summary>
    /// Training session summary data
    /// </summary>
    public sealed partial class Exercise
    {
        /// <summary>
        /// Id of the training session<br/>
        /// Example: 1937529874
        /// </summary>
        /// <example>1937529874</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Time of the transfer from wrist unit to Polar database<br/>
        /// Example: 2008-10-13T10:40:0.000Z
        /// </summary>
        /// <example>2008-10-13T10:40:0.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload-time")]
        public string? UploadTime { get; set; }

        /// <summary>
        /// Absolute link to Polar user owning the training<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </summary>
        /// <example>https://www.polaraccesslink/v3/users/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("polar-user")]
        public string? PolarUser { get; set; }

        /// <summary>
        /// Id of the exercise-transaction this training was transferred in<br/>
        /// Example: 179879
        /// </summary>
        /// <example>179879</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction-id")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Polar product used in training<br/>
        /// Example: Polar M400
        /// </summary>
        /// <example>Polar M400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        public string? Device { get; set; }

        /// <summary>
        /// Id of the Polar device<br/>
        /// Example: 1111AAAA
        /// </summary>
        /// <example>1111AAAA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("device-id")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// Start time of the training session in local time<br/>
        /// Example: 2008-10-13T10:40:02
        /// </summary>
        /// <example>2008-10-13T10:40:02</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start-time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// The offset from UTC (in minutes) when the training session was started<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start-time-utc-offset")]
        public int? StartTimeUtcOffset { get; set; }

        /// <summary>
        /// The duration of the training session as specified in ISO8601<br/>
        /// Example: PT2H44M45S
        /// </summary>
        /// <example>PT2H44M45S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// Expended calories during training in kilocalories<br/>
        /// Example: 530
        /// </summary>
        /// <example>530</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public int? Calories { get; set; }

        /// <summary>
        /// Distance in meters travelled during training<br/>
        /// Example: 1600.2
        /// </summary>
        /// <example>1600.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// Heart-rate statistics information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart-rate")]
        public global::Polar.HeartRate? HeartRate { get; set; }

        /// <summary>
        /// Training load effect to user<br/>
        /// Example: 143.22
        /// </summary>
        /// <example>143.22</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("training-load")]
        public float? TrainingLoad { get; set; }

        /// <summary>
        /// Sport name<br/>
        /// Example: OTHER
        /// </summary>
        /// <example>OTHER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sport")]
        public string? Sport { get; set; }

        /// <summary>
        /// Boolean indicating if the exercise has route data<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has-route")]
        public bool? HasRoute { get; set; }

        /// <summary>
        /// Has value if the exercise is from "Flow For Club", otherwise not printed. Value -1 indicates that there were errors finding the club<br/>
        /// Example: 999
        /// </summary>
        /// <example>999</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("club-id")]
        public long? ClubId { get; set; }

        /// <summary>
        /// Has value if the exercise is from "Flow For Club", otherwise not printed. Value "Ambiguous club location. Please contact support." is printed in case of error (and the club-id is -1).<br/>
        /// Example: Polar Club
        /// </summary>
        /// <example>Polar Club</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("club-name")]
        public string? ClubName { get; set; }

        /// <summary>
        /// String containing the name of a Polar Flow-compatible sport, if one is set for the exercise.<br/>
        /// Example: RUNNING
        /// </summary>
        /// <example>RUNNING</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailed-sport-info")]
        public string? DetailedSportInfo { get; set; }

        /// <summary>
        /// Fat percentage of exercise calories. Has value if the exercise is from training device supporting Energy sources, otherwise not printed.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fat-percentage")]
        public int? FatPercentage { get; set; }

        /// <summary>
        /// Carbohydrate percentage of exercise calories. Has value if the exercise is from training device supporting Energy sources, otherwise not printed.<br/>
        /// Example: 38
        /// </summary>
        /// <example>38</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("carbohydrate-percentage")]
        public int? CarbohydratePercentage { get; set; }

        /// <summary>
        /// Protein percentage of exercise calories. Has value if the exercise is from training device supporting Energy sources, otherwise not printed.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("protein-percentage")]
        public int? ProteinPercentage { get; set; }

        /// <summary>
        /// &lt;a href="https://support.polar.com/en/support/tips/Running_Index_feature#"&gt;  Running index&lt;/a&gt; is a score automatically calculated every run based on your  heart rate and speed data collected via GPS or stride sensor.<br/>
        /// Example: 51
        /// </summary>
        /// <example>51</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("running-index")]
        public int? RunningIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training-load-pro")]
        public global::Polar.TrainingLoadProSample? TrainingLoadPro { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Exercise" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the training session<br/>
        /// Example: 1937529874
        /// </param>
        /// <param name="uploadTime">
        /// Time of the transfer from wrist unit to Polar database<br/>
        /// Example: 2008-10-13T10:40:0.000Z
        /// </param>
        /// <param name="polarUser">
        /// Absolute link to Polar user owning the training<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </param>
        /// <param name="transactionId">
        /// Id of the exercise-transaction this training was transferred in<br/>
        /// Example: 179879
        /// </param>
        /// <param name="device">
        /// Polar product used in training<br/>
        /// Example: Polar M400
        /// </param>
        /// <param name="deviceId">
        /// Id of the Polar device<br/>
        /// Example: 1111AAAA
        /// </param>
        /// <param name="startTime">
        /// Start time of the training session in local time<br/>
        /// Example: 2008-10-13T10:40:02
        /// </param>
        /// <param name="startTimeUtcOffset">
        /// The offset from UTC (in minutes) when the training session was started<br/>
        /// Example: 180
        /// </param>
        /// <param name="duration">
        /// The duration of the training session as specified in ISO8601<br/>
        /// Example: PT2H44M45S
        /// </param>
        /// <param name="calories">
        /// Expended calories during training in kilocalories<br/>
        /// Example: 530
        /// </param>
        /// <param name="distance">
        /// Distance in meters travelled during training<br/>
        /// Example: 1600.2
        /// </param>
        /// <param name="heartRate">
        /// Heart-rate statistics information
        /// </param>
        /// <param name="trainingLoad">
        /// Training load effect to user<br/>
        /// Example: 143.22
        /// </param>
        /// <param name="sport">
        /// Sport name<br/>
        /// Example: OTHER
        /// </param>
        /// <param name="hasRoute">
        /// Boolean indicating if the exercise has route data<br/>
        /// Example: true
        /// </param>
        /// <param name="clubId">
        /// Has value if the exercise is from "Flow For Club", otherwise not printed. Value -1 indicates that there were errors finding the club<br/>
        /// Example: 999
        /// </param>
        /// <param name="clubName">
        /// Has value if the exercise is from "Flow For Club", otherwise not printed. Value "Ambiguous club location. Please contact support." is printed in case of error (and the club-id is -1).<br/>
        /// Example: Polar Club
        /// </param>
        /// <param name="detailedSportInfo">
        /// String containing the name of a Polar Flow-compatible sport, if one is set for the exercise.<br/>
        /// Example: RUNNING
        /// </param>
        /// <param name="fatPercentage">
        /// Fat percentage of exercise calories. Has value if the exercise is from training device supporting Energy sources, otherwise not printed.<br/>
        /// Example: 60
        /// </param>
        /// <param name="carbohydratePercentage">
        /// Carbohydrate percentage of exercise calories. Has value if the exercise is from training device supporting Energy sources, otherwise not printed.<br/>
        /// Example: 38
        /// </param>
        /// <param name="proteinPercentage">
        /// Protein percentage of exercise calories. Has value if the exercise is from training device supporting Energy sources, otherwise not printed.<br/>
        /// Example: 2
        /// </param>
        /// <param name="runningIndex">
        /// &lt;a href="https://support.polar.com/en/support/tips/Running_Index_feature#"&gt;  Running index&lt;/a&gt; is a score automatically calculated every run based on your  heart rate and speed data collected via GPS or stride sensor.<br/>
        /// Example: 51
        /// </param>
        /// <param name="trainingLoadPro"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Exercise(
            long? id,
            string? uploadTime,
            string? polarUser,
            long? transactionId,
            string? device,
            string? deviceId,
            string? startTime,
            int? startTimeUtcOffset,
            string? duration,
            int? calories,
            float? distance,
            global::Polar.HeartRate? heartRate,
            float? trainingLoad,
            string? sport,
            bool? hasRoute,
            long? clubId,
            string? clubName,
            string? detailedSportInfo,
            int? fatPercentage,
            int? carbohydratePercentage,
            int? proteinPercentage,
            int? runningIndex,
            global::Polar.TrainingLoadProSample? trainingLoadPro)
        {
            this.Id = id;
            this.UploadTime = uploadTime;
            this.PolarUser = polarUser;
            this.TransactionId = transactionId;
            this.Device = device;
            this.DeviceId = deviceId;
            this.StartTime = startTime;
            this.StartTimeUtcOffset = startTimeUtcOffset;
            this.Duration = duration;
            this.Calories = calories;
            this.Distance = distance;
            this.HeartRate = heartRate;
            this.TrainingLoad = trainingLoad;
            this.Sport = sport;
            this.HasRoute = hasRoute;
            this.ClubId = clubId;
            this.ClubName = clubName;
            this.DetailedSportInfo = detailedSportInfo;
            this.FatPercentage = fatPercentage;
            this.CarbohydratePercentage = carbohydratePercentage;
            this.ProteinPercentage = proteinPercentage;
            this.RunningIndex = runningIndex;
            this.TrainingLoadPro = trainingLoadPro;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exercise" /> class.
        /// </summary>
        public Exercise()
        {
        }
    }
}