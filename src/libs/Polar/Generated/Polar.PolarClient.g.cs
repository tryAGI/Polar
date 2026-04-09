
#nullable enable

namespace Polar
{
    /// <summary>
    /// Polar AccessLink API documentation<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class PolarClient : global::Polar.IPolarClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://www.polaraccesslink.com/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Polar.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Polar.SourceGenerationContext.Default;


        /// <summary>
        /// Cardio load is based on training impulse calculation (TRIMP), a commonly accepted and scientifically proven method to quantify training load. Your Cardio load value tells you how much strain your training session put on your cardiovascular system.  The higher the Cardio load, the more strenuous the training session was for the cardiovascular system.  Cardio load is calculated after every workout from your heart rate data and session duration. For more detailed information please check [cardio load](https://support.polar.com/e_manuals/unite/polar-unite-user-manual-english/cardio-load.htm).
        /// </summary>
        public CardioLoadClient CardioLoad => new CardioLoadClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource allows partners to access their users' continuous heart rate data. Continuous heart rate is recorded with supported devices when the heart rate tracking is turned on in device settings. Samples are recording in 5 minute intervals. Heart rate samples from training sessions are not available through this resource. Training sessions samples have more precise sampling interval and they can be accessed from the [training data resource](#exercises). &lt;a href="https://support.polar.com/en/support/the_what_and_how_of_polars_continuous_heart_rate"&gt;Supported devices&lt;/a&gt;.
        /// </summary>
        public ContinuousHeartRateClient ContinuousHeartRate => new ContinuousHeartRateClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource allows partners to access their users' daily activity data. Webhooks are used to notify partners when new data is available.
        /// </summary>
        public DailyActivityClient DailyActivity => new DailyActivityClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource allows partners to access their users' daily activity data. During the transfer, the activity data is copied also into the AccessLink database so the end-users cannot change the data that is accessible via AccessLink afterwards. Begin and end of day are determined by the time set on the device used. No timezone information is available. Each transaction will consist of at most 50 activity summaries. Available data presented in section [Schemas](#schemas). Only data that has been uploaded to Flow after the user has been registered to your client will be available. Only data that has been uploaded in the last 28 days will be available. &lt;br/&gt;&lt;br/&gt; This resource is deprecated. Please use non-transactional [Daily activity](#daily-activity--beta-) instead.
        /// </summary>
        public DailyActivityDeprecatedClient DailyActivityDeprecated => new DailyActivityDeprecatedClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource allows partners to access their users' Elixir&amp;trade; Biosensing data. All time values are UTC times. Elixir&amp;trade; Biosensing data consists of body temperature data, sleep skin temperature data, skin contacts data, wrist ECG test report data and SpO2 test report data.
        /// </summary>
        public ElixirTradeBiosensingClient ElixirTradeBiosensing => new ElixirTradeBiosensingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Resources for getting information about exercise. These endpoints does not require active transaction, but they use hashed id.
        /// </summary>
        public ExercisesClient Exercises => new ExercisesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource allows partners to access their users' training data. All time values are UTC except start-time. Start-time is the time set on the training computer. Each transaction will consist of at most 50 training sessions. Available data presented in section [Schemas](#schemas). Only data that has been uploaded to Flow after the user has been registered to your client will be available. Only data that has been uploaded in the last 28 days will be available. &lt;br/&gt;&lt;br/&gt; This resource is deprecated. Please use non-transactional [Exercises](#exercises) instead.
        /// </summary>
        public ExercisesDeprecatedClient ExercisesDeprecated => new ExercisesDeprecatedClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Nightly Recharge&amp;trade; is a recovery measurement that shows how well your body recovers from daily training and stress. It is based on heart rate variability (HRV) and overnight heart rate data. The higher the Nightly Recharge score, the better your body has recovered. For more detailed information please check [Nightly Recharge](https://support.polar.com/e_manuals/unite/polar-unite-user-manual-english/nightly-recharge.htm).
        /// </summary>
        public NightlyRechargeClient NightlyRecharge => new NightlyRechargeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource allows partners to access their users' physical information. Whenever some user's physical information changes, new entry containing full physical info is stored to AccessLink. Pull notifications can be used to check if user have new physical information available. Available data presented in section [Schemas](#schemas).
        /// </summary>
        public PhysicalInfoClient PhysicalInfo => new PhysicalInfoClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource allows partners to check if their users have available data for downloading. Use client credentials authentication. Returns object holding list of available data objects.
        /// </summary>
        public PullNotificationsClient PullNotifications => new PullNotificationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Sleep endpoints support [Polar Sleep Plus&amp;trade;](https://www.polar.com/en/smart-coaching/polar-sleep-plus) and [Sleep Plus Stages&amp;trade;](https://www.polar.com/en/smart-coaching/sleep-plus-stages). Available data is presented in section [Schemas](#schemas).
        /// </summary>
        public SleepClient Sleep => new SleepClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource allows partners to access their users' SleepWise&amp;trade; data. All time values are UTC times. SleepWise&amp;trade; data is calculated for [SleepWise&amp;trade;](https://support.polar.com/en/polar-sleepwise) supported devices when minimum of 5 days of sleep data is available. SleepWise&amp;trade; data consists of alertness periods and circadian bedtime periods.
        /// </summary>
        public SleepWiseTradeClient SleepWiseTrade => new SleepWiseTradeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// This resource provides all the necessary functions to manage users.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Webhook resources provides endpoints for creating, modifying and deleting webhooks.
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the PolarClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public PolarClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Polar.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Polar.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}