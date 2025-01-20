namespace WinForms.Logic.Extensions;

/// <summary>
/// Методы расширения для <see cref="RichTextBox"/>
/// </summary>
public static class RichTextBoxExtensions
{
    /// <summary>
    /// Возвращает позицию курсора ввода
    /// </summary>
    public static (int Line, int Column) GetInputCursorPosition(this RichTextBox richTextBox)
    {
        var line = richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart);
        var columnOffset = line;
        var column = (richTextBox.SelectionStart - columnOffset) - (richTextBox.GetFirstCharIndexFromLine(line) - columnOffset);
        return new(line, column);
    }
}
