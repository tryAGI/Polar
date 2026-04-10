#nullable enable

namespace Polar
{
    public partial interface IPhysicalInfoClient
    {
        /// <summary>
        /// Create transaction<br/>
        /// Initiate physical info transaction.<br/>
        /// Check for new physical info and create a new transaction if found.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.TransactionLocation> CreatePhysicalInfoTransactionAsync(
            int userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}