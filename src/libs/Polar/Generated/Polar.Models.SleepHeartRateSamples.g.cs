
#nullable enable

namespace Polar
{
    /// <summary>
    /// 5 min average samples of heart rate from the duration of the sleep. Default time between samples is 5 minutes. There may be periods with samples more often than every 5 minutes. Unit of samples is beats per minute (bpm).<br/>
    /// Example: {"00:41":76,"00:46":77,"00:51":76}
    /// </summary>
    public sealed partial class SleepHeartRateSamples
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}