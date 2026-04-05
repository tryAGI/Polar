
#nullable enable

namespace Polar
{
    /// <summary>
    /// Example: SPO2_TEST_PASSED
    /// </summary>
    public enum Spo2TestResultTestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Spo2TestInconclusiveTooLowOverallQuality,
        /// <summary>
        /// 
        /// </summary>
        Spo2TestInconclusiveTooLowQualityInSamples,
        /// <summary>
        /// 
        /// </summary>
        Spo2TestInconclusiveTooManyMissingSamples,
        /// <summary>
        /// 
        /// </summary>
        Spo2TestPassed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Spo2TestResultTestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Spo2TestResultTestStatus value)
        {
            return value switch
            {
                Spo2TestResultTestStatus.Spo2TestInconclusiveTooLowOverallQuality => "SPO2_TEST_INCONCLUSIVE_TOO_LOW_OVERALL_QUALITY",
                Spo2TestResultTestStatus.Spo2TestInconclusiveTooLowQualityInSamples => "SPO2_TEST_INCONCLUSIVE_TOO_LOW_QUALITY_IN_SAMPLES",
                Spo2TestResultTestStatus.Spo2TestInconclusiveTooManyMissingSamples => "SPO2_TEST_INCONCLUSIVE_TOO_MANY_MISSING_SAMPLES",
                Spo2TestResultTestStatus.Spo2TestPassed => "SPO2_TEST_PASSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Spo2TestResultTestStatus? ToEnum(string value)
        {
            return value switch
            {
                "SPO2_TEST_INCONCLUSIVE_TOO_LOW_OVERALL_QUALITY" => Spo2TestResultTestStatus.Spo2TestInconclusiveTooLowOverallQuality,
                "SPO2_TEST_INCONCLUSIVE_TOO_LOW_QUALITY_IN_SAMPLES" => Spo2TestResultTestStatus.Spo2TestInconclusiveTooLowQualityInSamples,
                "SPO2_TEST_INCONCLUSIVE_TOO_MANY_MISSING_SAMPLES" => Spo2TestResultTestStatus.Spo2TestInconclusiveTooManyMissingSamples,
                "SPO2_TEST_PASSED" => Spo2TestResultTestStatus.Spo2TestPassed,
                _ => null,
            };
        }
    }
}