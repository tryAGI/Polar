
#nullable enable

namespace Polar
{
    /// <summary>
    /// Example: DEVIATION_NO_BASELINE
    /// </summary>
    public enum Spo2TestResultSpo2HrvDeviationFromBaseline
    {
        /// <summary>
        /// 
        /// </summary>
        DeviationAboveUsual,
        /// <summary>
        /// 
        /// </summary>
        DeviationBelowUsual,
        /// <summary>
        /// 
        /// </summary>
        DeviationNoBaseline,
        /// <summary>
        /// 
        /// </summary>
        DeviationUsual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Spo2TestResultSpo2HrvDeviationFromBaselineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Spo2TestResultSpo2HrvDeviationFromBaseline value)
        {
            return value switch
            {
                Spo2TestResultSpo2HrvDeviationFromBaseline.DeviationAboveUsual => "DEVIATION_ABOVE_USUAL",
                Spo2TestResultSpo2HrvDeviationFromBaseline.DeviationBelowUsual => "DEVIATION_BELOW_USUAL",
                Spo2TestResultSpo2HrvDeviationFromBaseline.DeviationNoBaseline => "DEVIATION_NO_BASELINE",
                Spo2TestResultSpo2HrvDeviationFromBaseline.DeviationUsual => "DEVIATION_USUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Spo2TestResultSpo2HrvDeviationFromBaseline? ToEnum(string value)
        {
            return value switch
            {
                "DEVIATION_ABOVE_USUAL" => Spo2TestResultSpo2HrvDeviationFromBaseline.DeviationAboveUsual,
                "DEVIATION_BELOW_USUAL" => Spo2TestResultSpo2HrvDeviationFromBaseline.DeviationBelowUsual,
                "DEVIATION_NO_BASELINE" => Spo2TestResultSpo2HrvDeviationFromBaseline.DeviationNoBaseline,
                "DEVIATION_USUAL" => Spo2TestResultSpo2HrvDeviationFromBaseline.DeviationUsual,
                _ => null,
            };
        }
    }
}