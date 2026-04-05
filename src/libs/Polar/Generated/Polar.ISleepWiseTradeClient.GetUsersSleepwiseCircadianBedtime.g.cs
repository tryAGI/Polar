#nullable enable

namespace Polar
{
    public partial interface ISleepWiseTradeClient
    {
        /// <summary>
        /// Circadian bedtime period data (last 28 days)<br/>
        /// Get user's circadian bedtime period data for the last 28 days. &lt;a href="https://support.polar.com/en/polar-sleepwise"&gt; Supported devices &lt;/a&gt;
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.CircadianBedtime>> GetUsersSleepwiseCircadianBedtimeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}