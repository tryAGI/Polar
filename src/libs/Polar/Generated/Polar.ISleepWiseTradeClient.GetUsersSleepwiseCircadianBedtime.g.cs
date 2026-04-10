#nullable enable

namespace Polar
{
    public partial interface ISleepWiseTradeClient
    {
        /// <summary>
        /// Circadian bedtime period data (last 28 days)<br/>
        /// Get user's circadian bedtime period data for the last 28 days. &lt;a href="https://support.polar.com/en/polar-sleepwise"&gt; Supported devices &lt;/a&gt;
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.CircadianBedtime>> GetUsersSleepwiseCircadianBedtimeAsync(
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}