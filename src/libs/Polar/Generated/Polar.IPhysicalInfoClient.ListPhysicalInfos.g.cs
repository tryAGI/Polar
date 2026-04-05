#nullable enable

namespace Polar
{
    public partial interface IPhysicalInfoClient
    {
        /// <summary>
        /// List physical infos<br/>
        /// List new physical info data.<br/>
        /// After successfully initiating a transaction, physical infos included within it can be retrieved with the provided transactionId.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Polar.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Polar.PhysicalInformations> ListPhysicalInfosAsync(
            long transactionId,
            int userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}