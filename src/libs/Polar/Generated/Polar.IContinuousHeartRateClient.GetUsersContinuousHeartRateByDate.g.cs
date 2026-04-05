#nullable enable

namespace Polar
{
    public partial interface IContinuousHeartRateClient
    {
        /// <summary>
        /// Get Continuous Heart rate samples<br/>
        /// Get users continuous heart rate values for given date. &lt;a href="https://support.polar.com/en/support/the_what_and_how_of_polars_continuous_heart_rate"&gt; Supported devices &lt;/a&gt;
        /// </summary>
        /// <param name="date"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.ContinuousHeartrate> GetUsersContinuousHeartRateByDateAsync(
            global::System.DateTime date,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}