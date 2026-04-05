#nullable enable

namespace Polar
{
    public partial interface ISleepWiseTradeClient
    {
        /// <summary>
        /// Alertness period data (last 28 days)<br/>
        /// Get user's alertness period data for the last 28 days. &lt;a href="https://support.polar.com/en/polar-sleepwise"&gt; Supported devices &lt;/a&gt;
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.Alertness>> GetUsersSleepwiseAlertnessAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}