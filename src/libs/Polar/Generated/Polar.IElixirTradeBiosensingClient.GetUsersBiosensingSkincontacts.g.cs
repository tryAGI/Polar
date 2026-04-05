#nullable enable

namespace Polar
{
    public partial interface IElixirTradeBiosensingClient
    {
        /// <summary>
        /// Skin contacts data<br/>
        /// Get user's skin contacts data for last 28 days or for given date range. Maximum date range between from and to cannot be more than 28 days.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.SkinContactPeriod>> GetUsersBiosensingSkincontactsAsync(
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}