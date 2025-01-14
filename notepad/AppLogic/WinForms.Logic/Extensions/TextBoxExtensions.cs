namespace WinForms.Logic.Extensions;

/// <summary>
/// Методы расширения для <see cref="TextBox"/>
/// </summary>
public static class TextBoxExtensions
{
    /// <summary>
    /// Возвращает позицию курсора ввода
    /// </summary>
    public static (int Line, int Column) GetInputCursorPosition(this TextBox textBox)
    {
        var line = textBox.GetLineFromCharIndex(textBox.SelectionStart);
        var columnOffset = line;
        var column = (textBox.SelectionStart - columnOffset) - (textBox.GetFirstCharIndexFromLine(line) - columnOffset);
        return new(line, column);
    }
}
