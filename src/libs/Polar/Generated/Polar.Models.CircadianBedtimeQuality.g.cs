
#nullable enable

namespace Polar
{
    /// <summary>
    /// Quality<br/>
    /// Example: CIRCADIAN_BEDTIME_QUALITY_COMPROMISED
    /// </summary>
    public enum CircadianBedtimeQuality
    {
        /// <summary>
        /// 
        /// </summary>
        ClearlyRecognizable,
        /// <summary>
        /// 
        /// </summary>
        Compromised,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Weak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CircadianBedtimeQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CircadianBedtimeQuality value)
        {
            return value switch
            {
                CircadianBedtimeQuality.ClearlyRecognizable => "CIRCADIAN_BEDTIME_QUALITY_CLEARLY_RECOGNIZABLE",
                CircadianBedtimeQuality.Compromised => "CIRCADIAN_BEDTIME_QUALITY_COMPROMISED",
                CircadianBedtimeQuality.Unknown => "CIRCADIAN_BEDTIME_QUALITY_UNKNOWN",
                CircadianBedtimeQuality.Weak => "CIRCADIAN_BEDTIME_QUALITY_WEAK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CircadianBedtimeQuality? ToEnum(string value)
        {
            return value switch
            {
                "CIRCADIAN_BEDTIME_QUALITY_CLEARLY_RECOGNIZABLE" => CircadianBedtimeQuality.ClearlyRecognizable,
                "CIRCADIAN_BEDTIME_QUALITY_COMPROMISED" => CircadianBedtimeQuality.Compromised,
                "CIRCADIAN_BEDTIME_QUALITY_UNKNOWN" => CircadianBedtimeQuality.Unknown,
                "CIRCADIAN_BEDTIME_QUALITY_WEAK" => CircadianBedtimeQuality.Weak,
                _ => null,
            };
        }
    }
}