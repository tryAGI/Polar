#nullable enable

namespace Polar
{
    public partial interface IPhysicalInfoDeprecatedClient
    {
        /// <summary>
        /// List physical infos<br/>
        /// List new physical info data.<br/>
        /// After successfully initiating a transaction, physical infos included within it can be retrieved with the provided transactionId.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ListPhysicalInfosAsBytesAsync(
            long transactionId,
            int userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List physical infos<br/>
        /// List new physical info data.<br/>
        /// After successfully initiating a transaction, physical infos included within it can be retrieved with the provided transactionId.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ListPhysicalInfosAsBytesAsStreamAsync(
            long transactionId,
            int userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List physical infos<br/>
        /// List new physical info data.<br/>
        /// After successfully initiating a transaction, physical infos included within it can be retrieved with the provided transactionId.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.AutoSDKHttpResponse<byte[]>> ListPhysicalInfosAsBytesAsResponseAsync(
            long transactionId,
            int userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}