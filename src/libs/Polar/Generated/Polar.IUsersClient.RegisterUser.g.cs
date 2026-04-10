#nullable enable

namespace Polar
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Register user<br/>
        /// Once partner has been authorized by user, partner must register the user before being able to access its data. API user-id and Polar User Id (polar-user-id) are interchangeable terms.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.User> RegisterUserAsync(

            global::Polar.Register request,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register user<br/>
        /// Once partner has been authorized by user, partner must register the user before being able to access its data. API user-id and Polar User Id (polar-user-id) are interchangeable terms.
        /// </summary>
        /// <param name="memberId">
        /// Partner's custom identifier for user.<br/>
        /// Example: User_id_999
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.User> RegisterUserAsync(
            string memberId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}