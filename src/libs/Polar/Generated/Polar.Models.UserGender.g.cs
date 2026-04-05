
#nullable enable

namespace Polar
{
    /// <summary>
    /// User's sex<br/>
    /// Example: MALE
    /// </summary>
    public enum UserGender
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
    public static class UserGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGender value)
        {
            return value switch
            {
                UserGender.Female => "FEMALE",
                UserGender.Male => "MALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGender? ToEnum(string value)
        {
            return value switch
            {
                "FEMALE" => UserGender.Female,
                "MALE" => UserGender.Male,
                _ => null,
            };
        }
    }
}