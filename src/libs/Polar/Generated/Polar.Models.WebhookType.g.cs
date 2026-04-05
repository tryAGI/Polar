
#nullable enable

namespace Polar
{
    /// <summary>
    /// Event type to subscribe. Currently EXERCISE, SLEEP, CONTINUOUS_HEART_RATE, SLEEP_WISE_CIRCADIAN_BEDTIME, SLEEP_WISE_ALERTNESS and ACTIVITY_SUMMARY are supported.
    /// </summary>
    public enum WebhookType
    {
        /// <summary>
        /// 
        /// </summary>
        Exercise_Sleep_ContinuousHeartRate_SleepWiseCircadianBedtime_SleepWiseAlertness_ActivitySummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookType value)
        {
            return value switch
            {
                WebhookType.Exercise_Sleep_ContinuousHeartRate_SleepWiseCircadianBedtime_SleepWiseAlertness_ActivitySummary => "EXERCISE, SLEEP, CONTINUOUS_HEART_RATE, SLEEP_WISE_CIRCADIAN_BEDTIME, SLEEP_WISE_ALERTNESS, ACTIVITY_SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookType? ToEnum(string value)
        {
            return value switch
            {
                "EXERCISE, SLEEP, CONTINUOUS_HEART_RATE, SLEEP_WISE_CIRCADIAN_BEDTIME, SLEEP_WISE_ALERTNESS, ACTIVITY_SUMMARY" => WebhookType.Exercise_Sleep_ContinuousHeartRate_SleepWiseCircadianBedtime_SleepWiseAlertness_ActivitySummary,
                _ => null,
            };
        }
    }
}