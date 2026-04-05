
#nullable enable

namespace Polar
{
    /// <summary>
    /// Grade classification<br/>
    /// Example: GRADE_CLASSIFICATION_STRONG
    /// </summary>
    public enum AlertnessGradeClassification
    {
        /// <summary>
        /// 
        /// </summary>
        GradeClassificationExcellent,
        /// <summary>
        /// 
        /// </summary>
        GradeClassificationFair,
        /// <summary>
        /// 
        /// </summary>
        GradeClassificationStrong,
        /// <summary>
        /// 
        /// </summary>
        GradeClassificationUnknown,
        /// <summary>
        /// 
        /// </summary>
        GradeClassificationWeak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertnessGradeClassificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertnessGradeClassification value)
        {
            return value switch
            {
                AlertnessGradeClassification.GradeClassificationExcellent => "GRADE_CLASSIFICATION_EXCELLENT",
                AlertnessGradeClassification.GradeClassificationFair => "GRADE_CLASSIFICATION_FAIR",
                AlertnessGradeClassification.GradeClassificationStrong => "GRADE_CLASSIFICATION_STRONG",
                AlertnessGradeClassification.GradeClassificationUnknown => "GRADE_CLASSIFICATION_UNKNOWN",
                AlertnessGradeClassification.GradeClassificationWeak => "GRADE_CLASSIFICATION_WEAK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertnessGradeClassification? ToEnum(string value)
        {
            return value switch
            {
                "GRADE_CLASSIFICATION_EXCELLENT" => AlertnessGradeClassification.GradeClassificationExcellent,
                "GRADE_CLASSIFICATION_FAIR" => AlertnessGradeClassification.GradeClassificationFair,
                "GRADE_CLASSIFICATION_STRONG" => AlertnessGradeClassification.GradeClassificationStrong,
                "GRADE_CLASSIFICATION_UNKNOWN" => AlertnessGradeClassification.GradeClassificationUnknown,
                "GRADE_CLASSIFICATION_WEAK" => AlertnessGradeClassification.GradeClassificationWeak,
                _ => null,
            };
        }
    }
}