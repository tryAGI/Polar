
#nullable enable

namespace Polar
{
    /// <summary>
    /// Error model which contains useful info about the error occurred.
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// Timestamp of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Http status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorType")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// Human readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Correlation id of the response for problem solving and debugging use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrId")]
        public string? CorrId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Timestamp of the error.
        /// </param>
        /// <param name="status">
        /// Http status code
        /// </param>
        /// <param name="errorType">
        /// Error type.
        /// </param>
        /// <param name="message">
        /// Human readable error message.
        /// </param>
        /// <param name="corrId">
        /// Correlation id of the response for problem solving and debugging use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            global::System.DateTime? timestamp,
            int? status,
            string? errorType,
            string? message,
            string? corrId)
        {
            this.Timestamp = timestamp;
            this.Status = status;
            this.ErrorType = errorType;
            this.Message = message;
            this.CorrId = corrId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}