using System.Text.Json;
using System.Text.Json.Serialization;

namespace MoveM8s.Converters;
public class IdConverter : JsonConverter<string>
{
    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number)
        {
            // Read the numeric value
            var idValue = reader.GetInt32();

            // Convert the numeric value to string
            return idValue.ToString();
        }

        // Return the value as is
        return reader.GetString();
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        // Write the string value
        writer.WriteStringValue(value);
    }
}