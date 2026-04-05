
#nullable enable

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTemperaturePeriod
    {
        /// <summary>
        /// Example: 1111AAAA
        /// </summary>
        /// <example>1111AAAA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_device_id")]
        public string? SourceDeviceId { get; set; }

        /// <summary>
        /// Measurement type<br/>
        /// Example: TM_CORE_TEMPERATURE
        /// </summary>
        /// <example>TM_CORE_TEMPERATURE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurement_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.BodyTemperaturePeriodMeasurementTypeJsonConverter))]
        public global::Polar.BodyTemperaturePeriodMeasurementType? MeasurementType { get; set; }

        /// <summary>
        /// Sensor location<br/>
        /// Example: SL_PROXIMAL
        /// </summary>
        /// <example>SL_PROXIMAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensor_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Polar.JsonConverters.BodyTemperaturePeriodSensorLocationJsonConverter))]
        public global::Polar.BodyTemperaturePeriodSensorLocation? SensorLocation { get; set; }

        /// <summary>
        /// Measurement period start time (UTC)<br/>
        /// Example: 2023-10-20T04:00:00
        /// </summary>
        /// <example>2023-10-20T04:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Measurement period end time (UTC)<br/>
        /// Example: 2023-10-20T05:00:00
        /// </summary>
        /// <example>2023-10-20T05:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Measurement period modified time (UTC)<br/>
        /// Example: 2023-10-20T04:00:00
        /// </summary>
        /// <example>2023-10-20T04:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_time")]
        public global::System.DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Polar.BodyTemperatureSample>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTemperaturePeriod" /> class.
        /// </summary>
        /// <param name="sourceDeviceId">
        /// Example: 1111AAAA
        /// </param>
        /// <param name="measurementType">
        /// Measurement type<br/>
        /// Example: TM_CORE_TEMPERATURE
        /// </param>
        /// <param name="sensorLocation">
        /// Sensor location<br/>
        /// Example: SL_PROXIMAL
        /// </param>
        /// <param name="startTime">
        /// Measurement period start time (UTC)<br/>
        /// Example: 2023-10-20T04:00:00
        /// </param>
        /// <param name="endTime">
        /// Measurement period end time (UTC)<br/>
        /// Example: 2023-10-20T05:00:00
        /// </param>
        /// <param name="modifiedTime">
        /// Measurement period modified time (UTC)<br/>
        /// Example: 2023-10-20T04:00:00
        /// </param>
        /// <param name="samples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyTemperaturePeriod(
            string? sourceDeviceId,
            global::Polar.BodyTemperaturePeriodMeasurementType? measurementType,
            global::Polar.BodyTemperaturePeriodSensorLocation? sensorLocation,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::System.DateTime? modifiedTime,
            global::System.Collections.Generic.IList<global::Polar.BodyTemperatureSample>? samples)
        {
            this.SourceDeviceId = sourceDeviceId;
            this.MeasurementType = measurementType;
            this.SensorLocation = sensorLocation;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ModifiedTime = modifiedTime;
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTemperaturePeriod" /> class.
        /// </summary>
        public BodyTemperaturePeriod()
        {
        }
    }
}