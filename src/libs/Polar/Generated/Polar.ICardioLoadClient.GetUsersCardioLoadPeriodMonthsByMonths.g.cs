#nullable enable

namespace Polar
{
    public partial interface ICardioLoadClient
    {
        /// <summary>
        /// Get historical data by months<br/>
        /// Returns historical cardio load data for selected period of months counting from current date.
        /// </summary>
        /// <param name="months"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.CardioLoad>> GetUsersCardioLoadPeriodMonthsByMonthsAsync(
            int months,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}