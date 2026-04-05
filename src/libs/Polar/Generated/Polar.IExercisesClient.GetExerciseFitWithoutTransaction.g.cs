#nullable enable

namespace Polar
{
    public partial interface IExercisesClient
    {
        /// <summary>
        /// Get exercise FIT<br/>
        /// FIT file for users exercise. Only Exercises uploaded to Flow in the last 30 days are available. Only exercises that have been uploaded to Flow after the user is registered with your client will be available. See [FIT sport mappings in appendix](#sport-type-mapping-in-fit-files).
        /// </summary>
        /// <param name="exerciseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetExerciseFitWithoutTransactionAsync(
            string exerciseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}