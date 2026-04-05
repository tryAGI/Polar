#nullable enable

namespace Polar
{
    public partial interface ICardioLoadClient
    {
        /// <summary>
        /// Get cardio load by date<br/>
        /// Returns cardio load data for selected date.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.CardioLoad>> GetUsersCardioLoadByDateAsync(
            global::System.DateTime date,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}