
#nullable enable

namespace Polar
{
    /// <summary>
    /// User's training background.<br/>
    /// Example: REGULAR
    /// </summary>
    public enum PhysicalInfoTrainingBackground
    {
        /// <summary>
        /// 
        /// </summary>
        Frequent,
        /// <summary>
        /// 
        /// </summary>
        Heavy,
        /// <summary>
        /// 
        /// </summary>
        Occasional,
        /// <summary>
        /// 
        /// </summary>
        Pro,
        /// <summary>
        /// 
        /// </summary>
        Regular,
        /// <summary>
        /// 
        /// </summary>
        SemiPro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhysicalInfoTrainingBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhysicalInfoTrainingBackground value)
        {
            return value switch
            {
                PhysicalInfoTrainingBackground.Frequent => "FREQUENT",
                PhysicalInfoTrainingBackground.Heavy => "HEAVY",
                PhysicalInfoTrainingBackground.Occasional => "OCCASIONAL",
                PhysicalInfoTrainingBackground.Pro => "PRO",
                PhysicalInfoTrainingBackground.Regular => "REGULAR",
                PhysicalInfoTrainingBackground.SemiPro => "SEMI_PRO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhysicalInfoTrainingBackground? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => PhysicalInfoTrainingBackground.Frequent,
                "HEAVY" => PhysicalInfoTrainingBackground.Heavy,
                "OCCASIONAL" => PhysicalInfoTrainingBackground.Occasional,
                "PRO" => PhysicalInfoTrainingBackground.Pro,
                "REGULAR" => PhysicalInfoTrainingBackground.Regular,
                "SEMI_PRO" => PhysicalInfoTrainingBackground.SemiPro,
                _ => null,
            };
        }
    }
}