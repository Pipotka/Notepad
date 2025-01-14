namespace WinForms.Logic;

/// <summary>
/// Настройки блокнота
/// </summary>
public sealed class Settings
{
    private static readonly Lazy<Settings> lazySettings
        = new(() => new Settings());

    private Settings() { }

    /// <summary>
    /// Вызывается, когда изменяется <see cref="Settings"/>
    /// </summary>
    public static event SettingsChangeHandler? SettingsChanged;

    /// <summary>
    /// Делегат обработчика изменения <see cref="Settings"/>
    /// </summary>
    /// <param name="settings"></param>
    public delegate void SettingsChangeHandler(Settings settings);

    /// <summary>
    /// Задний фон
    /// </summary>
    public Color BackColor { get; private set; } = Color.White;

    /// <summary>
    /// Шрифт
    /// </summary>
    public Font Font { get; private set; } = new Font("Times New Roman", 9f, FontStyle.Regular);

    /// <summary>
    /// Цвет шрифта
    /// </summary>
    public Color ForeColor { get; private set; } = Color.Black;

    /// <summary>
    /// Возвращает <see cref="Settings"/>
    /// </summary>
    public static Settings GetInstance()
    {
        return lazySettings.Value;
    }

    /// <summary>
    /// Изменяет настройки
    /// </summary>
    public static void UpdateSettings(UpdateSettings update)
    {
        var oldSettings = lazySettings.Value;
        oldSettings.BackColor = update.BackColor;
        oldSettings.ForeColor = update.ForeColor;
        oldSettings.Font = update.Font;

        SettingsChanged?.Invoke(lazySettings.Value);
    }
}
