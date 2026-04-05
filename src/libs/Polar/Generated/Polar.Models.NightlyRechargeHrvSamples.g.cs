
#nullable enable

namespace Polar
{
    /// <summary>
    /// 5-minute average samples of heart rate variability. Unit of samples is milliseconds(ms).<br/>
    /// Example: {"00:41":14,"00:46":14,"00:51":15}
    /// </summary>
    public sealed partial class NightlyRechargeHrvSamples
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}