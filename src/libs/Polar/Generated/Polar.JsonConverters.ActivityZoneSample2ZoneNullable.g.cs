#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActivityZoneSample2ZoneNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.ActivityZoneSample2Zone?>
    {
        /// <inheritdoc />
        public override global::Polar.ActivityZoneSample2Zone? Read(
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
                        return global::Polar.ActivityZoneSample2ZoneExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.ActivityZoneSample2Zone)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.ActivityZoneSample2Zone?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.ActivityZoneSample2Zone? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Polar.ActivityZoneSample2ZoneExtensions.ToValueString(value.Value));
            }
        }
    }
}
