
#nullable enable

namespace Polar
{
    /// <summary>
    /// Result type<br/>
    /// Example: CIRCADIAN_BEDTIME_TYPE_HISTORY
    /// </summary>
    public enum CircadianBedtimeResultType
    {
        /// <summary>
        /// 
        /// </summary>
        CircadianBedtimeTypeHistory,
        /// <summary>
        /// 
        /// </summary>
        CircadianBedtimeTypePrediction,
        /// <summary>
        /// 
        /// </summary>
        CircadianBedtimeTypeUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CircadianBedtimeResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CircadianBedtimeResultType value)
        {
            return value switch
            {
                CircadianBedtimeResultType.CircadianBedtimeTypeHistory => "CIRCADIAN_BEDTIME_TYPE_HISTORY",
                CircadianBedtimeResultType.CircadianBedtimeTypePrediction => "CIRCADIAN_BEDTIME_TYPE_PREDICTION",
                CircadianBedtimeResultType.CircadianBedtimeTypeUnknown => "CIRCADIAN_BEDTIME_TYPE_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CircadianBedtimeResultType? ToEnum(string value)
        {
            return value switch
            {
                "CIRCADIAN_BEDTIME_TYPE_HISTORY" => CircadianBedtimeResultType.CircadianBedtimeTypeHistory,
                "CIRCADIAN_BEDTIME_TYPE_PREDICTION" => CircadianBedtimeResultType.CircadianBedtimeTypePrediction,
                "CIRCADIAN_BEDTIME_TYPE_UNKNOWN" => CircadianBedtimeResultType.CircadianBedtimeTypeUnknown,
                _ => null,
            };
        }
    }
}