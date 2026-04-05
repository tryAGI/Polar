#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Deactivate webhook<br/>
        /// Deactivate activated webhook. Deactivated webhook does not push notifications about subscribed events.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWebhooksDeactivateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}