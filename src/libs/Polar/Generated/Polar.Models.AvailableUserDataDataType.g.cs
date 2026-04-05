
#nullable enable

namespace Polar
{
    /// <summary>
    /// Type of available data.<br/>
    /// Example: ACTIVITY_SUMMARY
    /// </summary>
    public enum AvailableUserDataDataType
    {
        /// <summary>
        /// 
        /// </summary>
        ActivitySummary,
        /// <summary>
        /// 
        /// </summary>
        Exercise,
        /// <summary>
        /// 
        /// </summary>
        PhysicalInformation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AvailableUserDataDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AvailableUserDataDataType value)
        {
            return value switch
            {
                AvailableUserDataDataType.ActivitySummary => "ACTIVITY_SUMMARY",
                AvailableUserDataDataType.Exercise => "EXERCISE",
                AvailableUserDataDataType.PhysicalInformation => "PHYSICAL_INFORMATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AvailableUserDataDataType? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVITY_SUMMARY" => AvailableUserDataDataType.ActivitySummary,
                "EXERCISE" => AvailableUserDataDataType.Exercise,
                "PHYSICAL_INFORMATION" => AvailableUserDataDataType.PhysicalInformation,
                _ => null,
            };
        }
    }
}