#nullable enable

namespace Polar.JsonConverters
{
    /// <inheritdoc />
    public sealed class PhysicalInformationWeightSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Polar.PhysicalInformationWeightSource>
    {
        /// <inheritdoc />
        public override global::Polar.PhysicalInformationWeightSource Read(
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
                        return global::Polar.PhysicalInformationWeightSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Polar.PhysicalInformationWeightSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Polar.PhysicalInformationWeightSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Polar.PhysicalInformationWeightSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Polar.PhysicalInformationWeightSourceExtensions.ToValueString(value));
        }
    }
}
