using WinForms.Logic;
using WinForms.Logic.Extensions;
using WinForms.Logic.Infrastructure;

namespace notepad
{
    /// <summary>
    /// Бланк блокнота
    /// </summary>
    public partial class Blank : Form
    {
        private string dockName = "";
        private string? filePath = null;
        private int numberOfSymbols = 0;
        private bool textChanged = false;
        private string bufferText = string.Empty;

        /// <summary>
        /// Флаг, указывающий что текст в блокноте поменялся
        /// </summary>
        public bool TextChanged
        {
            get => textChanged;
            set
            {
                if (value)
                {
                    if (Text.ElementAt(Text.Length - 1) != '*')
                    {
                        Text += '*';
                    }
                }
                else
                {
                    if (Text.ElementAt(Text.Length - 1) == '*')
                    {
                        Text = Text.Remove(Text.Length - 1);
                    }
                }
            }
        }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string? FilePath
        {
            get => filePath;
            set
            {
                if (value != null)
                {
                    var fileInfo = new FileInfo(value);
                    DockName = fileInfo.Name;
                }
                filePath = value;
            }
        }

        /// <summary>
        /// Название документа
        /// </summary>
        public string DockName
        {
            get => dockName;
            set
            {
                dockName = value;
                Text = dockName;
            }
        }

        /// <summary>
        /// Текст бланка
        /// </summary>
        public string BlankText
        {
            get => richTextBox.Text;
            set => richTextBox.Text = value;
        }

        /// <summary>
        /// Конструктор <see cref="Blank"/>
        /// </summary>
        public Blank()
        {
            InitializeComponent();

            Settings.SettingsChanged += SettingsUpdaed;

            var settings = Settings.GetInstance();
            richTextBox.BackColor = settings.BackColor;
            richTextBox.Font = settings.Font;
            richTextBox.ForeColor = settings.ForeColor;
        }

        /// <summary>
        /// Сохраняет данные в файл
        /// </summary>
        public async Task SaveFile(string saveFileName)
        {
            if (string.IsNullOrWhiteSpace(saveFileName))
            {
                FilePath = saveFileName;
                await File.WriteAllTextAsync(filePath!, richTextBox.Text);
            }
        }

        /// <summary>
        /// Вырезание текста
        /// </summary>
        public void Cut()
        {
            bufferText = richTextBox.SelectedText;
            richTextBox.SelectedText = string.Empty;
        }

        /// <summary>
        /// Копирование текста
        /// </summary>
        public void Copy()
         => bufferText = richTextBox.SelectedText;

        /// <summary>
        /// Вставка текста
        /// </summary>
        public void Paste()
            => richTextBox.SelectedText = bufferText;

        /// <summary>
        /// Выделить весь текст
        /// </summary>
        public void SelectAll()
            => richTextBox.SelectAll();

        /// <summary>
        /// Удалить
        /// </summary>
        public void Delete()
            => richTextBox.SelectedText = string.Empty;

        private void SettingsUpdaed(Settings settings)
        {
            richTextBox.BackColor = settings.BackColor;
            richTextBox.Font = settings.Font;
            richTextBox.ForeColor = settings.ForeColor;
        }

        private void Blank_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.SettingsChanged -= SettingsUpdaed;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DisplaySymbolsPerMinuteInfo();
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            if (!TextChanged)
            {
                TextChanged = true;
            }
            DisplayInputCursorPosition();
        }

        private void DisplayInputCursorPosition()
        {
            var position = richTextBox.GetInputCursorPosition();
            toolStripStatusLineLabel.Text = string.Format(StatusStripMessages.LinePattern, position.Line + 1);
            toolStripStatusColumnLabel.Text = string.Format(StatusStripMessages.ColumnPattern, position.Column + 1);
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!TextChanged)
            {
                TextChanged = true;
            }
        }

        private void DisplaySymbolsPerMinuteInfo()
        {
            int symbolsPerMinute;
            int seconds = timer.Interval / 1000;
            symbolsPerMinute = (numberOfSymbols / seconds) * (60 / seconds);
            toolStripStatusSymbolsPerMinuteLabel.Text = string.Format(StatusStripMessages.SymbolsPerMinutePattern, symbolsPerMinute);
            numberOfSymbols = 0;
        }

        private void Blank_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberOfSymbols++;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
            => Delete();

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
            => Cut();

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
            => Copy();

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
            => Paste();

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
            => SelectAll();
    }
}
