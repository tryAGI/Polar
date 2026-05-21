
#nullable enable

namespace Polar
{
    /// <summary>
    /// User's typical day description.<br/>
    /// Example: MOSTLY_MOVING
    /// </summary>
    public enum PhysicalInfoTypicalDay
    {
        /// <summary>
        /// 
        /// </summary>
        MostlyMoving,
        /// <summary>
        /// 
        /// </summary>
        MostlySitting,
        /// <summary>
        /// 
        /// </summary>
        MostlyStanding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhysicalInfoTypicalDayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhysicalInfoTypicalDay value)
        {
            return value switch
            {
                PhysicalInfoTypicalDay.MostlyMoving => "MOSTLY_MOVING",
                PhysicalInfoTypicalDay.MostlySitting => "MOSTLY_SITTING",
                PhysicalInfoTypicalDay.MostlyStanding => "MOSTLY_STANDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhysicalInfoTypicalDay? ToEnum(string value)
        {
            return value switch
            {
                "MOSTLY_MOVING" => PhysicalInfoTypicalDay.MostlyMoving,
                "MOSTLY_SITTING" => PhysicalInfoTypicalDay.MostlySitting,
                "MOSTLY_STANDING" => PhysicalInfoTypicalDay.MostlyStanding,
                _ => null,
            };
        }
    }
}