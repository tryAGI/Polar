
#nullable enable

namespace Polar
{
    /// <summary>
    /// Grade type<br/>
    /// Example: GRADE_TYPE_PRIMARY
    /// </summary>
    public enum AlertnessGradeType
    {
        /// <summary>
        /// 
        /// </summary>
        GradeTypeAdditional,
        /// <summary>
        /// 
        /// </summary>
        GradeTypePrimary,
        /// <summary>
        /// 
        /// </summary>
        GradeTypeUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertnessGradeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertnessGradeType value)
        {
            return value switch
            {
                AlertnessGradeType.GradeTypeAdditional => "GRADE_TYPE_ADDITIONAL",
                AlertnessGradeType.GradeTypePrimary => "GRADE_TYPE_PRIMARY",
                AlertnessGradeType.GradeTypeUnknown => "GRADE_TYPE_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertnessGradeType? ToEnum(string value)
        {
            return value switch
            {
                "GRADE_TYPE_ADDITIONAL" => AlertnessGradeType.GradeTypeAdditional,
                "GRADE_TYPE_PRIMARY" => AlertnessGradeType.GradeTypePrimary,
                "GRADE_TYPE_UNKNOWN" => AlertnessGradeType.GradeTypeUnknown,
                _ => null,
            };
        }
    }
}