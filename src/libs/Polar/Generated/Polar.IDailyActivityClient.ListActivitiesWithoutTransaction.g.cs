#nullable enable

namespace Polar
{
    public partial interface IDailyActivityClient
    {
        /// <summary>
        /// List activities for past 28 days<br/>
        /// List users activities available in AccessLink. Only Activities uploaded to Flow in the last 28 days are returned.
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="activityZones"></param>
        /// <param name="inactivityStamps"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.ActivitySummaryWithAllSamples>> ListActivitiesWithoutTransactionAsync(
            bool? steps = default,
            bool? activityZones = default,
            bool? inactivityStamps = default,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}