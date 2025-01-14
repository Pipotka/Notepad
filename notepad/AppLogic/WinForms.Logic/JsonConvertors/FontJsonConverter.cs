using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;

namespace WinForms.Logic.JsonConvertors;

/// <summary>
/// JSON конвертер для <see cref="Font"/>
/// </summary>
public class FontJsonConverter : JsonConverter<Font>
{
    /// <inheritdoc/>
    public override Font Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        var fontString = reader.GetString();
        if (string.IsNullOrEmpty(fontString))
        {
            return null;
        }

        var parts = fontString.Split(',');

        if (parts.Length < 3)
        {
            throw new JsonException("Неправильный формат строки для Font.");
        }

        var fontName = parts[0];
        if (!float.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out var fontSize))
        {
            throw new JsonException("Неправильный формат fontSize");
        }

        var fontStyleString = parts[2];
        var fontStyle = FontStyle.Regular;
        if (!string.IsNullOrEmpty(fontStyleString))
        {
            var styles = fontStyleString.Split('|', StringSplitOptions.RemoveEmptyEntries);
            foreach (var style in styles)
            {
                if (Enum.TryParse<FontStyle>(style, out var parsedStyle))
                {
                    fontStyle |= parsedStyle;
                }
                else
                {
                    throw new JsonException($"Недопустимый стиль шрифта: {style}");
                }
            }
        }
        return new Font(fontName, fontSize, fontStyle);
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer,
        Font value,
        JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }

        string fontStyleString = value.Style.ToString().Replace(", ", "|");
        var fontString = $"{value.Name},{value.Size.ToString(CultureInfo.InvariantCulture)},{fontStyleString}";
        writer.WriteStringValue(fontString);
    }
}
