#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class Spo2TestResultSpo2ValueDeviationFromBaselineNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline?>
    {
        /// <inheritdoc />
        public override global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline? Read(
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
                        return global::Polar.Spo2TestResultSpo2ValueDeviationFromBaselineExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.Spo2TestResultSpo2ValueDeviationFromBaseline? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Polar.Spo2TestResultSpo2ValueDeviationFromBaselineExtensions.ToValueString(value.Value));
            }
        }
    }
}
