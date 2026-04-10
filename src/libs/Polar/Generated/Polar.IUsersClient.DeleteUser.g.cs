#nullable enable

namespace Polar
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete user<br/>
        /// When partner wishes no longer to receive user data, user can be de-registered.This will revoke the access token authorized by user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteUserAsync(
            long userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}