namespace notepad
{
    public partial class NotepadWindow : Form
    {
        public string _filePath = null;
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
            DialogResult message = MessageBox.Show(
                "Сохранить текущий документ перед выходом?",
                "Выход из программы",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
            {
                if (_filePath == null)
                {
                    if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                    System.IO.File.WriteAllText(SaveFileDialog.FileName, MainTextBox.Text);
                }
                else
                {
                    System.IO.File.WriteAllText(_filePath, MainTextBox.Text);
                }
            }
            else if (message == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SafeAsFile_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            System.IO.File.WriteAllText(SaveFileDialog.FileName, MainTextBox.Text);
            _filePath = OpenFileDialog.FileName;
            this.Text = _filePath;
        }

        private void SafeFile_Click(object sender, EventArgs e)
        {
            if (_filePath == null)
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                System.IO.File.WriteAllText(SaveFileDialog.FileName, MainTextBox.Text);
                _filePath = OpenFileDialog.FileName;
                this.Text = _filePath;
            }
            else
            {
                System.IO.File.WriteAllText(_filePath, MainTextBox.Text);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            MainTextBox.Text = System.IO.File.ReadAllText(OpenFileDialog.FileName);
            _filePath = OpenFileDialog.FileName;
            this.Text = _filePath;
        }
    }
}
