#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class PhysicalInfoWeightSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.PhysicalInfoWeightSource>
    {
        /// <inheritdoc />
        public override global::Polar.PhysicalInfoWeightSource Read(
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
                        return global::Polar.PhysicalInfoWeightSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.PhysicalInfoWeightSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.PhysicalInfoWeightSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.PhysicalInfoWeightSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Polar.PhysicalInfoWeightSourceExtensions.ToValueString(value));
        }
    }
}
