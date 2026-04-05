
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NightlyRecharge
    {
        /// <summary>
        /// Absolute link to user owning the sleep<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </summary>
        /// <example>https://www.polaraccesslink/v3/users/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("polar_user")]
        public string? PolarUser { get; set; }

        /// <summary>
        /// Result date of the Nightly Recharge<br/>
        /// Example: 2020-01-01
        /// </summary>
        /// <example>2020-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Average heart rate as beats per minute (bpm) during a 4-hour period starting at 30 minutes after falling asleep.<br/>
        /// Example: 70
        /// </summary>
        /// <example>70</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_avg")]
        public int? HeartRateAvg { get; set; }

        /// <summary>
        /// Average time in milliseconds (ms) between successive heart beats during a 4-hour period starting at 30 minutes after falling asleep.<br/>
        /// Example: 816
        /// </summary>
        /// <example>816</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("beat_to_beat_avg")]
        public int? BeatToBeatAvg { get; set; }

        /// <summary>
        /// Average variation in the time in milliseconds (ms) between successive heart beats during a 4-hour period starting at 30 minutes after falling asleep. The Heart rate variability is Root Mean Square of Successive Differences (RMSSD) in beat-to-beat intervals.<br/>
        /// Example: 28
        /// </summary>
        /// <example>28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_variability_avg")]
        public int? HeartRateVariabilityAvg { get; set; }

        /// <summary>
        /// Average breathing rate as breaths per minute (bpm) during a 4-hour period starting at 30 minutes after falling asleep.<br/>
        /// Example: 14.1
        /// </summary>
        /// <example>14.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("breathing_rate_avg")]
        public float? BreathingRateAvg { get; set; }

        /// <summary>
        /// The Nightly Recharge status shows how your body was able to recover from training and stress during the night. Scores for both ANS charge and sleep charge are taken into account. Nightly Recharge status has the following (6-item) scale: very poor (1) – poor (2) – compromised (3) – OK (4) – good (5) – very good (6).<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nightly_recharge_status")]
        public int? NightlyRechargeStatus { get; set; }

        /// <summary>
        /// ANS stands for autonomic nervous system. ANS charge is formed by measuring heart rate, heart rate variability and breathing rate during roughly the first four hours of your sleep. It is formed comparing your last night to your usual levels from the past 28 days. The scale is from -10.0 to +10.0. Around zero is your usual level.<br/>
        /// Example: 0.0
        /// </summary>
        /// <example>0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ans_charge")]
        public float? AnsCharge { get; set; }

        /// <summary>
        /// ANS charge status = much below usual (1) - below usual (2) - usual (3) - above usual (4) - much above usual (5)<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ans_charge_status")]
        public int? AnsChargeStatus { get; set; }

        /// <summary>
        /// 5-minute average samples of heart rate variability. Unit of samples is milliseconds(ms).<br/>
        /// Example: {"00:41":14,"00:46":14,"00:51":15}
        /// </summary>
        /// <example>{"00:41":14,"00:46":14,"00:51":15}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_samples")]
        public object? HrvSamples { get; set; }

        /// <summary>
        /// 5-minute average samples of breathing rate. Unit of samples is breaths per minute (bpm).<br/>
        /// Example: {"00:39":13.4,"00:44":13.5,"00:49":13.5}
        /// </summary>
        /// <example>{"00:39":13.4,"00:44":13.5,"00:49":13.5}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("breathing_samples")]
        public object? BreathingSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NightlyRecharge" /> class.
        /// </summary>
        /// <param name="polarUser">
        /// Absolute link to user owning the sleep<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </param>
        /// <param name="date">
        /// Result date of the Nightly Recharge<br/>
        /// Example: 2020-01-01
        /// </param>
        /// <param name="heartRateAvg">
        /// Average heart rate as beats per minute (bpm) during a 4-hour period starting at 30 minutes after falling asleep.<br/>
        /// Example: 70
        /// </param>
        /// <param name="beatToBeatAvg">
        /// Average time in milliseconds (ms) between successive heart beats during a 4-hour period starting at 30 minutes after falling asleep.<br/>
        /// Example: 816
        /// </param>
        /// <param name="heartRateVariabilityAvg">
        /// Average variation in the time in milliseconds (ms) between successive heart beats during a 4-hour period starting at 30 minutes after falling asleep. The Heart rate variability is Root Mean Square of Successive Differences (RMSSD) in beat-to-beat intervals.<br/>
        /// Example: 28
        /// </param>
        /// <param name="breathingRateAvg">
        /// Average breathing rate as breaths per minute (bpm) during a 4-hour period starting at 30 minutes after falling asleep.<br/>
        /// Example: 14.1
        /// </param>
        /// <param name="nightlyRechargeStatus">
        /// The Nightly Recharge status shows how your body was able to recover from training and stress during the night. Scores for both ANS charge and sleep charge are taken into account. Nightly Recharge status has the following (6-item) scale: very poor (1) – poor (2) – compromised (3) – OK (4) – good (5) – very good (6).<br/>
        /// Example: 3
        /// </param>
        /// <param name="ansCharge">
        /// ANS stands for autonomic nervous system. ANS charge is formed by measuring heart rate, heart rate variability and breathing rate during roughly the first four hours of your sleep. It is formed comparing your last night to your usual levels from the past 28 days. The scale is from -10.0 to +10.0. Around zero is your usual level.<br/>
        /// Example: 0.0
        /// </param>
        /// <param name="ansChargeStatus">
        /// ANS charge status = much below usual (1) - below usual (2) - usual (3) - above usual (4) - much above usual (5)<br/>
        /// Example: 3
        /// </param>
        /// <param name="hrvSamples">
        /// 5-minute average samples of heart rate variability. Unit of samples is milliseconds(ms).<br/>
        /// Example: {"00:41":14,"00:46":14,"00:51":15}
        /// </param>
        /// <param name="breathingSamples">
        /// 5-minute average samples of breathing rate. Unit of samples is breaths per minute (bpm).<br/>
        /// Example: {"00:39":13.4,"00:44":13.5,"00:49":13.5}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NightlyRecharge(
            string? polarUser,
            global::System.DateTime? date,
            int? heartRateAvg,
            int? beatToBeatAvg,
            int? heartRateVariabilityAvg,
            float? breathingRateAvg,
            int? nightlyRechargeStatus,
            float? ansCharge,
            int? ansChargeStatus,
            object? hrvSamples,
            object? breathingSamples)
        {
            this.PolarUser = polarUser;
            this.Date = date;
            this.HeartRateAvg = heartRateAvg;
            this.BeatToBeatAvg = beatToBeatAvg;
            this.HeartRateVariabilityAvg = heartRateVariabilityAvg;
            this.BreathingRateAvg = breathingRateAvg;
            this.NightlyRechargeStatus = nightlyRechargeStatus;
            this.AnsCharge = ansCharge;
            this.AnsChargeStatus = ansChargeStatus;
            this.HrvSamples = hrvSamples;
            this.BreathingSamples = breathingSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NightlyRecharge" /> class.
        /// </summary>
        public NightlyRecharge()
        {
        }
    }
}