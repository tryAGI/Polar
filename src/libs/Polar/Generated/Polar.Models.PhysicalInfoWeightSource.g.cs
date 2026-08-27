
#nullable enable

namespace Polar
{
    /// <summary>
    /// Source of the weight information.<br/>
    /// Example: SOURCE_USER
    /// </summary>
    public enum PhysicalInfoWeightSource
    {
        /// <summary>
        ///
        /// </summary>
        SourceDefault,
        /// <summary>
        ///
        /// </summary>
        SourceEstimate,
        /// <summary>
        ///
        /// </summary>
        SourceKeep,
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
    public static class PhysicalInfoWeightSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhysicalInfoWeightSource value)
        {
            return value switch
            {
                PhysicalInfoWeightSource.SourceDefault => "SOURCE_DEFAULT",
                PhysicalInfoWeightSource.SourceEstimate => "SOURCE_ESTIMATE",
                PhysicalInfoWeightSource.SourceKeep => "SOURCE_KEEP",
                PhysicalInfoWeightSource.SourceMeasured => "SOURCE_MEASURED",
                PhysicalInfoWeightSource.SourceUser => "SOURCE_USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhysicalInfoWeightSource? ToEnum(string value)
        {
            return value switch
            {
                "SOURCE_DEFAULT" => PhysicalInfoWeightSource.SourceDefault,
                "SOURCE_ESTIMATE" => PhysicalInfoWeightSource.SourceEstimate,
                "SOURCE_KEEP" => PhysicalInfoWeightSource.SourceKeep,
                "SOURCE_MEASURED" => PhysicalInfoWeightSource.SourceMeasured,
                "SOURCE_USER" => PhysicalInfoWeightSource.SourceUser,
                _ => null,
            };
        }
    }
}