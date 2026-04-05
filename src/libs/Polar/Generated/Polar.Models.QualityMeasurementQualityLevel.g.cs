
#nullable enable

namespace Polar
{
    /// <summary>
    /// Example: ECG_QUALITY_HIGH
    /// </summary>
    public enum QualityMeasurementQualityLevel
    {
        /// <summary>
        /// 
        /// </summary>
        EcgQualityHigh,
        /// <summary>
        /// 
        /// </summary>
        EcgQualityLow,
        /// <summary>
        /// 
        /// </summary>
        EcgQualityNoContact,
        /// <summary>
        /// 
        /// </summary>
        EcgQualityUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityMeasurementQualityLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityMeasurementQualityLevel value)
        {
            return value switch
            {
                QualityMeasurementQualityLevel.EcgQualityHigh => "ECG_QUALITY_HIGH",
                QualityMeasurementQualityLevel.EcgQualityLow => "ECG_QUALITY_LOW",
                QualityMeasurementQualityLevel.EcgQualityNoContact => "ECG_QUALITY_NO_CONTACT",
                QualityMeasurementQualityLevel.EcgQualityUnknown => "ECG_QUALITY_UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityMeasurementQualityLevel? ToEnum(string value)
        {
            return value switch
            {
                "ECG_QUALITY_HIGH" => QualityMeasurementQualityLevel.EcgQualityHigh,
                "ECG_QUALITY_LOW" => QualityMeasurementQualityLevel.EcgQualityLow,
                "ECG_QUALITY_NO_CONTACT" => QualityMeasurementQualityLevel.EcgQualityNoContact,
                "ECG_QUALITY_UNKNOWN" => QualityMeasurementQualityLevel.EcgQualityUnknown,
                _ => null,
            };
        }
    }
}