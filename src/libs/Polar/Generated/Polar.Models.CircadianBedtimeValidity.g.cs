
#nullable enable

namespace Polar
{
    /// <summary>
    /// Validity<br/>
    /// Example: VALIDITY_ESTIMATE
    /// </summary>
    public enum CircadianBedtimeValidity
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
    public static class CircadianBedtimeValidityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CircadianBedtimeValidity value)
        {
            return value switch
            {
                CircadianBedtimeValidity.ValidityEstimate => "VALIDITY_ESTIMATE",
                CircadianBedtimeValidity.ValidityNotValid => "VALIDITY_NOT_VALID",
                CircadianBedtimeValidity.ValidityReset => "VALIDITY_RESET",
                CircadianBedtimeValidity.ValidityUnknown => "VALIDITY_UNKNOWN",
                CircadianBedtimeValidity.ValidityValid => "VALIDITY_VALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CircadianBedtimeValidity? ToEnum(string value)
        {
            return value switch
            {
                "VALIDITY_ESTIMATE" => CircadianBedtimeValidity.ValidityEstimate,
                "VALIDITY_NOT_VALID" => CircadianBedtimeValidity.ValidityNotValid,
                "VALIDITY_RESET" => CircadianBedtimeValidity.ValidityReset,
                "VALIDITY_UNKNOWN" => CircadianBedtimeValidity.ValidityUnknown,
                "VALIDITY_VALID" => CircadianBedtimeValidity.ValidityValid,
                _ => null,
            };
        }
    }
}