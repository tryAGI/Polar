#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class Spo2TestResultTestStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.Spo2TestResultTestStatus?>
    {
        /// <inheritdoc />
        public override global::Polar.Spo2TestResultTestStatus? Read(
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
                        return global::Polar.Spo2TestResultTestStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.Spo2TestResultTestStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.Spo2TestResultTestStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.Spo2TestResultTestStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Polar.Spo2TestResultTestStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
