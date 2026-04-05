#nullable enable

namespace Polar
{
    public partial interface ICardioLoadClient
    {
        /// <summary>
        /// List cardio loads<br/>
        /// Returns cardio load data for the last 28 days.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.CardioLoad>> GetUsersCardioLoadAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}