#nullable enable

namespace Polar
{
    public partial interface IDailyActivityDeprecatedClient
    {
        /// <summary>
        /// Get step samples<br/>
        /// Get activity step samples. Example data can be seen from [appendix](#activity-step-time-series).
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <param name="activityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.ActivityStepSamples> GetStepSamplesAsync(
            int userId,
            int transactionId,
            int activityId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}