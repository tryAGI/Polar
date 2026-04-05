#nullable enable

namespace Polar
{
    public partial interface INightlyRechargeClient
    {
        /// <summary>
        /// List Nightly Recharges<br/>
        /// List Nightly Recharge data of user for the last 28 days.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.Recharges> ListNightlyRechargeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}