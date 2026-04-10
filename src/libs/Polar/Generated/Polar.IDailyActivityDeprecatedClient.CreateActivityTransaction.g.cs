#nullable enable

namespace Polar
{
    public partial interface IDailyActivityDeprecatedClient
    {
        /// <summary>
        /// Create transaction<br/>
        /// Initiate activity transaction.<br/>
        /// Check for new activity summaries and create a new transaction if found.<br/>
        /// Only data uploaded to Flow in the last 30 days will be available.<br/>
        /// Only data that has been uploaded to Flow after the user is registered with your client will be available.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.TransactionLocation> CreateActivityTransactionAsync(
            int userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}