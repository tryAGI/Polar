
#nullable enable

namespace Polar
{
    /// <summary>
    /// Validity<br/>
    /// Example: VALIDITY_ESTIMATE
    /// </summary>
    public enum AlertnessValidity
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
    public static class AlertnessValidityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertnessValidity value)
        {
            return value switch
            {
                AlertnessValidity.ValidityEstimate => "VALIDITY_ESTIMATE",
                AlertnessValidity.ValidityNotValid => "VALIDITY_NOT_VALID",
                AlertnessValidity.ValidityReset => "VALIDITY_RESET",
                AlertnessValidity.ValidityUnknown => "VALIDITY_UNKNOWN",
                AlertnessValidity.ValidityValid => "VALIDITY_VALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertnessValidity? ToEnum(string value)
        {
            return value switch
            {
                "VALIDITY_ESTIMATE" => AlertnessValidity.ValidityEstimate,
                "VALIDITY_NOT_VALID" => AlertnessValidity.ValidityNotValid,
                "VALIDITY_RESET" => AlertnessValidity.ValidityReset,
                "VALIDITY_UNKNOWN" => AlertnessValidity.ValidityUnknown,
                "VALIDITY_VALID" => AlertnessValidity.ValidityValid,
                _ => null,
            };
        }
    }
}