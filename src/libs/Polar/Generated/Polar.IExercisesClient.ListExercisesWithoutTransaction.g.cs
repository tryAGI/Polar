#nullable enable

namespace Polar
{
    public partial interface IExercisesClient
    {
        /// <summary>
        /// List exercises<br/>
        /// List users exercises available in AccessLink. Only Exercises uploaded to Flow in the last 30 days are returned. Only exercises that have been uploaded to Flow after the user is registered with your client will be returned. Use samples and zones query parameters to return optional samples and zone information of the exercises.<br/>
        /// Training Load Pro data will be included in the exercise object if the exercise is recorded with a specific wrist unit model,  please check [compatible devices](https://www.polar.com/en/smart-coaching/training-load-pro) for more information.
        /// </summary>
        /// <param name="samples"></param>
        /// <param name="zones"></param>
        /// <param name="route"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Polar.ExerciseHashId>> ListExercisesWithoutTransactionAsync(
            bool? samples = default,
            bool? zones = default,
            bool? route = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}