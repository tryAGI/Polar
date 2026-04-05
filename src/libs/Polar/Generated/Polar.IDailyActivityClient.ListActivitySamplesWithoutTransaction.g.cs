#nullable enable

namespace Polar
{
    public partial interface IDailyActivityClient
    {
        /// <summary>
        /// List activity days with samples for past 28 days<br/>
        /// List users activity samples available in AccessLink. Only Activity samples uploaded to Flow in the last 28 days are returned.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.ActivityDayWithSamples>> ListActivitySamplesWithoutTransactionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}