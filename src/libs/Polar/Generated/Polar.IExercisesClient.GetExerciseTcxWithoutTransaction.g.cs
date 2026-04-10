#nullable enable

namespace Polar
{
    public partial interface IExercisesClient
    {
        /// <summary>
        /// Get exercise TCX<br/>
        /// TCX file for users exercise without an AccessLink "transaction". Only Exercises uploaded to Flow in the last 30 days are available. Only exercises that have been uploaded to Flow after the user is registered with your client will be available.
        /// </summary>
        /// <param name="exerciseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetExerciseTcxWithoutTransactionAsync(
            string exerciseId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}