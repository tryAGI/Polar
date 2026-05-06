#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class PhysicalInfoGenderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.PhysicalInfoGender?>
    {
        /// <inheritdoc />
        public override global::Polar.PhysicalInfoGender? Read(
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
                        return global::Polar.PhysicalInfoGenderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.PhysicalInfoGender)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.PhysicalInfoGender?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.PhysicalInfoGender? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Polar.PhysicalInfoGenderExtensions.ToValueString(value.Value));
            }
        }
    }
}
