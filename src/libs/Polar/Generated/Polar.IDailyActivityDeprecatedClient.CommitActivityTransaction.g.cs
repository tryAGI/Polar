#nullable enable

namespace Polar
{
    public partial interface IDailyActivityDeprecatedClient
    {
        /// <summary>
        /// Commit transaction<br/>
        /// After successfully retrieving activity summary data within a transaction, partners are expected to commit the transaction.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task CommitActivityTransactionAsync(
            long transactionId,
            int userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}