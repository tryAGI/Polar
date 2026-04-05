#nullable enable

namespace Polar
{
    public partial interface IExercisesDeprecatedClient
    {
        /// <summary>
        /// Get FIT<br/>
        /// Retrieve exercise in FIT format. See [FIT sport mappings in appendix](#sport-type-mapping-in-fit-files).
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <param name="exerciseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFitAsync(
            int userId,
            int transactionId,
            int exerciseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}