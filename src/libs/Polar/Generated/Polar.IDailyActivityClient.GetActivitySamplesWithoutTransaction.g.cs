#nullable enable

namespace Polar
{
    public partial interface IDailyActivityClient
    {
        /// <summary>
        /// Get activity samples for given date<br/>
        /// Get users activity samples for given date. Date cannot be older than 365 days from today.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.ActivityDayWithSamples> GetActivitySamplesWithoutTransactionAsync(
            global::System.DateTime date,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}