#nullable enable

namespace Polar
{
    public partial interface IDailyActivityDeprecatedClient
    {
        /// <summary>
        /// List activities<br/>
        /// List new activity data.<br/>
        /// After successfully initiating a transaction, activity summaries included within it can be retrieved with the provided transactionId.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.ActivityLog> ListActivitiesAsync(
            long transactionId,
            int userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}