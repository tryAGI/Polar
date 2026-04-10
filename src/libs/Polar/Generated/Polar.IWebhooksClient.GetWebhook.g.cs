#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get webhook<br/>
        /// Returns created webhook if exists.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.WebhookInfo> GetWebhookAsync(
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}