#nullable enable

namespace Polar
{
    public partial interface IDailyActivityClient
    {
        /// <summary>
        /// List activities for given date range<br/>
        /// List users activities available in AccessLink for given date range. From date cannot be older than 365 days from today and maximum range between from date and to date is 28 days.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="steps"></param>
        /// <param name="activityZones"></param>
        /// <param name="inactivityStamps"></param>
        /// <param name="from2"></param>
        /// <param name="to2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.ActivitySummaryWithAllSamples>> ListActivitiesWithoutTransactionByDateRangeAsync(
            global::System.DateTime from,
            string from2,
            string to2,
            global::System.DateTime? to = default,
            bool? steps = default,
            bool? activityZones = default,
            bool? inactivityStamps = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}