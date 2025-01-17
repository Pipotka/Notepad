using System.Text.Json;
using WinForms.Logic;
using WinForms.Logic.Extensions;

namespace notepad
{
    public partial class NotepadWindow : Form
    {
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
        /// Конструктор <see cref="NotepadWindow"/>
        /// </summary>
        public NotepadWindow()
        {
            InitializeComponent();
            fontDialog.ShowColor = true;
            colorDialog.FullOpen = true;

            Settings.SettingsChanged += x => MainTextBox.BackColor = x.BackColor;
            Settings.SettingsChanged += x => MainTextBox.Font = x.Font;
            Settings.SettingsChanged += x => MainTextBox.ForeColor = x.ForeColor;

            LoadSettings();
            var settings = Settings.GetInstance();
            MainTextBox.BackColor = settings.BackColor;
            MainTextBox.Font = settings.Font;
            MainTextBox.ForeColor = settings.ForeColor;

            colorDialog.Color = settings.BackColor;
            fontDialog.Font = settings.Font;
            fontDialog.Color = settings.ForeColor;
        }

        private void LoadSettings()
        {
            using (var fs = new FileStream(FileNames.SettingsFile, FileMode.OpenOrCreate, FileAccess.Read))
            {
                try
                {
                    var settingsData = JsonSerializer.Deserialize<UpdateSettings>(fs);
                    Settings.UpdateSettings(settingsData);
                }
                catch { }
            }
        }

        private void FontView_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var settings = Settings.GetInstance();
            var updatedSettings = new UpdateSettings()
            {
                BackColor = settings.BackColor,
                ForeColor = fontDialog.Color,
                Font = fontDialog.Font,
            };
            Settings.UpdateSettings(updatedSettings);
        }

        private void BackgroundColorView_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var settings = Settings.GetInstance();
            var updatedSettings = new UpdateSettings()
            {
                BackColor = colorDialog.Color,
                ForeColor = settings.ForeColor,
                Font = settings.Font,
            };
            Settings.UpdateSettings(updatedSettings);
        }

        private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TextChanged)
            {
                DialogResult message = MessageBox.Show(
                "Сохранить текущий документ перед выходом из супер блокнота?",
                "Выход из программы.",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

                if (message == DialogResult.Yes)
                {
                    if (filePath != null)
                    {
                        System.IO.File.WriteAllText(filePath, MainTextBox.Text);
                    }
                    else
                    {
                        if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                        {
                            return;
                        }
                        System.IO.File.WriteAllText(SaveFileDialog.FileName, MainTextBox.Text);
                    }
                }
                else if (message == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            System.IO.File.Delete(FileNames.SettingsFile);
            using (var fs = new FileStream(FileNames.SettingsFile, FileMode.OpenOrCreate))
            {
                var settings = Settings.GetInstance();
                var savedSettings = new UpdateSettings
                {
                    BackColor = settings.BackColor,
                    ForeColor = settings.ForeColor,
                    Font = settings.Font,
                };
                JsonSerializer.Serialize(fs, savedSettings);
                fs.Flush();
            }
        }

        private void SafeAsFile_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            System.IO.File.WriteAllText(SaveFileDialog.FileName, MainTextBox.Text);
            filePath = SaveFileDialog.FileName;
            Text = filePath;
            TextChanged = false;
        }

        private void SafeFile_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                System.IO.File.WriteAllText(SaveFileDialog.FileName, MainTextBox.Text);
                filePath = OpenFileDialog.FileName;
                Text = filePath;
            }
            else
            {
                System.IO.File.WriteAllText(filePath, MainTextBox.Text);
            }
            TextChanged = false;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            MainTextBox.Text = System.IO.File.ReadAllText(OpenFileDialog.FileName);
            filePath = OpenFileDialog.FileName;
            Text = filePath;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!TextChanged)
            {
                TextChanged = true;
            }
            DisplayInputCursorPosition();
        }

        private void DisplayInputCursorPosition()
        {
            var position = MainTextBox.GetInputCursorPosition();
            toolStripStatusLineLabel.Text = string.Format(StatusStripMessages.LinePattern, position.Line + 1);
            toolStripStatusColumnLabel.Text = string.Format(StatusStripMessages.ColumnPattern, position.Column + 1);
        }

        private void DisplaySymbolsPerMinuteInfo()
        {
            int symbolsPerMinute;
            int seconds = timer.Interval / 1000;
            symbolsPerMinute = (numberOfSymbols / seconds) * (60 / seconds);
            toolStripStatusSymbolsPerMinuteLabel.Text = string.Format(StatusStripMessages.SymbolsPerMinutePattern, symbolsPerMinute);
            numberOfSymbols = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DisplaySymbolsPerMinuteInfo();
        }

        private void MainTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberOfSymbols++;
        }

        private void NotepadWindow_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newBlank = new Blank();
            newBlank.Show();
        }
    }
}
