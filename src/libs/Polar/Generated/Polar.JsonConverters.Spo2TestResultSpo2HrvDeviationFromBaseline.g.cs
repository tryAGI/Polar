#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class Spo2TestResultSpo2HrvDeviationFromBaselineJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline>
    {
        /// <inheritdoc />
        public override global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline Read(
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
                        return global::Polar.Spo2TestResultSpo2HrvDeviationFromBaselineExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.Spo2TestResultSpo2HrvDeviationFromBaseline value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Polar.Spo2TestResultSpo2HrvDeviationFromBaselineExtensions.ToValueString(value));
        }
    }
}
