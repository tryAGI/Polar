
#nullable enable

namespace Polar
{
    /// <summary>
    /// The time span between when you fell asleep and when you woke up is classified into light, deep or REM sleep, or unrecognised or wake in 30-s epochs.<br/>
    /// 0 = WAKE, 1 = REM, 2 = LIGHTER NON-REM, 3 = LIGHT NON-REM, 4 = DEEP NON-REM, 5 = UNKNOWN (eg. due to bad skin contact).<br/>
    /// Example: {"00:39":2,"00:50":3,"01:23":6}
    /// </summary>
    public sealed partial class SleepHypnogram
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}