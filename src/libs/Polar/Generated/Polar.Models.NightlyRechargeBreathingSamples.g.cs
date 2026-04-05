
#nullable enable

namespace Polar
{
    /// <summary>
    /// 5-minute average samples of breathing rate. Unit of samples is breaths per minute (bpm).<br/>
    /// Example: {"00:39":13.4,"00:44":13.5,"00:49":13.5}
    /// </summary>
    public sealed partial class NightlyRechargeBreathingSamples
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}