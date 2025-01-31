namespace WinForms.Logic.Infrastructure;

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
    /// Расположение окон
    /// </summary>
    public MdiLayout MdiLayout { get; private set; } = MdiLayout.TileHorizontal;

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
        lazySettings.Value.BackColor = update.BackColor;
        lazySettings.Value.ForeColor = update.ForeColor;
        lazySettings.Value.Font = update.Font;
        lazySettings.Value.MdiLayout = update.MdiLayout;

        SettingsChanged?.Invoke(lazySettings.Value);
    }
}
