#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyTemperaturePeriodSensorLocationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.BodyTemperaturePeriodSensorLocation>
    {
        /// <inheritdoc />
        public override global::Polar.BodyTemperaturePeriodSensorLocation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Polar.BodyTemperaturePeriodSensorLocationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.BodyTemperaturePeriodSensorLocation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.BodyTemperaturePeriodSensorLocation);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.BodyTemperaturePeriodSensorLocation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Polar.BodyTemperaturePeriodSensorLocationExtensions.ToValueString(value));
        }
    }
}
