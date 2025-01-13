namespace WinForms.Logic;

/// <summary>
/// Модель обновления настроек блокнота
/// </summary>
public class UpdateSettings
{
    /// <summary>
    /// Задний фон
    /// </summary>
    public Color BackColor { get; set; } = Color.White;

    /// <summary>
    /// Шрифт
    /// </summary>
    public Font Font { get; set; } = new Font("Times New Roman", 9f, FontStyle.Regular);

    /// <summary>
    /// Цвет шрифта
    /// </summary>
    public Color ForeColor { get; set; } = Color.Black;
}
