
#nullable enable

namespace Polar
{
    /// <summary>
    /// Alertness level<br/>
    /// Example: ALERTNESS_LEVEL_VERY_HIGH
    /// </summary>
    public enum AlertnessHourlyDataAlertnessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        AlertnessLevelHigh,
        /// <summary>
        /// 
        /// </summary>
        AlertnessLevelLow,
        /// <summary>
        /// 
        /// </summary>
        AlertnessLevelMinimal,
        /// <summary>
        /// 
        /// </summary>
        AlertnessLevelUnknown,
        /// <summary>
        /// 
        /// </summary>
        AlertnessLevelVeryHigh,
        /// <summary>
        /// 
        /// </summary>
        AlertnessLevelVeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertnessHourlyDataAlertnessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertnessHourlyDataAlertnessLevel value)
        {
            return value switch
            {
                AlertnessHourlyDataAlertnessLevel.AlertnessLevelHigh => "ALERTNESS_LEVEL_HIGH",
                AlertnessHourlyDataAlertnessLevel.AlertnessLevelLow => "ALERTNESS_LEVEL_LOW",
                AlertnessHourlyDataAlertnessLevel.AlertnessLevelMinimal => "ALERTNESS_LEVEL_MINIMAL",
                AlertnessHourlyDataAlertnessLevel.AlertnessLevelUnknown => "ALERTNESS_LEVEL_UNKNOWN",
                AlertnessHourlyDataAlertnessLevel.AlertnessLevelVeryHigh => "ALERTNESS_LEVEL_VERY_HIGH",
                AlertnessHourlyDataAlertnessLevel.AlertnessLevelVeryLow => "ALERTNESS_LEVEL_VERY_LOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertnessHourlyDataAlertnessLevel? ToEnum(string value)
        {
            return value switch
            {
                "ALERTNESS_LEVEL_HIGH" => AlertnessHourlyDataAlertnessLevel.AlertnessLevelHigh,
                "ALERTNESS_LEVEL_LOW" => AlertnessHourlyDataAlertnessLevel.AlertnessLevelLow,
                "ALERTNESS_LEVEL_MINIMAL" => AlertnessHourlyDataAlertnessLevel.AlertnessLevelMinimal,
                "ALERTNESS_LEVEL_UNKNOWN" => AlertnessHourlyDataAlertnessLevel.AlertnessLevelUnknown,
                "ALERTNESS_LEVEL_VERY_HIGH" => AlertnessHourlyDataAlertnessLevel.AlertnessLevelVeryHigh,
                "ALERTNESS_LEVEL_VERY_LOW" => AlertnessHourlyDataAlertnessLevel.AlertnessLevelVeryLow,
                _ => null,
            };
        }
    }
}