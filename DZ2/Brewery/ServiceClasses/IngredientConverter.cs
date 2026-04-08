using Brewery.Classes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Brewery.ServiceClasses
{
    public class IngredientConverter : JsonConverter<Ingredient>
    {
        public override Ingredient Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<Ingredient>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, Ingredient value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }

        public override Ingredient ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string keyString = reader.GetString();

            var parts = keyString.Split('|');
            if (parts.Length == 3 && Guid.TryParse(parts[0], out Guid id))
            {
                return new Ingredient(id, parts[1], parts[2]);
            }

            throw new JsonException($"Не удалось десериализовать ключ '{keyString}' в Ingredient");
        }

        public override void WriteAsPropertyName(Utf8JsonWriter writer, Ingredient value, JsonSerializerOptions options)
        {
            string key = $"{value.Id}|{value.Name}|{value.UnitMeasurement}";
            writer.WritePropertyName(key);
        }
    }
}
