#nullable enable

namespace Polar
{
    public partial interface IExercisesDeprecatedClient
    {
        /// <summary>
        /// Get samples<br/>
        /// Retrieve sample data of given type
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <param name="exerciseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.Sample> GetSamplesAsync(
            byte[] typeId,
            int userId,
            int transactionId,
            int exerciseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}