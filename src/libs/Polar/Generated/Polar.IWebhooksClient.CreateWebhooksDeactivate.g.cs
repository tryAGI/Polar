#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Deactivate webhook<br/>
        /// Deactivate activated webhook. Deactivated webhook does not push notifications about subscribed events.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWebhooksDeactivateAsync(
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}