
#nullable enable

namespace Polar
{
    /// <summary>
    /// Validity<br/>
    /// Example: VALIDITY_ESTIMATE
    /// </summary>
    public enum AlertnessHourlyDataValidity
    {
        /// <summary>
        /// 
        /// </summary>
        ValidityEstimate,
        /// <summary>
        /// 
        /// </summary>
        ValidityNotValid,
        /// <summary>
        /// 
        /// </summary>
        ValidityReset,
        /// <summary>
        /// 
        /// </summary>
        ValidityUnknown,
        /// <summary>
        /// 
        /// </summary>
        ValidityValid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertnessHourlyDataValidityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertnessHourlyDataValidity value)
        {
            return value switch
            {
                AlertnessHourlyDataValidity.ValidityEstimate => "VALIDITY_ESTIMATE",
                AlertnessHourlyDataValidity.ValidityNotValid => "VALIDITY_NOT_VALID",
                AlertnessHourlyDataValidity.ValidityReset => "VALIDITY_RESET",
                AlertnessHourlyDataValidity.ValidityUnknown => "VALIDITY_UNKNOWN",
                AlertnessHourlyDataValidity.ValidityValid => "VALIDITY_VALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertnessHourlyDataValidity? ToEnum(string value)
        {
            return value switch
            {
                "VALIDITY_ESTIMATE" => AlertnessHourlyDataValidity.ValidityEstimate,
                "VALIDITY_NOT_VALID" => AlertnessHourlyDataValidity.ValidityNotValid,
                "VALIDITY_RESET" => AlertnessHourlyDataValidity.ValidityReset,
                "VALIDITY_UNKNOWN" => AlertnessHourlyDataValidity.ValidityUnknown,
                "VALIDITY_VALID" => AlertnessHourlyDataValidity.ValidityValid,
                _ => null,
            };
        }
    }
}