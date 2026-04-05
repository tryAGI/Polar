
#nullable enable

namespace Polar
{
    /// <summary>
    /// User's physical information
    /// </summary>
    public sealed partial class PhysicalInformation
    {
        /// <summary>
        /// Physical information id<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Id of the physical-information-transaction this training was transferred in<br/>
        /// Example: 179879
        /// </summary>
        /// <example>179879</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction-id")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// The time physical information was created in AccessLink, in format YYYY-MM-DDTHH:mm:ss.SSSZ<br/>
        /// Example: 2016-04-27T20:11:33.000Z
        /// </summary>
        /// <example>2016-04-27T20:11:33.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Absolute link to user owning the activity<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </summary>
        /// <example>https://www.polaraccesslink/v3/users/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("polar-user")]
        public string? PolarUser { get; set; }

        /// <summary>
        /// Weight<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Height<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public float? Height { get; set; }

        /// <summary>
        /// Maximum heart rate<br/>
        /// Example: 160
        /// </summary>
        /// <example>160</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum-heart-rate")]
        public int? MaximumHeartRate { get; set; }

        /// <summary>
        /// Resting hear rate<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resting-heart-rate")]
        public int? RestingHeartRate { get; set; }

        /// <summary>
        /// Aerobic threshold<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aerobic-threshold")]
        public int? AerobicThreshold { get; set; }

        /// <summary>
        /// Anaerobic threshold<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("anaerobic-threshold")]
        public int? AnaerobicThreshold { get; set; }

        /// <summary>
        /// VO2 max<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vo2-max")]
        public int? Vo2Max { get; set; }

        /// <summary>
        /// Weight source<br/>
        /// Example: SOURCE_MEASURED
        /// </summary>
        /// <example>SOURCE_MEASURED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight-source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.PhysicalInformationWeightSourceJsonConverter))]
        public global::Polar.PhysicalInformationWeightSource? WeightSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalInformation" /> class.
        /// </summary>
        /// <param name="id">
        /// Physical information id<br/>
        /// Example: 123
        /// </param>
        /// <param name="transactionId">
        /// Id of the physical-information-transaction this training was transferred in<br/>
        /// Example: 179879
        /// </param>
        /// <param name="created">
        /// The time physical information was created in AccessLink, in format YYYY-MM-DDTHH:mm:ss.SSSZ<br/>
        /// Example: 2016-04-27T20:11:33.000Z
        /// </param>
        /// <param name="polarUser">
        /// Absolute link to user owning the activity<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </param>
        /// <param name="weight">
        /// Weight<br/>
        /// Example: 80
        /// </param>
        /// <param name="height">
        /// Height<br/>
        /// Example: 180
        /// </param>
        /// <param name="maximumHeartRate">
        /// Maximum heart rate<br/>
        /// Example: 160
        /// </param>
        /// <param name="restingHeartRate">
        /// Resting hear rate<br/>
        /// Example: 60
        /// </param>
        /// <param name="aerobicThreshold">
        /// Aerobic threshold<br/>
        /// Example: 123
        /// </param>
        /// <param name="anaerobicThreshold">
        /// Anaerobic threshold<br/>
        /// Example: 123
        /// </param>
        /// <param name="vo2Max">
        /// VO2 max<br/>
        /// Example: 12
        /// </param>
        /// <param name="weightSource">
        /// Weight source<br/>
        /// Example: SOURCE_MEASURED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhysicalInformation(
            long? id,
            long? transactionId,
            string? created,
            string? polarUser,
            float? weight,
            float? height,
            int? maximumHeartRate,
            int? restingHeartRate,
            int? aerobicThreshold,
            int? anaerobicThreshold,
            int? vo2Max,
            global::Polar.PhysicalInformationWeightSource? weightSource)
        {
            this.Id = id;
            this.TransactionId = transactionId;
            this.Created = created;
            this.PolarUser = polarUser;
            this.Weight = weight;
            this.Height = height;
            this.MaximumHeartRate = maximumHeartRate;
            this.RestingHeartRate = restingHeartRate;
            this.AerobicThreshold = aerobicThreshold;
            this.AnaerobicThreshold = anaerobicThreshold;
            this.Vo2Max = vo2Max;
            this.WeightSource = weightSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalInformation" /> class.
        /// </summary>
        public PhysicalInformation()
        {
        }
    }
}