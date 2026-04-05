#nullable enable

namespace Polar
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get available sleep times<br/>
        /// Get the dates with sleep start and end times, where user has sleep data available in the last 28 days.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.AvailableSleeps> GetUsersSleepAvailableAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}