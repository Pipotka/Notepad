using System.Text.Json.Serialization;
using WinForms.Logic.JsonConvertors;

namespace WinForms.Logic.Infrastructure;

/// <summary>
/// Модель обновления настроек блокнота
/// </summary>
public class UpdateSettings
{
    /// <summary>
    /// Задний фон
    /// </summary>
    [JsonConverter(typeof(ColorJsonConverter))]
    public Color BackColor { get; set; } = Color.White;

    /// <summary>
    /// Шрифт
    /// </summary>
    [JsonConverter(typeof(FontJsonConverter))]
    public Font Font { get; set; } = new Font("Times New Roman", 9f, FontStyle.Regular);

    /// <summary>
    /// Цвет шрифта
    /// </summary>
    [JsonConverter(typeof(ColorJsonConverter))]
    public Color ForeColor { get; set; } = Color.Black;

    /// <summary>
    /// Конструктор <see cref="UpdateSettings"/>
    /// </summary>
    public UpdateSettings() { }

    /// <summary>
    /// Параметризованный конструктор <see cref="UpdateSettings"/>
    /// </summary>
    [JsonConstructor]
    public UpdateSettings(Color backColor, Font font, Color foreColor)
    {
        BackColor = backColor;
        Font = font;
        ForeColor = foreColor;
    }
}
