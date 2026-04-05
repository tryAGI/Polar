#nullable enable

namespace Polar
{
    public partial interface IDailyActivityClient
    {
        /// <summary>
        /// Get activity for given date<br/>
        /// Get users activity for given date. Date cannot be older than 365 days from today.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="steps"></param>
        /// <param name="activityZones"></param>
        /// <param name="inactivityStamps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.ActivitySummaryWithAllSamples> GetActivityWithoutTransactionAsync(
            global::System.DateTime date,
            bool? steps = default,
            bool? activityZones = default,
            bool? inactivityStamps = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}