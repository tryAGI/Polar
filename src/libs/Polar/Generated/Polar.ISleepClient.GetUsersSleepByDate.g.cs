#nullable enable

namespace Polar
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get Sleep<br/>
        /// Get Users sleep data for given date.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.Sleep> GetUsersSleepByDateAsync(
            string date,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}