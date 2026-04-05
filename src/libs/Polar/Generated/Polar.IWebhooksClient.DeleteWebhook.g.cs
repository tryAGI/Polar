#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Delete webhook<br/>
        /// Delete webhook by id.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWebhookAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}