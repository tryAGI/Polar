#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class AlertnessGradeTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.AlertnessGradeType>
    {
        /// <inheritdoc />
        public override global::Polar.AlertnessGradeType Read(
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
                        return global::Polar.AlertnessGradeTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.AlertnessGradeType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.AlertnessGradeType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.AlertnessGradeType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Polar.AlertnessGradeTypeExtensions.ToValueString(value));
        }
    }
}
