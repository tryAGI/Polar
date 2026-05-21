#nullable enable

namespace Polar
{
    public partial interface ICardioLoadClient
    {
        /// <summary>
        /// List cardio loads<br/>
        /// Returns cardio load data for the last 28 days. The response list contains cardio load objects for every day in the range, even if values cannot be calculated — in that case the cardio load status is represented as LOAD_STATUS_NOT_AVAILABLE.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.CardioLoad>> GetUsersCardioLoadAsync(
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List cardio loads<br/>
        /// Returns cardio load data for the last 28 days. The response list contains cardio load objects for every day in the range, even if values cannot be calculated — in that case the cardio load status is represented as LOAD_STATUS_NOT_AVAILABLE.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Polar.CardioLoad>>> GetUsersCardioLoadAsResponseAsync(
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}