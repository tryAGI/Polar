
#nullable enable

namespace Polar
{
    /// <summary>
    /// Example: ECG_HRV_LEVEL_NO_BASELINE
    /// </summary>
    public enum EcgTestResultHeartRateVariabilityLevel
    {
        /// <summary>
        /// 
        /// </summary>
        EcgHrvLevelAboveUsual,
        /// <summary>
        /// 
        /// </summary>
        EcgHrvLevelBelowUsual,
        /// <summary>
        /// 
        /// </summary>
        EcgHrvLevelNoBaseline,
        /// <summary>
        /// 
        /// </summary>
        EcgHrvLevelUsual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EcgTestResultHeartRateVariabilityLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EcgTestResultHeartRateVariabilityLevel value)
        {
            return value switch
            {
                EcgTestResultHeartRateVariabilityLevel.EcgHrvLevelAboveUsual => "ECG_HRV_LEVEL_ABOVE_USUAL",
                EcgTestResultHeartRateVariabilityLevel.EcgHrvLevelBelowUsual => "ECG_HRV_LEVEL_BELOW_USUAL",
                EcgTestResultHeartRateVariabilityLevel.EcgHrvLevelNoBaseline => "ECG_HRV_LEVEL_NO_BASELINE",
                EcgTestResultHeartRateVariabilityLevel.EcgHrvLevelUsual => "ECG_HRV_LEVEL_USUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EcgTestResultHeartRateVariabilityLevel? ToEnum(string value)
        {
            return value switch
            {
                "ECG_HRV_LEVEL_ABOVE_USUAL" => EcgTestResultHeartRateVariabilityLevel.EcgHrvLevelAboveUsual,
                "ECG_HRV_LEVEL_BELOW_USUAL" => EcgTestResultHeartRateVariabilityLevel.EcgHrvLevelBelowUsual,
                "ECG_HRV_LEVEL_NO_BASELINE" => EcgTestResultHeartRateVariabilityLevel.EcgHrvLevelNoBaseline,
                "ECG_HRV_LEVEL_USUAL" => EcgTestResultHeartRateVariabilityLevel.EcgHrvLevelUsual,
                _ => null,
            };
        }
    }
}