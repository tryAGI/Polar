
#nullable enable

namespace Polar
{
    /// <summary>
    /// User's gender.<br/>
    /// Example: MALE
    /// </summary>
    public enum PhysicalInfoGender
    {
        /// <summary>
        ///
        /// </summary>
        Female,
        /// <summary>
        ///
        /// </summary>
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhysicalInfoGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhysicalInfoGender value)
        {
            return value switch
            {
                PhysicalInfoGender.Female => "FEMALE",
                PhysicalInfoGender.Male => "MALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhysicalInfoGender? ToEnum(string value)
        {
            return value switch
            {
                "FEMALE" => PhysicalInfoGender.Female,
                "MALE" => PhysicalInfoGender.Male,
                _ => null,
            };
        }
    }
}