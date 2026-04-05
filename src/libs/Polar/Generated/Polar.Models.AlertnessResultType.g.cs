
#nullable enable

namespace Polar
{
    /// <summary>
    /// Result type<br/>
    /// Example: ALERTNESS_TYPE_HISTORY
    /// </summary>
    public enum AlertnessResultType
    {
        /// <summary>
        /// 
        /// </summary>
        AlertnessTypeHistory,
        /// <summary>
        /// 
        /// </summary>
        AlertnessTypePrediction,
        /// <summary>
        /// 
        /// </summary>
        AlertnessTypeUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertnessResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertnessResultType value)
        {
            return value switch
            {
                AlertnessResultType.AlertnessTypeHistory => "ALERTNESS_TYPE_HISTORY",
                AlertnessResultType.AlertnessTypePrediction => "ALERTNESS_TYPE_PREDICTION",
                AlertnessResultType.AlertnessTypeUnknown => "ALERTNESS_TYPE_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertnessResultType? ToEnum(string value)
        {
            return value switch
            {
                "ALERTNESS_TYPE_HISTORY" => AlertnessResultType.AlertnessTypeHistory,
                "ALERTNESS_TYPE_PREDICTION" => AlertnessResultType.AlertnessTypePrediction,
                "ALERTNESS_TYPE_UNKNOWN" => AlertnessResultType.AlertnessTypeUnknown,
                _ => null,
            };
        }
    }
}