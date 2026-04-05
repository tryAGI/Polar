#nullable enable

namespace Polar
{
    public partial interface IExercisesDeprecatedClient
    {
        /// <summary>
        /// Commit transaction<br/>
        /// After successfully retrieving training session data within a transaction, partners are expected to commit the transaction.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task CommitExerciseTransactionAsync(
            long transactionId,
            int userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}