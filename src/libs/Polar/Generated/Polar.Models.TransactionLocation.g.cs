
#nullable enable

namespace Polar
{
    /// <summary>
    /// Contains absolute link to the created transaction.
    /// </summary>
    public sealed partial class TransactionLocation
    {
        /// <summary>
        /// Id of the created transaction<br/>
        /// Example: 122
        /// </summary>
        /// <example>122</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction-id")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Absolute links to the created transaction<br/>
        /// Example: https://polaraccesslink.com/v3/users/21/physical-information-transactions/32
        /// </summary>
        /// <example>https://polaraccesslink.com/v3/users/21/physical-information-transactions/32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource-uri")]
        public string? ResourceUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLocation" /> class.
        /// </summary>
        /// <param name="transactionId">
        /// Id of the created transaction<br/>
        /// Example: 122
        /// </param>
        /// <param name="resourceUri">
        /// Absolute links to the created transaction<br/>
        /// Example: https://polaraccesslink.com/v3/users/21/physical-information-transactions/32
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransactionLocation(
            long? transactionId,
            string? resourceUri)
        {
            this.TransactionId = transactionId;
            this.ResourceUri = resourceUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLocation" /> class.
        /// </summary>
        public TransactionLocation()
        {
        }
    }
}