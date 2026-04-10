#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Activate webhook<br/>
        /// Activate deactivated webhook. Activation is successful if the configured webhook url returns HTTP status 200 (OK) for the issued ping request.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWebhooksActivateAsync(
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}