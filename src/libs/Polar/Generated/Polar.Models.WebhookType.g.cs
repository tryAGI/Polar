
#nullable enable

namespace Polar
{
    /// <summary>
    /// Event type to subscribe. Currently EXERCISE, SLEEP, CONTINUOUS_HEART_RATE, SLEEP_WISE_CIRCADIAN_BEDTIME, SLEEP_WISE_ALERTNESS, ACTIVITY_SUMMARY and PHYSICAL_INFORMATION are supported.
    /// </summary>
    public enum WebhookType
    {
        /// <summary>
        ///
        /// </summary>
        ActivitySummary,
        /// <summary>
        ///
        /// </summary>
        ContinuousHeartRate,
        /// <summary>
        ///
        /// </summary>
        Exercise,
        /// <summary>
        ///
        /// </summary>
        PhysicalInformation,
        /// <summary>
        ///
        /// </summary>
        Sleep,
        /// <summary>
        ///
        /// </summary>
        SleepWiseAlertness,
        /// <summary>
        ///
        /// </summary>
        SleepWiseCircadianBedtime,
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
                WebhookType.ActivitySummary => "ACTIVITY_SUMMARY",
                WebhookType.ContinuousHeartRate => "CONTINUOUS_HEART_RATE",
                WebhookType.Exercise => "EXERCISE",
                WebhookType.PhysicalInformation => "PHYSICAL_INFORMATION",
                WebhookType.Sleep => "SLEEP",
                WebhookType.SleepWiseAlertness => "SLEEP_WISE_ALERTNESS",
                WebhookType.SleepWiseCircadianBedtime => "SLEEP_WISE_CIRCADIAN_BEDTIME",
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
                "ACTIVITY_SUMMARY" => WebhookType.ActivitySummary,
                "CONTINUOUS_HEART_RATE" => WebhookType.ContinuousHeartRate,
                "EXERCISE" => WebhookType.Exercise,
                "PHYSICAL_INFORMATION" => WebhookType.PhysicalInformation,
                "SLEEP" => WebhookType.Sleep,
                "SLEEP_WISE_ALERTNESS" => WebhookType.SleepWiseAlertness,
                "SLEEP_WISE_CIRCADIAN_BEDTIME" => WebhookType.SleepWiseCircadianBedtime,
                _ => null,
            };
        }
    }
}