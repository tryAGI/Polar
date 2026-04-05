#nullable enable

namespace Polar
{
    public partial interface ISleepWiseTradeClient
    {
        /// <summary>
        /// Circadian bedtime period data (date range)<br/>
        /// Get user's circadian bedtime period data for given date range. Maximum date range between from and to cannot be more than 28 days. &lt;a href="https://support.polar.com/en/polar-sleepwise"&gt; Supported devices &lt;/a&gt;
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.CircadianBedtime>> GetUsersSleepwiseCircadianBedtimeDateAsync(
            global::System.DateTime from,
            global::System.DateTime to,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}