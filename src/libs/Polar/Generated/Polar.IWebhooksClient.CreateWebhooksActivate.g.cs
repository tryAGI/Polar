#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Activate webhook<br/>
        /// Activate deactivated webhook. Activation is successful if the configured webhook url returns HTTP status 200 (OK) for the issued ping request.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWebhooksActivateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}