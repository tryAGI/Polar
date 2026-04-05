#nullable enable

namespace Polar
{
    public partial interface IPullNotificationsClient
    {
        /// <summary>
        /// List<br/>
        /// Get list of available exercises and activities for users
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.AvailableUserDatas> ListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}