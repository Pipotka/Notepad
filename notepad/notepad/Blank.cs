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

        private void SettingsUpdaed(Settings settings)
        {
            richTextBox.BackColor = settings.BackColor;
            richTextBox.Font = settings.Font;
            richTextBox.ForeColor = settings.ForeColor;
        }

        private async void Blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TextChanged)
            {
                DialogResult message = MessageBox.Show(
                "Сохранить текущий документ перед закрытием бланка?",
                "Закрытие бланка.",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

                if (message == DialogResult.Yes)
                {
                    await SaveFile();
                }
                else if (message == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Сохраняет данные в файл
        /// </summary>
        public async Task SaveFile()
        {
            if (TextChanged)
            {
                if (filePath != null)
                {
                    await File.WriteAllTextAsync(filePath, richTextBox.Text);
                }
                else
                {
                    if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                    {
                        await File.WriteAllTextAsync(saveFileDialog.FileName, richTextBox.Text);
                        FilePath = saveFileDialog.FileName;
                    }
                }
            }
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
    }
}
