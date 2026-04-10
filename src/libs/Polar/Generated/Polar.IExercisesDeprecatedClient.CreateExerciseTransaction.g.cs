#nullable enable

namespace Polar
{
    public partial interface IExercisesDeprecatedClient
    {
        /// <summary>
        /// Create transaction<br/>
        /// Check for new training data and create a new transaction if found. Only data uploaded to Flow in the last 30 days will be available. Only data that has been uploaded to Flow after the user is registered with your client will be available.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.TransactionLocation> CreateExerciseTransactionAsync(
            int userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}