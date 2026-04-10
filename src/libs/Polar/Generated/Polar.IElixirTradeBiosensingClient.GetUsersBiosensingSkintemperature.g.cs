#nullable enable

namespace Polar
{
    public partial interface IElixirTradeBiosensingClient
    {
        /// <summary>
        /// Sleep skin temperature data<br/>
        /// Get user's sleep skin temperature data for last 28 days or for given date range. Maximum date range between from and to cannot be more than 28 days.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.SkinTemperature>> GetUsersBiosensingSkintemperatureAsync(
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}