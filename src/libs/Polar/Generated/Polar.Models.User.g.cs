
#nullable enable

namespace Polar
{
    /// <summary>
    /// User's basic information
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// User's id in Polar database<br/>
        /// Example: 2278512
        /// </summary>
        /// <example>2278512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("polar-user-id")]
        public long? PolarUserId { get; set; }

        /// <summary>
        /// User's identifier in partner's database<br/>
        /// Example: i09u9ujj
        /// </summary>
        /// <example>i09u9ujj</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("member-id")]
        public string? MemberId { get; set; }

        /// <summary>
        /// Timestamp marked when ACCEPTED<br/>
        /// Example: 2011-10-14T12:50:37.000Z
        /// </summary>
        /// <example>2011-10-14T12:50:37.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration-date")]
        public global::System.DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// User's first name<br/>
        /// Example: Eka
        /// </summary>
        /// <example>Eka</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first-name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// User's surname<br/>
        /// Example: Toka
        /// </summary>
        /// <example>Toka</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last-name")]
        public string? LastName { get; set; }

        /// <summary>
        /// User's birthdate as YYYY-MM-DD<br/>
        /// Example: 1985-09-06
        /// </summary>
        /// <example>1985-09-06</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("birthdate")]
        public string? Birthdate { get; set; }

        /// <summary>
        /// User's sex<br/>
        /// Example: MALE
        /// </summary>
        /// <example>MALE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.UserGenderJsonConverter))]
        public global::Polar.UserGender? Gender { get; set; }

        /// <summary>
        /// User's weight in kg<br/>
        /// Example: 66
        /// </summary>
        /// <example>66</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Users height in centimeters<br/>
        /// Example: 170
        /// </summary>
        /// <example>170</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public float? Height { get; set; }

        /// <summary>
        /// List containing answers given by the user to a number of partner-specific questions. Extra-info is null if there are no required fields defined by the partner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra-info")]
        public global::System.Collections.Generic.IList<global::Polar.UserExtraInfo>? ExtraInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="polarUserId">
        /// User's id in Polar database<br/>
        /// Example: 2278512
        /// </param>
        /// <param name="memberId">
        /// User's identifier in partner's database<br/>
        /// Example: i09u9ujj
        /// </param>
        /// <param name="registrationDate">
        /// Timestamp marked when ACCEPTED<br/>
        /// Example: 2011-10-14T12:50:37.000Z
        /// </param>
        /// <param name="firstName">
        /// User's first name<br/>
        /// Example: Eka
        /// </param>
        /// <param name="lastName">
        /// User's surname<br/>
        /// Example: Toka
        /// </param>
        /// <param name="birthdate">
        /// User's birthdate as YYYY-MM-DD<br/>
        /// Example: 1985-09-06
        /// </param>
        /// <param name="gender">
        /// User's sex<br/>
        /// Example: MALE
        /// </param>
        /// <param name="weight">
        /// User's weight in kg<br/>
        /// Example: 66
        /// </param>
        /// <param name="height">
        /// Users height in centimeters<br/>
        /// Example: 170
        /// </param>
        /// <param name="extraInfo">
        /// List containing answers given by the user to a number of partner-specific questions. Extra-info is null if there are no required fields defined by the partner.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User(
            long? polarUserId,
            string? memberId,
            global::System.DateTime? registrationDate,
            string? firstName,
            string? lastName,
            string? birthdate,
            global::Polar.UserGender? gender,
            float? weight,
            float? height,
            global::System.Collections.Generic.IList<global::Polar.UserExtraInfo>? extraInfo)
        {
            this.PolarUserId = polarUserId;
            this.MemberId = memberId;
            this.RegistrationDate = registrationDate;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.Weight = weight;
            this.Height = height;
            this.ExtraInfo = extraInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}