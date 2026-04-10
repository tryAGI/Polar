#nullable enable

namespace Polar
{
    public partial interface IExercisesClient
    {
        /// <summary>
        /// Get exercise<br/>
        /// Get users exercise using hashed id. Only Exercises uploaded to Flow in the last 30 days are available. Only exercises that have been uploaded to Flow after the user is registered with your client will be available. Use samples and zones query parameters to return optional samples and zone information of the exercise.
        /// </summary>
        /// <param name="exerciseId"></param>
        /// <param name="samples"></param>
        /// <param name="zones"></param>
        /// <param name="route"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.ExerciseHashId> GetExerciseWithoutTransactionAsync(
            string exerciseId,
            bool? samples = default,
            bool? zones = default,
            bool? route = default,
            global::Polar.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}