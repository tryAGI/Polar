#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class PhysicalInfoTrainingBackgroundNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.PhysicalInfoTrainingBackground?>
    {
        /// <inheritdoc />
        public override global::Polar.PhysicalInfoTrainingBackground? Read(
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
                        return global::Polar.PhysicalInfoTrainingBackgroundExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.PhysicalInfoTrainingBackground)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.PhysicalInfoTrainingBackground?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.PhysicalInfoTrainingBackground? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Polar.PhysicalInfoTrainingBackgroundExtensions.ToValueString(value.Value));
            }
        }
    }
}
