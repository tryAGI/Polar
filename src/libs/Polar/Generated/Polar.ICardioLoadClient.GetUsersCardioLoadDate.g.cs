#nullable enable

namespace Polar
{
    public partial interface ICardioLoadClient
    {
        /// <summary>
        /// Get cardio load by date range<br/>
        /// Returns cardio load data for selected date range.  The response list contains cardio load objects for every day between range even if the cardio load values cannot be calculated, in this case the cardio load status is represented as LOAD_STATUS_NOT_AVAILABLE.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.CardioLoad>> GetUsersCardioLoadDateAsync(
            global::System.DateTime from,
            global::System.DateTime to,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}