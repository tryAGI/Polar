
#nullable enable

namespace Polar
{
    /// <summary>
    /// Measurement type<br/>
    /// Example: TM_CORE_TEMPERATURE
    /// </summary>
    public enum BodyTemperaturePeriodMeasurementType
    {
        /// <summary>
        /// 
        /// </summary>
        TmCoreTemperature,
        /// <summary>
        /// 
        /// </summary>
        TmSkinTemperature,
        /// <summary>
        /// 
        /// </summary>
        TmUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyTemperaturePeriodMeasurementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTemperaturePeriodMeasurementType value)
        {
            return value switch
            {
                BodyTemperaturePeriodMeasurementType.TmCoreTemperature => "TM_CORE_TEMPERATURE",
                BodyTemperaturePeriodMeasurementType.TmSkinTemperature => "TM_SKIN_TEMPERATURE",
                BodyTemperaturePeriodMeasurementType.TmUnknown => "TM_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTemperaturePeriodMeasurementType? ToEnum(string value)
        {
            return value switch
            {
                "TM_CORE_TEMPERATURE" => BodyTemperaturePeriodMeasurementType.TmCoreTemperature,
                "TM_SKIN_TEMPERATURE" => BodyTemperaturePeriodMeasurementType.TmSkinTemperature,
                "TM_UNKNOWN" => BodyTemperaturePeriodMeasurementType.TmUnknown,
                _ => null,
            };
        }
    }
}