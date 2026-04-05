
#nullable enable

namespace Polar
{
    /// <summary>
    /// Sensor location<br/>
    /// Example: SL_PROXIMAL
    /// </summary>
    public enum BodyTemperaturePeriodSensorLocation
    {
        /// <summary>
        /// 
        /// </summary>
        SlDistal,
        /// <summary>
        /// 
        /// </summary>
        SlProximal,
        /// <summary>
        /// 
        /// </summary>
        SlUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyTemperaturePeriodSensorLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTemperaturePeriodSensorLocation value)
        {
            return value switch
            {
                BodyTemperaturePeriodSensorLocation.SlDistal => "SL_DISTAL",
                BodyTemperaturePeriodSensorLocation.SlProximal => "SL_PROXIMAL",
                BodyTemperaturePeriodSensorLocation.SlUnknown => "SL_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTemperaturePeriodSensorLocation? ToEnum(string value)
        {
            return value switch
            {
                "SL_DISTAL" => BodyTemperaturePeriodSensorLocation.SlDistal,
                "SL_PROXIMAL" => BodyTemperaturePeriodSensorLocation.SlProximal,
                "SL_UNKNOWN" => BodyTemperaturePeriodSensorLocation.SlUnknown,
                _ => null,
            };
        }
    }
}