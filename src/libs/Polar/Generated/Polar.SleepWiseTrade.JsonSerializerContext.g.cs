
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.Alertness>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Polar.CircadianBedtime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessGradeType?), TypeInfoPropertyName = "NullableAlertnessGradeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessGradeClassification?), TypeInfoPropertyName = "NullableAlertnessGradeClassification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessValidity?), TypeInfoPropertyName = "NullableAlertnessValidity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessSleepInertia?), TypeInfoPropertyName = "NullableAlertnessSleepInertia2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessSleepType?), TypeInfoPropertyName = "NullableAlertnessSleepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessResultType?), TypeInfoPropertyName = "NullableAlertnessResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CircadianBedtimeValidity?), TypeInfoPropertyName = "NullableCircadianBedtimeValidity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CircadianBedtimeQuality?), TypeInfoPropertyName = "NullableCircadianBedtimeQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.CircadianBedtimeResultType?), TypeInfoPropertyName = "NullableCircadianBedtimeResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessHourlyDataValidity?), TypeInfoPropertyName = "NullableAlertnessHourlyDataValidity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Polar.AlertnessHourlyDataAlertnessLevel?), TypeInfoPropertyName = "NullableAlertnessHourlyDataAlertnessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.AlertnessHourlyData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.Alertness>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Polar.CircadianBedtime>))]
    internal sealed partial class SleepWiseTradeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SleepWiseTradeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SleepWiseTradeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SleepWiseTradeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Polar.AlertnessGradeType)

                    || typeToConvert == typeof(global::Polar.AlertnessGradeType?)

                    || typeToConvert == typeof(global::Polar.AlertnessGradeClassification)

                    || typeToConvert == typeof(global::Polar.AlertnessGradeClassification?)

                    || typeToConvert == typeof(global::Polar.AlertnessValidity)

                    || typeToConvert == typeof(global::Polar.AlertnessValidity?)

                    || typeToConvert == typeof(global::Polar.AlertnessSleepInertia)

                    || typeToConvert == typeof(global::Polar.AlertnessSleepInertia?)

                    || typeToConvert == typeof(global::Polar.AlertnessSleepType)

                    || typeToConvert == typeof(global::Polar.AlertnessSleepType?)

                    || typeToConvert == typeof(global::Polar.AlertnessResultType)

                    || typeToConvert == typeof(global::Polar.AlertnessResultType?)

                    || typeToConvert == typeof(global::Polar.CircadianBedtimeValidity)

                    || typeToConvert == typeof(global::Polar.CircadianBedtimeValidity?)

                    || typeToConvert == typeof(global::Polar.CircadianBedtimeQuality)

                    || typeToConvert == typeof(global::Polar.CircadianBedtimeQuality?)

                    || typeToConvert == typeof(global::Polar.CircadianBedtimeResultType)

                    || typeToConvert == typeof(global::Polar.CircadianBedtimeResultType?)

                    || typeToConvert == typeof(global::Polar.AlertnessHourlyDataValidity)

                    || typeToConvert == typeof(global::Polar.AlertnessHourlyDataValidity?)

                    || typeToConvert == typeof(global::Polar.AlertnessHourlyDataAlertnessLevel)

                    || typeToConvert == typeof(global::Polar.AlertnessHourlyDataAlertnessLevel?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Polar.AlertnessGradeType))
                {
                    return new global::Polar.JsonConverters.AlertnessGradeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessGradeType?))
                {
                    return new global::Polar.JsonConverters.AlertnessGradeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessGradeClassification))
                {
                    return new global::Polar.JsonConverters.AlertnessGradeClassificationJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessGradeClassification?))
                {
                    return new global::Polar.JsonConverters.AlertnessGradeClassificationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessValidity))
                {
                    return new global::Polar.JsonConverters.AlertnessValidityJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessValidity?))
                {
                    return new global::Polar.JsonConverters.AlertnessValidityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessSleepInertia))
                {
                    return new global::Polar.JsonConverters.AlertnessSleepInertiaJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessSleepInertia?))
                {
                    return new global::Polar.JsonConverters.AlertnessSleepInertiaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessSleepType))
                {
                    return new global::Polar.JsonConverters.AlertnessSleepTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessSleepType?))
                {
                    return new global::Polar.JsonConverters.AlertnessSleepTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessResultType))
                {
                    return new global::Polar.JsonConverters.AlertnessResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessResultType?))
                {
                    return new global::Polar.JsonConverters.AlertnessResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.CircadianBedtimeValidity))
                {
                    return new global::Polar.JsonConverters.CircadianBedtimeValidityJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.CircadianBedtimeValidity?))
                {
                    return new global::Polar.JsonConverters.CircadianBedtimeValidityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.CircadianBedtimeQuality))
                {
                    return new global::Polar.JsonConverters.CircadianBedtimeQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.CircadianBedtimeQuality?))
                {
                    return new global::Polar.JsonConverters.CircadianBedtimeQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.CircadianBedtimeResultType))
                {
                    return new global::Polar.JsonConverters.CircadianBedtimeResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.CircadianBedtimeResultType?))
                {
                    return new global::Polar.JsonConverters.CircadianBedtimeResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessHourlyDataValidity))
                {
                    return new global::Polar.JsonConverters.AlertnessHourlyDataValidityJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessHourlyDataValidity?))
                {
                    return new global::Polar.JsonConverters.AlertnessHourlyDataValidityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessHourlyDataAlertnessLevel))
                {
                    return new global::Polar.JsonConverters.AlertnessHourlyDataAlertnessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Polar.AlertnessHourlyDataAlertnessLevel?))
                {
                    return new global::Polar.JsonConverters.AlertnessHourlyDataAlertnessLevelNullableJsonConverter();
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
                    0 => new SleepWiseTradeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}