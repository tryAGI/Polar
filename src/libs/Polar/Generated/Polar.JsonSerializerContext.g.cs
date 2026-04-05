
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Polar
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Polar.JsonConverters.TrainingLoadProRpeEnumJsonConverter),

            typeof(global::Polar.JsonConverters.TrainingLoadProRpeEnumNullableJsonConverter),

            typeof(global::Polar.JsonConverters.TrainingLoadProLoadEnumJsonConverter),

            typeof(global::Polar.JsonConverters.TrainingLoadProLoadEnumNullableJsonConverter),

            typeof(global::Polar.JsonConverters.CardioLoadStatusEnumJsonConverter),

            typeof(global::Polar.JsonConverters.CardioLoadStatusEnumNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AvailableUserDataDataTypeJsonConverter),

            typeof(global::Polar.JsonConverters.AvailableUserDataDataTypeNullableJsonConverter),

            typeof(global::Polar.JsonConverters.ActivityZoneSample2ZoneJsonConverter),

            typeof(global::Polar.JsonConverters.ActivityZoneSample2ZoneNullableJsonConverter),

            typeof(global::Polar.JsonConverters.PhysicalInformationWeightSourceJsonConverter),

            typeof(global::Polar.JsonConverters.PhysicalInformationWeightSourceNullableJsonConverter),

            typeof(global::Polar.JsonConverters.UserGenderJsonConverter),

            typeof(global::Polar.JsonConverters.UserGenderNullableJsonConverter),

            typeof(global::Polar.JsonConverters.WebhookPingEventJsonConverter),

            typeof(global::Polar.JsonConverters.WebhookPingEventNullableJsonConverter),

            typeof(global::Polar.JsonConverters.WebhookTypeJsonConverter),

            typeof(global::Polar.JsonConverters.WebhookTypeNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessGradeTypeJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessGradeTypeNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessGradeClassificationJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessGradeClassificationNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessValidityJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessValidityNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessSleepInertiaJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessSleepInertiaNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessSleepTypeJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessSleepTypeNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessResultTypeJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessResultTypeNullableJsonConverter),

            typeof(global::Polar.JsonConverters.CircadianBedtimeValidityJsonConverter),

            typeof(global::Polar.JsonConverters.CircadianBedtimeValidityNullableJsonConverter),

            typeof(global::Polar.JsonConverters.CircadianBedtimeQualityJsonConverter),

            typeof(global::Polar.JsonConverters.CircadianBedtimeQualityNullableJsonConverter),

            typeof(global::Polar.JsonConverters.CircadianBedtimeResultTypeJsonConverter),

            typeof(global::Polar.JsonConverters.CircadianBedtimeResultTypeNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessHourlyDataValidityJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessHourlyDataValidityNullableJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessHourlyDataAlertnessLevelJsonConverter),

            typeof(global::Polar.JsonConverters.AlertnessHourlyDataAlertnessLevelNullableJsonConverter),

            typeof(global::Polar.JsonConverters.BodyTemperaturePeriodMeasurementTypeJsonConverter),

            typeof(global::Polar.JsonConverters.BodyTemperaturePeriodMeasurementTypeNullableJsonConverter),

            typeof(global::Polar.JsonConverters.BodyTemperaturePeriodSensorLocationJsonConverter),

            typeof(global::Polar.JsonConverters.BodyTemperaturePeriodSensorLocationNullableJsonConverter),

            typeof(global::Polar.JsonConverters.EcgTestResultHeartRateVariabilityLevelJsonConverter),

            typeof(global::Polar.JsonConverters.EcgTestResultHeartRateVariabilityLevelNullableJsonConverter),

            typeof(global::Polar.JsonConverters.QualityMeasurementQualityLevelJsonConverter),

            typeof(global::Polar.JsonConverters.QualityMeasurementQualityLevelNullableJsonConverter),

            typeof(global::Polar.JsonConverters.Spo2TestResultTestStatusJsonConverter),

            typeof(global::Polar.JsonConverters.Spo2TestResultTestStatusNullableJsonConverter),

            typeof(global::Polar.JsonConverters.Spo2TestResultSpo2ClassJsonConverter),

            typeof(global::Polar.JsonConverters.Spo2TestResultSpo2ClassNullableJsonConverter),

            typeof(global::Polar.JsonConverters.Spo2TestResultSpo2ValueDeviationFromBaselineJsonConverter),

            typeof(global::Polar.JsonConverters.Spo2TestResultSpo2ValueDeviationFromBaselineNullableJsonConverter),

            typeof(global::Polar.JsonConverters.Spo2TestResultSpo2HrvDeviationFromBaselineJsonConverter),

            typeof(global::Polar.JsonConverters.Spo2TestResultSpo2HrvDeviationFromBaselineNullableJsonConverter),

            typeof(global::Polar.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.TrainingLoadProRpeEnum), TypeInfoPropertyName = "TrainingLoadProRpeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.TrainingLoadProLoadEnum), TypeInfoPropertyName = "TrainingLoadProLoadEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.TrainingLoadProSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.CardioLoad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CardioLoad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CardioLoadStatusEnum), TypeInfoPropertyName = "CardioLoadStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CardioLoadLevels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AvailableUserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AvailableUserDataDataType), TypeInfoPropertyName = "AvailableUserDataDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.DurationZone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.HeartRate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.UserExtraInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Activity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.ActivitySummaryWithAllSamples>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivitySummaryWithAllSamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityDayWithSamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivitySummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityStepSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.ActivityDayWithSamples>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivitySteps2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityZoneSamples2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.ActivityDayWithSamplesInactivityStamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityDayWithSamplesInactivityStamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.ActivityStepSample2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityStepSample2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityStepSamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.ActivityStepSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityZoneSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.DurationZone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityZoneSample2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityZoneSample2Zone), TypeInfoPropertyName = "ActivityZoneSample2Zone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.ActivityZoneSample2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ActivityZoneSamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.ActivityZoneSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AvailableUserDatas))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.AvailableUserData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Exercise))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ExerciseHashId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.Zone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Zone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.Sample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Sample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.Location>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Location))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.ExerciseHashId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Exercises))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.PhysicalInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.PhysicalInformationWeightSource), TypeInfoPropertyName = "PhysicalInformationWeightSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.PhysicalInformations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Register))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Samples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.TransactionLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.UserGender), TypeInfoPropertyName = "UserGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.UserExtraInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CreatedWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CreatedWebhookData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.WebhookType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookType), TypeInfoPropertyName = "WebhookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.WebhookInfoDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookInfoDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPayloadExercise))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPayloadSleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPayloadContinuousHeartRate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPayloadCircadianBedtime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPayloadAlertness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPayloadActivitySummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookPingEvent), TypeInfoPropertyName = "WebhookPingEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.WebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Zones))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Sleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Nights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AvailableSleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AvailableSleeps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.AvailableSleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.NightlyRecharge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ContinuousHeartrate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.ContinuousHeartrateHeartRateSamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Recharges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.NightlyRecharge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Alertness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessGradeType), TypeInfoPropertyName = "AlertnessGradeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessGradeClassification), TypeInfoPropertyName = "AlertnessGradeClassification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessValidity), TypeInfoPropertyName = "AlertnessValidity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessSleepInertia), TypeInfoPropertyName = "AlertnessSleepInertia2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessSleepType), TypeInfoPropertyName = "AlertnessSleepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessResultType), TypeInfoPropertyName = "AlertnessResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.AlertnessHourlyData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessHourlyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CircadianBedtime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CircadianBedtimeValidity), TypeInfoPropertyName = "CircadianBedtimeValidity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CircadianBedtimeQuality), TypeInfoPropertyName = "CircadianBedtimeQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CircadianBedtimeResultType), TypeInfoPropertyName = "CircadianBedtimeResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessHourlyDataValidity), TypeInfoPropertyName = "AlertnessHourlyDataValidity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessHourlyDataAlertnessLevel), TypeInfoPropertyName = "AlertnessHourlyDataAlertnessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.BodyTemperaturePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.BodyTemperaturePeriodMeasurementType), TypeInfoPropertyName = "BodyTemperaturePeriodMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.BodyTemperaturePeriodSensorLocation), TypeInfoPropertyName = "BodyTemperaturePeriodSensorLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.BodyTemperatureSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.BodyTemperatureSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.SkinTemperature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.SkinContactPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.SkinContactChange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.SkinContactChange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.EcgTestResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.EcgTestResultHeartRateVariabilityLevel), TypeInfoPropertyName = "EcgTestResultHeartRateVariabilityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.EcgSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.EcgSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.QualityMeasurement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.QualityMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.QualityMeasurementQualityLevel), TypeInfoPropertyName = "QualityMeasurementQualityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResultTestStatus), TypeInfoPropertyName = "Spo2TestResultTestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResultSpo2Class), TypeInfoPropertyName = "Spo2TestResultSpo2Class2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline), TypeInfoPropertyName = "Spo2TestResultSpo2ValueDeviationFromBaseline2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline), TypeInfoPropertyName = "Spo2TestResultSpo2HrvDeviationFromBaseline2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.Alertness>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.CircadianBedtime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.BodyTemperaturePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.SkinTemperature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.SkinContactPeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.EcgTestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.Spo2TestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.CardioLoad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.ActivitySummaryWithAllSamples>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.ActivityDayWithSamples>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.ActivityDayWithSamplesInactivityStamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.ActivityStepSample2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.ActivityStepSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.DurationZone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.ActivityZoneSample2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.ActivityZoneSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.AvailableUserData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.Zone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.Sample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.Location>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.ExerciseHashId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.UserExtraInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.WebhookType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.WebhookInfoDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.AvailableSleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.NightlyRecharge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.AlertnessHourlyData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.BodyTemperatureSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.SkinContactChange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.EcgSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.QualityMeasurement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.Alertness>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.CircadianBedtime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.BodyTemperaturePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.SkinTemperature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.SkinContactPeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.EcgTestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.Spo2TestResult>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}