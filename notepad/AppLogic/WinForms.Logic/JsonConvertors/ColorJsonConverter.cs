using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinForms.Logic.JsonConvertors;

/// <summary>
/// JSON конвертер для <see cref="Color"/>
/// </summary>
public class ColorJsonConverter : JsonConverter<Color>
{
    /// <inheritdoc/>
    public override Color Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return Color.Empty;
        }

        var colorString = reader.GetString();
        if (string.IsNullOrEmpty(colorString))
        {
            return Color.Empty;
        }

        var parts = colorString.Split(',');

        if (parts.Length != 3)
        {
            throw new JsonException("Неправильный формат строки для Color.");
        }

        if (!byte.TryParse(parts[0], out var red))
        {
            throw new JsonException("Неправильный формат Red");
        }
        if (!byte.TryParse(parts[1], out var green))
        {
            throw new JsonException("Неправильный формат Green");
        }
        if (!byte.TryParse(parts[2], out var blue))
        {
            throw new JsonException("Неправильный формат Blue");
        }

        return Color.FromArgb(red, green, blue);
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer,
        Color value,
        JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }

        var colorString = $"{value.R},{value.G},{value.B}";
        writer.WriteStringValue(colorString);
    }
}
