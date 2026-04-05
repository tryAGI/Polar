
#nullable enable

namespace Polar
{
    /// <summary>
    /// Quantifies internal training load of a session.
    /// </summary>
    public enum TrainingLoadProRpeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        RpeBrisk,
        /// <summary>
        /// 
        /// </summary>
        RpeEasy,
        /// <summary>
        /// 
        /// </summary>
        RpeExhausting,
        /// <summary>
        /// 
        /// </summary>
        RpeExtreme,
        /// <summary>
        /// 
        /// </summary>
        RpeFairlyBrisk,
        /// <summary>
        /// 
        /// </summary>
        RpeFairlyHard,
        /// <summary>
        /// 
        /// </summary>
        RpeHard,
        /// <summary>
        /// 
        /// </summary>
        RpeLight,
        /// <summary>
        /// 
        /// </summary>
        RpeModerate,
        /// <summary>
        /// 
        /// </summary>
        RpeNone,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingLoadProRpeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingLoadProRpeEnum value)
        {
            return value switch
            {
                TrainingLoadProRpeEnum.RpeBrisk => "RPE_BRISK",
                TrainingLoadProRpeEnum.RpeEasy => "RPE_EASY",
                TrainingLoadProRpeEnum.RpeExhausting => "RPE_EXHAUSTING",
                TrainingLoadProRpeEnum.RpeExtreme => "RPE_EXTREME",
                TrainingLoadProRpeEnum.RpeFairlyBrisk => "RPE_FAIRLY_BRISK",
                TrainingLoadProRpeEnum.RpeFairlyHard => "RPE_FAIRLY_HARD",
                TrainingLoadProRpeEnum.RpeHard => "RPE_HARD",
                TrainingLoadProRpeEnum.RpeLight => "RPE_LIGHT",
                TrainingLoadProRpeEnum.RpeModerate => "RPE_MODERATE",
                TrainingLoadProRpeEnum.RpeNone => "RPE_NONE",
                TrainingLoadProRpeEnum.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingLoadProRpeEnum? ToEnum(string value)
        {
            return value switch
            {
                "RPE_BRISK" => TrainingLoadProRpeEnum.RpeBrisk,
                "RPE_EASY" => TrainingLoadProRpeEnum.RpeEasy,
                "RPE_EXHAUSTING" => TrainingLoadProRpeEnum.RpeExhausting,
                "RPE_EXTREME" => TrainingLoadProRpeEnum.RpeExtreme,
                "RPE_FAIRLY_BRISK" => TrainingLoadProRpeEnum.RpeFairlyBrisk,
                "RPE_FAIRLY_HARD" => TrainingLoadProRpeEnum.RpeFairlyHard,
                "RPE_HARD" => TrainingLoadProRpeEnum.RpeHard,
                "RPE_LIGHT" => TrainingLoadProRpeEnum.RpeLight,
                "RPE_MODERATE" => TrainingLoadProRpeEnum.RpeModerate,
                "RPE_NONE" => TrainingLoadProRpeEnum.RpeNone,
                "UNKNOWN" => TrainingLoadProRpeEnum.Unknown,
                _ => null,
            };
        }
    }
}