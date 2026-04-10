#nullable enable

namespace Polar
{
    public partial interface IDailyActivityClient
    {
        /// <summary>
        /// List activity samples for given date range<br/>
        /// List users activity samples available in AccessLink for given date range. From date cannot be older than 365 days from today and maximum range between from date and to date is 28 days.
        /// </summary>
        /// <param name="from">
        /// Example: 2023-01-01
        /// </param>
        /// <param name="to">
        /// Example: 2023-01-31
        /// </param>
        /// <param name="from2"></param>
        /// <param name="to2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.ActivityDayWithSamples>> ListActivitySamplesWithoutTransactionByDateRangeAsync(
            global::System.DateTime from,
            string from2,
            string to2,
            global::System.DateTime? to = default,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}