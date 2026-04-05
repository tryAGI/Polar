#nullable enable

namespace Polar
{
    public partial interface IExercisesDeprecatedClient
    {
        /// <summary>
        /// Get heart rate zones<br/>
        /// Retrieve heart rate zones in training session
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <param name="exerciseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.Zones> GetHeartRateZonesAsync(
            int userId,
            int transactionId,
            int exerciseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}