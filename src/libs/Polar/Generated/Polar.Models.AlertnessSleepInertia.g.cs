
#nullable enable

namespace Polar
{
    /// <summary>
    /// Sleep inertia<br/>
    /// Example: SLEEP_INERTIA_MILD
    /// </summary>
    public enum AlertnessSleepInertia
    {
        /// <summary>
        /// 
        /// </summary>
        SleepInertiaHeavy,
        /// <summary>
        /// 
        /// </summary>
        SleepInertiaMild,
        /// <summary>
        /// 
        /// </summary>
        SleepInertiaModerate,
        /// <summary>
        /// 
        /// </summary>
        SleepInertiaNoInertia,
        /// <summary>
        /// 
        /// </summary>
        SleepInertiaUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertnessSleepInertiaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertnessSleepInertia value)
        {
            return value switch
            {
                AlertnessSleepInertia.SleepInertiaHeavy => "SLEEP_INERTIA_HEAVY",
                AlertnessSleepInertia.SleepInertiaMild => "SLEEP_INERTIA_MILD",
                AlertnessSleepInertia.SleepInertiaModerate => "SLEEP_INERTIA_MODERATE",
                AlertnessSleepInertia.SleepInertiaNoInertia => "SLEEP_INERTIA_NO_INERTIA",
                AlertnessSleepInertia.SleepInertiaUnknown => "SLEEP_INERTIA_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertnessSleepInertia? ToEnum(string value)
        {
            return value switch
            {
                "SLEEP_INERTIA_HEAVY" => AlertnessSleepInertia.SleepInertiaHeavy,
                "SLEEP_INERTIA_MILD" => AlertnessSleepInertia.SleepInertiaMild,
                "SLEEP_INERTIA_MODERATE" => AlertnessSleepInertia.SleepInertiaModerate,
                "SLEEP_INERTIA_NO_INERTIA" => AlertnessSleepInertia.SleepInertiaNoInertia,
                "SLEEP_INERTIA_UNKNOWN" => AlertnessSleepInertia.SleepInertiaUnknown,
                _ => null,
            };
        }
    }
}