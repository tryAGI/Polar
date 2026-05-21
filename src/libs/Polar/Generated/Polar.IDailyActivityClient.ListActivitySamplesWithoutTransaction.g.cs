#nullable enable

namespace Polar
{
    public partial interface IDailyActivityClient
    {
        /// <summary>
        /// List activity samples<br/>
        /// List users activity samples available in AccessLink. When no date range is given, activity samples from the last 28 days are returned. When `from` is given, activity samples for the specified date range are returned. From date cannot be older than 365 days from today and the maximum range between from and to is 28 days.
        /// </summary>
        /// <param name="from">
        /// Example: 2023-01-01
        /// </param>
        /// <param name="to">
        /// Example: 2023-01-31
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.ActivityDayWithSamples>> ListActivitySamplesWithoutTransactionAsync(
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List activity samples<br/>
        /// List users activity samples available in AccessLink. When no date range is given, activity samples from the last 28 days are returned. When `from` is given, activity samples for the specified date range are returned. From date cannot be older than 365 days from today and the maximum range between from and to is 28 days.
        /// </summary>
        /// <param name="from">
        /// Example: 2023-01-01
        /// </param>
        /// <param name="to">
        /// Example: 2023-01-31
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Polar.ActivityDayWithSamples>>> ListActivitySamplesWithoutTransactionAsResponseAsync(
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}