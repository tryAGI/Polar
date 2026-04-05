#nullable enable

namespace Polar
{
    public partial interface IExercisesDeprecatedClient
    {
        /// <summary>
        /// Get available samples<br/>
        /// Retrieve list of links to available samples in training session
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <param name="exerciseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.Samples> GetAvailableSamplesAsync(
            int userId,
            int transactionId,
            int exerciseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}