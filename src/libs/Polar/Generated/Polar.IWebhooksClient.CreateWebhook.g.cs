#nullable enable

namespace Polar
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create webhook<br/>
        /// Create new webhook.<br/>
        /// When creating webhook the AccessLink sends a ping message to the url in request body. The ping message must be answered with 200 OK or otherwise the webhook is not created.<br/>
        /// Created webhook is by default in activated state and will send push notifications about subscribed events. Webhook will be automatically deactivated if push notifications have not been successful for a period of seven (7) days.<br/>
        /// **Note!** Save the *signature_secret_key* from response since this is the only chance to get it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.CreatedWebhook> CreateWebhookAsync(

            global::Polar.WebhookRequest request,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook<br/>
        /// Create new webhook.<br/>
        /// When creating webhook the AccessLink sends a ping message to the url in request body. The ping message must be answered with 200 OK or otherwise the webhook is not created.<br/>
        /// Created webhook is by default in activated state and will send push notifications about subscribed events. Webhook will be automatically deactivated if push notifications have not been successful for a period of seven (7) days.<br/>
        /// **Note!** Save the *signature_secret_key* from response since this is the only chance to get it.
        /// </summary>
        /// <param name="events">
        /// Type of events to subscribe.<br/>
        /// Example: [EXERCISE]
        /// </param>
        /// <param name="url">
        /// Url where the webhook notification is sent.<br/>
        /// Example: https://myapp.example.com/acl_webhook
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.CreatedWebhook> CreateWebhookAsync(
            global::System.Collections.Generic.IList<global::Polar.WebhookType> events,
            string url,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}