
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.BodyTemperaturePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.SkinTemperature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.SkinContactPeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.EcgTestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.Spo2TestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.BodyTemperaturePeriodMeasurementType?), TypeInfoPropertyName = "NullableBodyTemperaturePeriodMeasurementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.BodyTemperaturePeriodSensorLocation?), TypeInfoPropertyName = "NullableBodyTemperaturePeriodSensorLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.EcgTestResultHeartRateVariabilityLevel?), TypeInfoPropertyName = "NullableEcgTestResultHeartRateVariabilityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.QualityMeasurementQualityLevel?), TypeInfoPropertyName = "NullableQualityMeasurementQualityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResultTestStatus?), TypeInfoPropertyName = "NullableSpo2TestResultTestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResultSpo2Class?), TypeInfoPropertyName = "NullableSpo2TestResultSpo2Class2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline?), TypeInfoPropertyName = "NullableSpo2TestResultSpo2ValueDeviationFromBaseline2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline?), TypeInfoPropertyName = "NullableSpo2TestResultSpo2HrvDeviationFromBaseline2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.BodyTemperatureSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.SkinContactChange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.EcgSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.QualityMeasurement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.BodyTemperaturePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.SkinTemperature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.SkinContactPeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.EcgTestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.Spo2TestResult>))]
    internal sealed partial class ElixirTradeBiosensingSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ElixirTradeBiosensingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ElixirTradeBiosensingSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ElixirTradeBiosensingSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Polar.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Polar.BodyTemperaturePeriodMeasurementType)

                    || typeToConvert == typeof(global::Polar.BodyTemperaturePeriodMeasurementType?)

                    || typeToConvert == typeof(global::Polar.BodyTemperaturePeriodSensorLocation)

                    || typeToConvert == typeof(global::Polar.BodyTemperaturePeriodSensorLocation?)

                    || typeToConvert == typeof(global::Polar.EcgTestResultHeartRateVariabilityLevel)

                    || typeToConvert == typeof(global::Polar.EcgTestResultHeartRateVariabilityLevel?)

                    || typeToConvert == typeof(global::Polar.QualityMeasurementQualityLevel)

                    || typeToConvert == typeof(global::Polar.QualityMeasurementQualityLevel?)

                    || typeToConvert == typeof(global::Polar.Spo2TestResultTestStatus)

                    || typeToConvert == typeof(global::Polar.Spo2TestResultTestStatus?)

                    || typeToConvert == typeof(global::Polar.Spo2TestResultSpo2Class)

                    || typeToConvert == typeof(global::Polar.Spo2TestResultSpo2Class?)

                    || typeToConvert == typeof(global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline)

                    || typeToConvert == typeof(global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline?)

                    || typeToConvert == typeof(global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline)

                    || typeToConvert == typeof(global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Polar.BodyTemperaturePeriodMeasurementType))
                {
                    return new global::Polar.JsonConverters.BodyTemperaturePeriodMeasurementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.BodyTemperaturePeriodMeasurementType?))
                {
                    return new global::Polar.JsonConverters.BodyTemperaturePeriodMeasurementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.BodyTemperaturePeriodSensorLocation))
                {
                    return new global::Polar.JsonConverters.BodyTemperaturePeriodSensorLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.BodyTemperaturePeriodSensorLocation?))
                {
                    return new global::Polar.JsonConverters.BodyTemperaturePeriodSensorLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.EcgTestResultHeartRateVariabilityLevel))
                {
                    return new global::Polar.JsonConverters.EcgTestResultHeartRateVariabilityLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.EcgTestResultHeartRateVariabilityLevel?))
                {
                    return new global::Polar.JsonConverters.EcgTestResultHeartRateVariabilityLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.QualityMeasurementQualityLevel))
                {
                    return new global::Polar.JsonConverters.QualityMeasurementQualityLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.QualityMeasurementQualityLevel?))
                {
                    return new global::Polar.JsonConverters.QualityMeasurementQualityLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.Spo2TestResultTestStatus))
                {
                    return new global::Polar.JsonConverters.Spo2TestResultTestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.Spo2TestResultTestStatus?))
                {
                    return new global::Polar.JsonConverters.Spo2TestResultTestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.Spo2TestResultSpo2Class))
                {
                    return new global::Polar.JsonConverters.Spo2TestResultSpo2ClassJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.Spo2TestResultSpo2Class?))
                {
                    return new global::Polar.JsonConverters.Spo2TestResultSpo2ClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline))
                {
                    return new global::Polar.JsonConverters.Spo2TestResultSpo2ValueDeviationFromBaselineJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline?))
                {
                    return new global::Polar.JsonConverters.Spo2TestResultSpo2ValueDeviationFromBaselineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline))
                {
                    return new global::Polar.JsonConverters.Spo2TestResultSpo2HrvDeviationFromBaselineJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline?))
                {
                    return new global::Polar.JsonConverters.Spo2TestResultSpo2HrvDeviationFromBaselineNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ElixirTradeBiosensingSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}