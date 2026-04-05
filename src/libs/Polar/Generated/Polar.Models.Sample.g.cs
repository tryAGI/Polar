
#nullable enable

namespace Polar
{
    /// <summary>
    /// Training session sample data
    /// </summary>
    public sealed partial class Sample
    {
        /// <summary>
        /// Sample recording rate in seconds. Null when recording rate is not applicable - currently only with RR-data.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording-rate")]
        public int? RecordingRate { get; set; }

        /// <summary>
        /// Sample type<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample-type")]
        public byte[]? SampleType { get; set; }

        /// <summary>
        /// Sample values as a comma-separated list of strings. Can contain null -values which indicate a situation where sensor was offline.<br/>
        /// Example: 0,100,102,97,97,101,103,106,96,89,88,87,98,108,113,112,114,115,118,121,121,121,121,123,117,119,122
        /// </summary>
        /// <example>0,100,102,97,97,101,103,106,96,89,88,87,98,108,113,112,114,115,118,121,121,121,121,123,117,119,122</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sample" /> class.
        /// </summary>
        /// <param name="recordingRate">
        /// Sample recording rate in seconds. Null when recording rate is not applicable - currently only with RR-data.<br/>
        /// Example: 5
        /// </param>
        /// <param name="sampleType">
        /// Sample type<br/>
        /// Example: 1
        /// </param>
        /// <param name="data">
        /// Sample values as a comma-separated list of strings. Can contain null -values which indicate a situation where sensor was offline.<br/>
        /// Example: 0,100,102,97,97,101,103,106,96,89,88,87,98,108,113,112,114,115,118,121,121,121,121,123,117,119,122
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sample(
            int? recordingRate,
            byte[]? sampleType,
            string? data)
        {
            this.RecordingRate = recordingRate;
            this.SampleType = sampleType;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sample" /> class.
        /// </summary>
        public Sample()
        {
        }
    }
}