#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get webhook<br/>
        /// Returns created webhook if exists.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.WebhookInfo> GetWebhookAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}