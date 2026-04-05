
#nullable enable

namespace Polar
{
    /// <summary>
    /// Sleep type<br/>
    /// Example: SLEEP_TYPE_PRIMARY
    /// </summary>
    public enum AlertnessSleepType
    {
        /// <summary>
        /// 
        /// </summary>
        SleepTypeArtificial,
        /// <summary>
        /// 
        /// </summary>
        SleepTypePrimary,
        /// <summary>
        /// 
        /// </summary>
        SleepTypeSecondary,
        /// <summary>
        /// 
        /// </summary>
        SleepTypeUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertnessSleepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertnessSleepType value)
        {
            return value switch
            {
                AlertnessSleepType.SleepTypeArtificial => "SLEEP_TYPE_ARTIFICIAL",
                AlertnessSleepType.SleepTypePrimary => "SLEEP_TYPE_PRIMARY",
                AlertnessSleepType.SleepTypeSecondary => "SLEEP_TYPE_SECONDARY",
                AlertnessSleepType.SleepTypeUnknown => "SLEEP_TYPE_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertnessSleepType? ToEnum(string value)
        {
            return value switch
            {
                "SLEEP_TYPE_ARTIFICIAL" => AlertnessSleepType.SleepTypeArtificial,
                "SLEEP_TYPE_PRIMARY" => AlertnessSleepType.SleepTypePrimary,
                "SLEEP_TYPE_SECONDARY" => AlertnessSleepType.SleepTypeSecondary,
                "SLEEP_TYPE_UNKNOWN" => AlertnessSleepType.SleepTypeUnknown,
                _ => null,
            };
        }
    }
}