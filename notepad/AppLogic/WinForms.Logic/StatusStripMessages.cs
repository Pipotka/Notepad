namespace WinForms.Logic;

/// <summary>
/// Сообщения statusStrip
/// </summary>
public static class StatusStripMessages
{
    /// <summary>
    /// Паттерн сообщения "Символов в минуту"
    /// </summary>
    public static string SymbolsPerMinutePattern { get; } = $"Символов в минуту: {{0}};";

    /// <summary>
    /// Паттерн сообщения "Строка"
    /// </summary>
    public static string LinePattern { get; } = $"Строка {{0}};";

    /// <summary>
    /// Паттерн сообщения "Столбец"
    /// </summary>
    public static string ColumnPattern { get; } = $"Столбец {{0}};";
}
