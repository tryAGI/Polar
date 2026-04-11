
#nullable enable

namespace Polar
{
    /// <summary>
    /// Polar AccessLink API documentation<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IPolarClient : global::System.IDisposable
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
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Polar.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Cardio load is based on training impulse calculation (TRIMP), a commonly accepted and scientifically proven method to quantify training load. Your Cardio load value tells you how much strain your training session put on your cardiovascular system.  The higher the Cardio load, the more strenuous the training session was for the cardiovascular system.  Cardio load is calculated after every workout from your heart rate data and session duration. For more detailed information please check [cardio load](https://support.polar.com/e_manuals/unite/polar-unite-user-manual-english/cardio-load.htm).
        /// </summary>
        public CardioLoadClient CardioLoad { get; }

        /// <summary>
        /// This resource allows partners to access their users' continuous heart rate data. Continuous heart rate is recorded with supported devices when the heart rate tracking is turned on in device settings. Samples are recording in 5 minute intervals. Heart rate samples from training sessions are not available through this resource. Training sessions samples have more precise sampling interval and they can be accessed from the [training data resource](#exercises). &lt;a href="https://support.polar.com/en/support/the_what_and_how_of_polars_continuous_heart_rate"&gt;Supported devices&lt;/a&gt;.
        /// </summary>
        public ContinuousHeartRateClient ContinuousHeartRate { get; }

        /// <summary>
        /// This resource allows partners to access their users' daily activity data. Webhooks are used to notify partners when new data is available.
        /// </summary>
        public DailyActivityClient DailyActivity { get; }

        /// <summary>
        /// This resource allows partners to access their users' daily activity data. During the transfer, the activity data is copied also into the AccessLink database so the end-users cannot change the data that is accessible via AccessLink afterwards. Begin and end of day are determined by the time set on the device used. No timezone information is available. Each transaction will consist of at most 50 activity summaries. Available data presented in section [Schemas](#schemas). Only data that has been uploaded to Flow after the user has been registered to your client will be available. Only data that has been uploaded in the last 28 days will be available. &lt;br/&gt;&lt;br/&gt; This resource is deprecated. Please use non-transactional [Daily activity](#daily-activity--beta-) instead.
        /// </summary>
        public DailyActivityDeprecatedClient DailyActivityDeprecated { get; }

        /// <summary>
        /// This resource allows partners to access their users' Elixir&amp;trade; Biosensing data. All time values are UTC times. Elixir&amp;trade; Biosensing data consists of body temperature data, sleep skin temperature data, skin contacts data, wrist ECG test report data and SpO2 test report data.
        /// </summary>
        public ElixirTradeBiosensingClient ElixirTradeBiosensing { get; }

        /// <summary>
        /// Resources for getting information about exercise. These endpoints does not require active transaction, but they use hashed id.
        /// </summary>
        public ExercisesClient Exercises { get; }

        /// <summary>
        /// This resource allows partners to access their users' training data. All time values are UTC except start-time. Start-time is the time set on the training computer. Each transaction will consist of at most 50 training sessions. Available data presented in section [Schemas](#schemas). Only data that has been uploaded to Flow after the user has been registered to your client will be available. Only data that has been uploaded in the last 28 days will be available. &lt;br/&gt;&lt;br/&gt; This resource is deprecated. Please use non-transactional [Exercises](#exercises) instead.
        /// </summary>
        public ExercisesDeprecatedClient ExercisesDeprecated { get; }

        /// <summary>
        /// Nightly Recharge&amp;trade; is a recovery measurement that shows how well your body recovers from daily training and stress. It is based on heart rate variability (HRV) and overnight heart rate data. The higher the Nightly Recharge score, the better your body has recovered. For more detailed information please check [Nightly Recharge](https://support.polar.com/e_manuals/unite/polar-unite-user-manual-english/nightly-recharge.htm).
        /// </summary>
        public NightlyRechargeClient NightlyRecharge { get; }

        /// <summary>
        /// This resource allows partners to access their users' physical information. Whenever some user's physical information changes, new entry containing full physical info is stored to AccessLink. Pull notifications can be used to check if user have new physical information available. Available data presented in section [Schemas](#schemas).
        /// </summary>
        public PhysicalInfoClient PhysicalInfo { get; }

        /// <summary>
        /// This resource allows partners to check if their users have available data for downloading. Use client credentials authentication. Returns object holding list of available data objects.
        /// </summary>
        public PullNotificationsClient PullNotifications { get; }

        /// <summary>
        /// Sleep endpoints support [Polar Sleep Plus&amp;trade;](https://www.polar.com/en/smart-coaching/polar-sleep-plus) and [Sleep Plus Stages&amp;trade;](https://www.polar.com/en/smart-coaching/sleep-plus-stages). Available data is presented in section [Schemas](#schemas).
        /// </summary>
        public SleepClient Sleep { get; }

        /// <summary>
        /// This resource allows partners to access their users' SleepWise&amp;trade; data. All time values are UTC times. SleepWise&amp;trade; data is calculated for [SleepWise&amp;trade;](https://support.polar.com/en/polar-sleepwise) supported devices when minimum of 5 days of sleep data is available. SleepWise&amp;trade; data consists of alertness periods and circadian bedtime periods.
        /// </summary>
        public SleepWiseTradeClient SleepWiseTrade { get; }

        /// <summary>
        /// This resource provides all the necessary functions to manage users.
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// Webhook resources provides endpoints for creating, modifying and deleting webhooks.
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}