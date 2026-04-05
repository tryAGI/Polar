#nullable enable

namespace Polar
{
    public partial interface IPhysicalInfoClient
    {
        /// <summary>
        /// Create transaction<br/>
        /// Initiate physical info transaction.<br/>
        /// Check for new physical info and create a new transaction if found.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.TransactionLocation> CreatePhysicalInfoTransactionAsync(
            int userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}