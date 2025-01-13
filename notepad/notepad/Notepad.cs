using WinForms.Logic;

namespace notepad
{
    public partial class NotepadWindow : Form
    {
        private string? filePath = null;
        private bool textChanged = false;
        private int numberOfSymbols = 0;
        private string title = "Супер блокнот";

        public NotepadWindow()
        {
            InitializeComponent();
            fontDialog.ShowColor = true;
            colorDialog.FullOpen = true;

            Settings.SettingsChanged += x => MainTextBox.BackColor = x.BackColor;
            Settings.SettingsChanged += x => MainTextBox.Font = x.Font;
            Settings.SettingsChanged += x => MainTextBox.ForeColor = x.ForeColor;

            var settings = Settings.GetInstance();
            MainTextBox.BackColor = settings.BackColor;
            MainTextBox.Font = settings.Font;
            MainTextBox.ForeColor = settings.ForeColor;

            colorDialog.Color = settings.BackColor;
            fontDialog.Font = settings.Font;
            fontDialog.Color = settings.ForeColor;
        }

        private void FontViwe_Click(object sender, EventArgs e)
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

        private void BackgroundColorViwe_Click(object sender, EventArgs e)
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
            if (textChanged)
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
        }

        private void SafeAsFile_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            System.IO.File.WriteAllText(SaveFileDialog.FileName, MainTextBox.Text);
            filePath = SaveFileDialog.FileName;
            this.Text = filePath;
            textChanged = false;
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
                this.Text = filePath;
                textChanged = false;
            }
            else
            {
                System.IO.File.WriteAllText(filePath, MainTextBox.Text);
                textChanged = false;
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            MainTextBox.Text = System.IO.File.ReadAllText(OpenFileDialog.FileName);
            filePath = OpenFileDialog.FileName;
            this.Text = filePath;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
            int Line;
            int Column, ColumnOffset;
            Line = MainTextBox.GetLineFromCharIndex(MainTextBox.SelectionStart);
            ColumnOffset = Line;
            Column = (MainTextBox.SelectionStart - ColumnOffset) - (MainTextBox.GetFirstCharIndexFromLine(Line) - ColumnOffset);
            LineLable.Text = $"Строка {Line + 1}";
            ColumnLable.Text = $"Столбец {Column + 1}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int SymbolsPerMinute;
            int Seconds = 3;
            SymbolsPerMinute = (numberOfSymbols / Seconds) * 20;
            SymbolsPerMinuteLable.Text = $"Символов в минуту: {SymbolsPerMinute};";
            numberOfSymbols = 0;
        }
        private void MainTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberOfSymbols++;
        }
        private void NotepadWindow_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
