
#nullable enable

namespace Polar
{
    /// <summary>
    /// 5 min average samples of heart rate from the duration of the continuous heart rate measurement. Default  time between samples is 5 minutes. There may be periods with samples more often than every 5 minutes.  Unit of samples is beats per minute (bpm).  <br/>
    /// Example: {"polar_user":"https://polaraccesslink.com/v3/users/627139","date":"2022-09-12","heart_rate_samples":[{"heart_rate":63,"sample_time":"00:02:08"},{"heart_rate":62,"sample_time":"00:07:08"}]}
    /// </summary>
    public sealed partial class ContinuousHeartrate
    {
        /// <summary>
        /// Absolute link to user owning the continuous heart rate samples<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </summary>
        /// <example>https://www.polaraccesslink/v3/users/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("polar_user")]
        public string? PolarUser { get; set; }

        /// <summary>
        /// Result date of the Continuous Heart Rate<br/>
        /// Example: 2020-01-01
        /// </summary>
        /// <example>2020-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_samples")]
        public global::Polar.ContinuousHeartrateHeartRateSamples? HeartRateSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousHeartrate" /> class.
        /// </summary>
        /// <param name="polarUser">
        /// Absolute link to user owning the continuous heart rate samples<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </param>
        /// <param name="date">
        /// Result date of the Continuous Heart Rate<br/>
        /// Example: 2020-01-01
        /// </param>
        /// <param name="heartRateSamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContinuousHeartrate(
            string? polarUser,
            global::System.DateTime? date,
            global::Polar.ContinuousHeartrateHeartRateSamples? heartRateSamples)
        {
            this.PolarUser = polarUser;
            this.Date = date;
            this.HeartRateSamples = heartRateSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousHeartrate" /> class.
        /// </summary>
        public ContinuousHeartrate()
        {
        }
    }
}