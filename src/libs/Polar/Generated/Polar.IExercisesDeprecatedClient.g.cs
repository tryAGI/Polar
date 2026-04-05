
#nullable enable

namespace Polar
{
    /// <summary>
    /// This resource allows partners to access their users' training data. All time values are UTC except start-time. Start-time is the time set on the training computer. Each transaction will consist of at most 50 training sessions. Available data presented in section [Schemas](#schemas). Only data that has been uploaded to Flow after the user has been registered to your client will be available. Only data that has been uploaded in the last 28 days will be available. &lt;br/&gt;&lt;br/&gt; This resource is deprecated. Please use non-transactional [Exercises](#exercises) instead.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IExercisesDeprecatedClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Polar.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}