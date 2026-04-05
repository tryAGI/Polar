
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sleep
    {
        /// <summary>
        /// Absolute link to user owning the sleep<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </summary>
        /// <example>https://www.polaraccesslink/v3/users/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("polar_user")]
        public string? PolarUser { get; set; }

        /// <summary>
        /// Result date of the sleep<br/>
        /// Example: 2020-01-01
        /// </summary>
        /// <example>2020-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Start timestamp of the sleep as ISO-8601 datetime string<br/>
        /// Example: 2020-01-01T00:39:07+03:00
        /// </summary>
        /// <example>2020-01-01T00:39:07+03:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_start_time")]
        public global::System.DateTime? SleepStartTime { get; set; }

        /// <summary>
        /// End timestamp of the sleep as ISO-8601 datetime string<br/>
        /// Example: 2020-01-01T09:19:37+03:00
        /// </summary>
        /// <example>2020-01-01T09:19:37+03:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_end_time")]
        public global::System.DateTime? SleepEndTime { get; set; }

        /// <summary>
        /// Id of the device the sleep was measured with<br/>
        /// Example: 1111AAAA
        /// </summary>
        /// <example>1111AAAA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_id")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// Continuity is an estimate of how continuous the sleep was on a scale of 1.0 – 5.0, where 5.0 reflects uninterrupted sleep. The lower the value the more fragmented the sleep was.<br/>
        /// Example: 2.1
        /// </summary>
        /// <example>2.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuity")]
        public float? Continuity { get; set; }

        /// <summary>
        /// Verbal assessments of sleep continuity Very continuous sleep (5) Continuous sleep (4) Fairly continuous sleep (3) Fairly fragmented sleep (2) Fragmented sleep (1)<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuity_class")]
        public int? ContinuityClass { get; set; }

        /// <summary>
        /// Total time in seconds spent in light sleep stage between when you fell asleep and when you woke up. Corresponds to N1+ N2 according to AASM classification.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("light_sleep")]
        public int? LightSleep { get; set; }

        /// <summary>
        /// Total time in seconds spent in the deep sleep stage between when you fell asleep and when you woke up. Corresponds to N3 according to AASM classification.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_sleep")]
        public int? DeepSleep { get; set; }

        /// <summary>
        /// Total time in seconds spent in REM sleep stage between when you fell asleep and when you woke up. REM stands for rapid eye movement.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rem_sleep")]
        public int? RemSleep { get; set; }

        /// <summary>
        /// Total time in seconds spent in unrecognised sleep stage. Sometimes it's impossible to recognize sleep stages. This might happen when, for example, the wrist strap is not tight enough, or if you sleep on your hand.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unrecognized_sleep_stage")]
        public int? UnrecognizedSleepStage { get; set; }

        /// <summary>
        /// Sleep score summarizes the amount and quality of your sleep into a single number on a scale of 1 – 100. Sleep score tells you how well you slept compared to the indicators of a good night's sleep based on the current sleep science. It consists of six components; sleep time, long interruptions, continuity, actual sleep, REM sleep, and deep sleep.<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_score")]
        public int? SleepScore { get; set; }

        /// <summary>
        /// The total time in seconds you spent awake between when you fell asleep and when you woke up.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_interruption_duration")]
        public int? TotalInterruptionDuration { get; set; }

        /// <summary>
        /// Sleep score compared to your usual level from the past 28 days.Scale: much below usual (1) – below usual (2) – usual (3) – above usual (4) – much above usual(5).<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_charge")]
        public int? SleepCharge { get; set; }

        /// <summary>
        /// Time goal in seconds for sleep selectedby user. A default value of the setting is based on age-related sleep duration recommendations.<br/>
        /// Example: 28800
        /// </summary>
        /// <example>28800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_goal")]
        public int? SleepGoal { get; set; }

        /// <summary>
        /// Numeric value given by user for representing the quality of sleep. Selection scale: Very poorly(1), poorly(2), ok(3), well(4), very well(5). 0 means no value is given.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_rating")]
        public int? SleepRating { get; set; }

        /// <summary>
        /// Total time in seconds of short interruptions. Short interruption is interruption in sleep of less than 90 seconds.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_interruption_duration")]
        public int? ShortInterruptionDuration { get; set; }

        /// <summary>
        /// Total time in seconds of long interruptions. Long interruption is interruption in sleep of 90 seconds or more.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_interruption_duration")]
        public int? LongInterruptionDuration { get; set; }

        /// <summary>
        /// Number of sleep cycles.<br/>
        /// Example: 6
        /// </summary>
        /// <example>6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_cycles")]
        public int? SleepCycles { get; set; }

        /// <summary>
        /// Sleep score consists of six components that are grouped under three themes. Score for sleep duration theme looks at your sleep time compared to your ‘preferred sleep time’ setting and the age-related duration recommendations. Group duration score ranges from 1.0 to 100.0. It is interpreted as textual feedback: poor, moderate or good amount.<br/>
        /// Example: 100.0
        /// </summary>
        /// <example>100.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_duration_score")]
        public float? GroupDurationScore { get; set; }

        /// <summary>
        /// Sleep score consists of six components that are grouped under three themes. Score for sleep solidity theme is the average of the component scores of long interruptions, continuity and actual sleep. Group solidity score ranges from 1.0 to 100.0. It is interpreted as textual feedback: poor, moderate or good solidity.<br/>
        /// Example: 75.0
        /// </summary>
        /// <example>75.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_solidity_score")]
        public float? GroupSolidityScore { get; set; }

        /// <summary>
        /// Sleep score consists of six components that are grouped under three themes. Score for regeneration theme is the average of the scores of REM sleep and deep sleep. Group regeneration score ranges from 1.0 to 100.0. It is interpreted as textual feedback: poor, moderate or good regeneration<br/>
        /// Example: 54.2
        /// </summary>
        /// <example>54.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_regeneration_score")]
        public float? GroupRegenerationScore { get; set; }

        /// <summary>
        /// The time span between when you fell asleep and when you woke up is classified into light, deep or REM sleep, or unrecognised or wake in 30-s epochs.<br/>
        /// 0 = WAKE, 1 = REM, 2 = LIGHTER NON-REM, 3 = LIGHT NON-REM, 4 = DEEP NON-REM, 5 = UNKNOWN (eg. due to bad skin contact).<br/>
        /// Example: {"00:39":2,"00:50":3,"01:23":6}
        /// </summary>
        /// <example>{"00:39":2,"00:50":3,"01:23":6}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypnogram")]
        public object? Hypnogram { get; set; }

        /// <summary>
        /// 5 min average samples of heart rate from the duration of the sleep. Default time between samples is 5 minutes. There may be periods with samples more often than every 5 minutes. Unit of samples is beats per minute (bpm).<br/>
        /// Example: {"00:41":76,"00:46":77,"00:51":76}
        /// </summary>
        /// <example>{"00:41":76,"00:46":77,"00:51":76}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_samples")]
        public object? HeartRateSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep" /> class.
        /// </summary>
        /// <param name="polarUser">
        /// Absolute link to user owning the sleep<br/>
        /// Example: https://www.polaraccesslink/v3/users/1
        /// </param>
        /// <param name="date">
        /// Result date of the sleep<br/>
        /// Example: 2020-01-01
        /// </param>
        /// <param name="sleepStartTime">
        /// Start timestamp of the sleep as ISO-8601 datetime string<br/>
        /// Example: 2020-01-01T00:39:07+03:00
        /// </param>
        /// <param name="sleepEndTime">
        /// End timestamp of the sleep as ISO-8601 datetime string<br/>
        /// Example: 2020-01-01T09:19:37+03:00
        /// </param>
        /// <param name="deviceId">
        /// Id of the device the sleep was measured with<br/>
        /// Example: 1111AAAA
        /// </param>
        /// <param name="continuity">
        /// Continuity is an estimate of how continuous the sleep was on a scale of 1.0 – 5.0, where 5.0 reflects uninterrupted sleep. The lower the value the more fragmented the sleep was.<br/>
        /// Example: 2.1
        /// </param>
        /// <param name="continuityClass">
        /// Verbal assessments of sleep continuity Very continuous sleep (5) Continuous sleep (4) Fairly continuous sleep (3) Fairly fragmented sleep (2) Fragmented sleep (1)<br/>
        /// Example: 2
        /// </param>
        /// <param name="lightSleep">
        /// Total time in seconds spent in light sleep stage between when you fell asleep and when you woke up. Corresponds to N1+ N2 according to AASM classification.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="deepSleep">
        /// Total time in seconds spent in the deep sleep stage between when you fell asleep and when you woke up. Corresponds to N3 according to AASM classification.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="remSleep">
        /// Total time in seconds spent in REM sleep stage between when you fell asleep and when you woke up. REM stands for rapid eye movement.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="unrecognizedSleepStage">
        /// Total time in seconds spent in unrecognised sleep stage. Sometimes it's impossible to recognize sleep stages. This might happen when, for example, the wrist strap is not tight enough, or if you sleep on your hand.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="sleepScore">
        /// Sleep score summarizes the amount and quality of your sleep into a single number on a scale of 1 – 100. Sleep score tells you how well you slept compared to the indicators of a good night's sleep based on the current sleep science. It consists of six components; sleep time, long interruptions, continuity, actual sleep, REM sleep, and deep sleep.<br/>
        /// Example: 80
        /// </param>
        /// <param name="totalInterruptionDuration">
        /// The total time in seconds you spent awake between when you fell asleep and when you woke up.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="sleepCharge">
        /// Sleep score compared to your usual level from the past 28 days.Scale: much below usual (1) – below usual (2) – usual (3) – above usual (4) – much above usual(5).<br/>
        /// Example: 3
        /// </param>
        /// <param name="sleepGoal">
        /// Time goal in seconds for sleep selectedby user. A default value of the setting is based on age-related sleep duration recommendations.<br/>
        /// Example: 28800
        /// </param>
        /// <param name="sleepRating">
        /// Numeric value given by user for representing the quality of sleep. Selection scale: Very poorly(1), poorly(2), ok(3), well(4), very well(5). 0 means no value is given.<br/>
        /// Example: 3
        /// </param>
        /// <param name="shortInterruptionDuration">
        /// Total time in seconds of short interruptions. Short interruption is interruption in sleep of less than 90 seconds.<br/>
        /// Example: 500
        /// </param>
        /// <param name="longInterruptionDuration">
        /// Total time in seconds of long interruptions. Long interruption is interruption in sleep of 90 seconds or more.<br/>
        /// Example: 300
        /// </param>
        /// <param name="sleepCycles">
        /// Number of sleep cycles.<br/>
        /// Example: 6
        /// </param>
        /// <param name="groupDurationScore">
        /// Sleep score consists of six components that are grouped under three themes. Score for sleep duration theme looks at your sleep time compared to your ‘preferred sleep time’ setting and the age-related duration recommendations. Group duration score ranges from 1.0 to 100.0. It is interpreted as textual feedback: poor, moderate or good amount.<br/>
        /// Example: 100.0
        /// </param>
        /// <param name="groupSolidityScore">
        /// Sleep score consists of six components that are grouped under three themes. Score for sleep solidity theme is the average of the component scores of long interruptions, continuity and actual sleep. Group solidity score ranges from 1.0 to 100.0. It is interpreted as textual feedback: poor, moderate or good solidity.<br/>
        /// Example: 75.0
        /// </param>
        /// <param name="groupRegenerationScore">
        /// Sleep score consists of six components that are grouped under three themes. Score for regeneration theme is the average of the scores of REM sleep and deep sleep. Group regeneration score ranges from 1.0 to 100.0. It is interpreted as textual feedback: poor, moderate or good regeneration<br/>
        /// Example: 54.2
        /// </param>
        /// <param name="hypnogram">
        /// The time span between when you fell asleep and when you woke up is classified into light, deep or REM sleep, or unrecognised or wake in 30-s epochs.<br/>
        /// 0 = WAKE, 1 = REM, 2 = LIGHTER NON-REM, 3 = LIGHT NON-REM, 4 = DEEP NON-REM, 5 = UNKNOWN (eg. due to bad skin contact).<br/>
        /// Example: {"00:39":2,"00:50":3,"01:23":6}
        /// </param>
        /// <param name="heartRateSamples">
        /// 5 min average samples of heart rate from the duration of the sleep. Default time between samples is 5 minutes. There may be periods with samples more often than every 5 minutes. Unit of samples is beats per minute (bpm).<br/>
        /// Example: {"00:41":76,"00:46":77,"00:51":76}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sleep(
            string? polarUser,
            global::System.DateTime? date,
            global::System.DateTime? sleepStartTime,
            global::System.DateTime? sleepEndTime,
            string? deviceId,
            float? continuity,
            int? continuityClass,
            int? lightSleep,
            int? deepSleep,
            int? remSleep,
            int? unrecognizedSleepStage,
            int? sleepScore,
            int? totalInterruptionDuration,
            int? sleepCharge,
            int? sleepGoal,
            int? sleepRating,
            int? shortInterruptionDuration,
            int? longInterruptionDuration,
            int? sleepCycles,
            float? groupDurationScore,
            float? groupSolidityScore,
            float? groupRegenerationScore,
            object? hypnogram,
            object? heartRateSamples)
        {
            this.PolarUser = polarUser;
            this.Date = date;
            this.SleepStartTime = sleepStartTime;
            this.SleepEndTime = sleepEndTime;
            this.DeviceId = deviceId;
            this.Continuity = continuity;
            this.ContinuityClass = continuityClass;
            this.LightSleep = lightSleep;
            this.DeepSleep = deepSleep;
            this.RemSleep = remSleep;
            this.UnrecognizedSleepStage = unrecognizedSleepStage;
            this.SleepScore = sleepScore;
            this.TotalInterruptionDuration = totalInterruptionDuration;
            this.SleepCharge = sleepCharge;
            this.SleepGoal = sleepGoal;
            this.SleepRating = sleepRating;
            this.ShortInterruptionDuration = shortInterruptionDuration;
            this.LongInterruptionDuration = longInterruptionDuration;
            this.SleepCycles = sleepCycles;
            this.GroupDurationScore = groupDurationScore;
            this.GroupSolidityScore = groupSolidityScore;
            this.GroupRegenerationScore = groupRegenerationScore;
            this.Hypnogram = hypnogram;
            this.HeartRateSamples = heartRateSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep" /> class.
        /// </summary>
        public Sleep()
        {
        }
    }
}