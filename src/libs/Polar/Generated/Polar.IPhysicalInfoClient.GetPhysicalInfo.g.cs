#nullable enable

namespace Polar
{
    public partial interface IPhysicalInfoClient
    {
        /// <summary>
        /// Get physical info<br/>
        /// Get physical info entity data
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <param name="physicalInfoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.PhysicalInformation> GetPhysicalInfoAsync(
            int userId,
            int transactionId,
            int physicalInfoId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}