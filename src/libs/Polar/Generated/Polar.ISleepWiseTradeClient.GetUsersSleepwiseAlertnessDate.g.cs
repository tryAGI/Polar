#nullable enable

namespace Polar
{
    public partial interface ISleepWiseTradeClient
    {
        /// <summary>
        /// Alertness period data (date range)<br/>
        /// Get user's alertness period data for given date range. Maximum date range between from and to cannot be more than 28 days. &lt;a href="https://support.polar.com/en/polar-sleepwise"&gt; Supported devices &lt;/a&gt;
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.Alertness>> GetUsersSleepwiseAlertnessDateAsync(
            global::System.DateTime from,
            global::System.DateTime to,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}