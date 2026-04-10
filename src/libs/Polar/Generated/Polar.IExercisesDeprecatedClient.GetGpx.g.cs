#nullable enable

namespace Polar
{
    public partial interface IExercisesDeprecatedClient
    {
        /// <summary>
        /// Get GPX<br/>
        /// Retrieve training session summary data in GPX format
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <param name="exerciseId"></param>
        /// <param name="includePauseTimes">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetGpxAsync(
            int userId,
            int transactionId,
            int exerciseId,
            bool? includePauseTimes = default,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}