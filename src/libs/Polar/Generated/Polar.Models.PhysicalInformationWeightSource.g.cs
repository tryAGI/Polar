
#nullable enable

namespace Polar
{
    /// <summary>
    /// Weight source<br/>
    /// Example: SOURCE_MEASURED
    /// </summary>
    public enum PhysicalInformationWeightSource
    {
        /// <summary>
        /// 
        /// </summary>
        SourceMeasured,
        /// <summary>
        /// 
        /// </summary>
        SourceUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhysicalInformationWeightSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhysicalInformationWeightSource value)
        {
            return value switch
            {
                PhysicalInformationWeightSource.SourceMeasured => "SOURCE_MEASURED",
                PhysicalInformationWeightSource.SourceUser => "SOURCE_USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhysicalInformationWeightSource? ToEnum(string value)
        {
            return value switch
            {
                "SOURCE_MEASURED" => PhysicalInformationWeightSource.SourceMeasured,
                "SOURCE_USER" => PhysicalInformationWeightSource.SourceUser,
                _ => null,
            };
        }
    }
}