
#nullable enable

namespace Polar
{
    /// <summary>
    /// User's answers to the custom extra-info fields requested by partners
    /// </summary>
    public sealed partial class UserExtraInfo
    {
        /// <summary>
        /// Value provided by the customer<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Item index<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Name of the extra info asked from customer<br/>
        /// Example: number-of-children
        /// </summary>
        /// <example>number-of-children</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtraInfo" /> class.
        /// </summary>
        /// <param name="value">
        /// Value provided by the customer<br/>
        /// Example: 2
        /// </param>
        /// <param name="index">
        /// Item index<br/>
        /// Example: 0
        /// </param>
        /// <param name="name">
        /// Name of the extra info asked from customer<br/>
        /// Example: number-of-children
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserExtraInfo(
            string? value,
            int? index,
            string? name)
        {
            this.Value = value;
            this.Index = index;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtraInfo" /> class.
        /// </summary>
        public UserExtraInfo()
        {
        }
    }
}