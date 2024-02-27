namespace notepad
{
    public partial class NotepadWindow : Form
    {
        public string filePath = null;
        public bool textChanged = false;
        public int numberOfSymbols = 0;

        public NotepadWindow()
        {
            InitializeComponent();
            fontDialog.ShowColor = true;
            colorDialog.FullOpen = true;
            colorDialog.Color = MainTextBox.BackColor;
        }
        private void FontViwe_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            MainTextBox.Font = fontDialog.Font;
            MainTextBox.ForeColor = fontDialog.Color;
        }
        private void BackgroundColorViwe_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            MainTextBox.BackColor = colorDialog.Color;
        }
        private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textChanged)
            {
                DialogResult message = MessageBox.Show(
                "Сохранить текущий документ перед выходом?",
                "Выход из программы",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    if (filePath == null)
                    {
                        if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                        {
                            return;
                        }
                        System.IO.File.WriteAllText(SaveFileDialog.FileName, MainTextBox.Text);
                    }
                    else
                    {
                        System.IO.File.WriteAllText(filePath, MainTextBox.Text);
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
            filePath = OpenFileDialog.FileName;
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
