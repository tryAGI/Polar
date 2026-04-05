#nullable enable

namespace Polar
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// List nights<br/>
        /// List sleep data of user for the last 28 days.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.Nights> ListNightsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}