#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update webhook<br/>
        /// Edit webhook event types and/or url.<br/>
        /// When updating webhook url the AccessLink sends a ping message to the new address. The ping message must be answered with 200 OK or otherwise the webhook is not updated.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.WebhookInfo> UpdateWebhookAsync(
            string webhookId,

            global::Polar.WebhookPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook<br/>
        /// Edit webhook event types and/or url.<br/>
        /// When updating webhook url the AccessLink sends a ping message to the new address. The ping message must be answered with 200 OK or otherwise the webhook is not updated.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="events">
        /// Type of events to subscribe.<br/>
        /// Example: [EXERCISE]
        /// </param>
        /// <param name="url">
        /// Url where the webhook notification is sent.<br/>
        /// Example: https://myapp.example.com/acl_webhook
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.WebhookInfo> UpdateWebhookAsync(
            string webhookId,
            global::System.Collections.Generic.IList<global::Polar.WebhookType>? events = default,
            string? url = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}