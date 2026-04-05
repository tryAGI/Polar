
#nullable enable

namespace Polar
{
    /// <summary>
    /// Activity zone type.
    /// </summary>
    public enum ActivityZoneSample2Zone
    {
        /// <summary>
        /// 
        /// </summary>
        Light,
        /// <summary>
        /// 
        /// </summary>
        Moderate,
        /// <summary>
        /// 
        /// </summary>
        Sedentary,
        /// <summary>
        /// 
        /// </summary>
        Sleep,
        /// <summary>
        /// 
        /// </summary>
        Vigorous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityZoneSample2ZoneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityZoneSample2Zone value)
        {
            return value switch
            {
                ActivityZoneSample2Zone.Light => "LIGHT",
                ActivityZoneSample2Zone.Moderate => "MODERATE",
                ActivityZoneSample2Zone.Sedentary => "SEDENTARY",
                ActivityZoneSample2Zone.Sleep => "SLEEP",
                ActivityZoneSample2Zone.Vigorous => "VIGOROUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityZoneSample2Zone? ToEnum(string value)
        {
            return value switch
            {
                "LIGHT" => ActivityZoneSample2Zone.Light,
                "MODERATE" => ActivityZoneSample2Zone.Moderate,
                "SEDENTARY" => ActivityZoneSample2Zone.Sedentary,
                "SLEEP" => ActivityZoneSample2Zone.Sleep,
                "VIGOROUS" => ActivityZoneSample2Zone.Vigorous,
                _ => null,
            };
        }
    }
}