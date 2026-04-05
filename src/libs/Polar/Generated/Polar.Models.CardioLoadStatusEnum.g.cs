
#nullable enable

namespace Polar
{
    /// <summary>
    /// Text representation of cardio load status.
    /// </summary>
    public enum CardioLoadStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Detraining,
        /// <summary>
        /// 
        /// </summary>
        LoadStatusNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        Maintaining,
        /// <summary>
        /// 
        /// </summary>
        Overreaching,
        /// <summary>
        /// 
        /// </summary>
        Productive,
        /// <summary>
        /// 
        /// </summary>
        ProductiveAlmostOverreaching,
        /// <summary>
        /// 
        /// </summary>
        ProductiveDroppedFromOverreaching,
        /// <summary>
        /// 
        /// </summary>
        RecoveryAfterOverreaching,
        /// <summary>
        /// 
        /// </summary>
        Unrecognized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CardioLoadStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CardioLoadStatusEnum value)
        {
            return value switch
            {
                CardioLoadStatusEnum.Detraining => "DETRAINING",
                CardioLoadStatusEnum.LoadStatusNotAvailable => "LOAD_STATUS_NOT_AVAILABLE",
                CardioLoadStatusEnum.Maintaining => "MAINTAINING",
                CardioLoadStatusEnum.Overreaching => "OVERREACHING",
                CardioLoadStatusEnum.Productive => "PRODUCTIVE",
                CardioLoadStatusEnum.ProductiveAlmostOverreaching => "PRODUCTIVE_ALMOST_OVERREACHING",
                CardioLoadStatusEnum.ProductiveDroppedFromOverreaching => "PRODUCTIVE_DROPPED_FROM_OVERREACHING",
                CardioLoadStatusEnum.RecoveryAfterOverreaching => "RECOVERY_AFTER_OVERREACHING",
                CardioLoadStatusEnum.Unrecognized => "UNRECOGNIZED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CardioLoadStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "DETRAINING" => CardioLoadStatusEnum.Detraining,
                "LOAD_STATUS_NOT_AVAILABLE" => CardioLoadStatusEnum.LoadStatusNotAvailable,
                "MAINTAINING" => CardioLoadStatusEnum.Maintaining,
                "OVERREACHING" => CardioLoadStatusEnum.Overreaching,
                "PRODUCTIVE" => CardioLoadStatusEnum.Productive,
                "PRODUCTIVE_ALMOST_OVERREACHING" => CardioLoadStatusEnum.ProductiveAlmostOverreaching,
                "PRODUCTIVE_DROPPED_FROM_OVERREACHING" => CardioLoadStatusEnum.ProductiveDroppedFromOverreaching,
                "RECOVERY_AFTER_OVERREACHING" => CardioLoadStatusEnum.RecoveryAfterOverreaching,
                "UNRECOGNIZED" => CardioLoadStatusEnum.Unrecognized,
                _ => null,
            };
        }
    }
}