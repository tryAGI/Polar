
#nullable enable

namespace Polar
{
    /// <summary>
    /// Example: SPO2_CLASS_NORMAL
    /// </summary>
    public enum Spo2TestResultSpo2Class
    {
        /// <summary>
        /// 
        /// </summary>
        Spo2ClassLow,
        /// <summary>
        /// 
        /// </summary>
        Spo2ClassNormal,
        /// <summary>
        /// 
        /// </summary>
        Spo2ClassUnknown,
        /// <summary>
        /// 
        /// </summary>
        Spo2ClassVeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Spo2TestResultSpo2ClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Spo2TestResultSpo2Class value)
        {
            return value switch
            {
                Spo2TestResultSpo2Class.Spo2ClassLow => "SPO2_CLASS_LOW",
                Spo2TestResultSpo2Class.Spo2ClassNormal => "SPO2_CLASS_NORMAL",
                Spo2TestResultSpo2Class.Spo2ClassUnknown => "SPO2_CLASS_UNKNOWN",
                Spo2TestResultSpo2Class.Spo2ClassVeryLow => "SPO2_CLASS_VERY_LOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Spo2TestResultSpo2Class? ToEnum(string value)
        {
            return value switch
            {
                "SPO2_CLASS_LOW" => Spo2TestResultSpo2Class.Spo2ClassLow,
                "SPO2_CLASS_NORMAL" => Spo2TestResultSpo2Class.Spo2ClassNormal,
                "SPO2_CLASS_UNKNOWN" => Spo2TestResultSpo2Class.Spo2ClassUnknown,
                "SPO2_CLASS_VERY_LOW" => Spo2TestResultSpo2Class.Spo2ClassVeryLow,
                _ => null,
            };
        }
    }
}