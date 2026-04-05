
#nullable enable

namespace Polar
{
    /// <summary>
    /// Only possible value is PING for ping message.
    /// </summary>
    public enum WebhookPingEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Ping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPingEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPingEvent value)
        {
            return value switch
            {
                WebhookPingEvent.Ping => "PING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPingEvent? ToEnum(string value)
        {
            return value switch
            {
                "PING" => WebhookPingEvent.Ping,
                _ => null,
            };
        }
    }
}