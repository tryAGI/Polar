
#nullable enable

namespace Polar
{
    /// <summary>
    /// Model for registering user to partner.
    /// </summary>
    public sealed partial class Register
    {
        /// <summary>
        /// Partner's custom identifier for user.<br/>
        /// Example: User_id_999
        /// </summary>
        /// <example>User_id_999</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("member-id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Register" /> class.
        /// </summary>
        /// <param name="memberId">
        /// Partner's custom identifier for user.<br/>
        /// Example: User_id_999
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Register(
            string memberId)
        {
            this.MemberId = memberId ?? throw new global::System.ArgumentNullException(nameof(memberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Register" /> class.
        /// </summary>
        public Register()
        {
        }
    }
}