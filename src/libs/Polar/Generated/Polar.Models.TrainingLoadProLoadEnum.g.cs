
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrainingLoadProLoadEnum
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        NotAvailable,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        VeryHigh,
        /// <summary>
        /// 
        /// </summary>
        VeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingLoadProLoadEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingLoadProLoadEnum value)
        {
            return value switch
            {
                TrainingLoadProLoadEnum.High => "HIGH",
                TrainingLoadProLoadEnum.Low => "LOW",
                TrainingLoadProLoadEnum.Medium => "MEDIUM",
                TrainingLoadProLoadEnum.NotAvailable => "NOT_AVAILABLE",
                TrainingLoadProLoadEnum.Unknown => "UNKNOWN",
                TrainingLoadProLoadEnum.VeryHigh => "VERY_HIGH",
                TrainingLoadProLoadEnum.VeryLow => "VERY_LOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingLoadProLoadEnum? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => TrainingLoadProLoadEnum.High,
                "LOW" => TrainingLoadProLoadEnum.Low,
                "MEDIUM" => TrainingLoadProLoadEnum.Medium,
                "NOT_AVAILABLE" => TrainingLoadProLoadEnum.NotAvailable,
                "UNKNOWN" => TrainingLoadProLoadEnum.Unknown,
                "VERY_HIGH" => TrainingLoadProLoadEnum.VeryHigh,
                "VERY_LOW" => TrainingLoadProLoadEnum.VeryLow,
                _ => null,
            };
        }
    }
}