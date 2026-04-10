#nullable enable

namespace Polar
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user information<br/>
        /// List user basic information.<br/>
        /// Note: Although it is possible to get users weight and height from this resource, the [get physical info](#get-physical-info) should be used instead.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.User> GetUserInformationAsync(
            long userId,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}