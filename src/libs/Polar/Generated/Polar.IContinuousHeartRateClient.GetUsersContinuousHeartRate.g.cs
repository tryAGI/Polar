#nullable enable

namespace Polar
{
    public partial interface IContinuousHeartRateClient
    {
        /// <summary>
        /// Get Continuous Heart rate samples with range<br/>
        /// Get users continuous heart rate values for given date range. &lt;a href="https://support.polar.com/en/support/the_what_and_how_of_polars_continuous_heart_rate"&gt; Supported devices &lt;/a&gt;
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.ContinuousHeartrate> GetUsersContinuousHeartRateAsync(
            global::System.DateTime from,
            global::System.DateTime to,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}