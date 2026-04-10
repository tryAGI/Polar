#nullable enable

namespace Polar
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get Sleep<br/>
        /// Get Users sleep data for given date.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.Sleep> GetUsersSleepByDateAsync(
            string date,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}