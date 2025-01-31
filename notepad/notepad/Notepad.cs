using System.Text.Json;
using WinForms.Logic.FilesLogic;
using WinForms.Logic.Infrastructure;

namespace notepad
{
    /// <summary>
    /// Блокнот
    /// </summary>
    public partial class NotepadWindow : Form
    {
        private int openDocuments = 0;

        private MdiLayout mdiLayout = MdiLayout.Cascade;

        /// <summary>
        /// Конструктор <see cref="NotepadWindow"/>
        /// </summary>
        public NotepadWindow()
        {
            InitializeComponent();
            fontDialog.ShowColor = true;
            colorDialog.FullOpen = true;

            LoadSettings();
            var settings = Settings.GetInstance();
            colorDialog.Color = settings.BackColor;
            fontDialog.Font = settings.Font;
            fontDialog.Color = settings.ForeColor;
            UpdateMdiLayout(settings.MdiLayout);
        }

        private void LoadSettings()
        {
            using (var fs = new FileStream(FileNames.SettingsFile, FileMode.OpenOrCreate, FileAccess.Read))
            {
                try
                {
                    var settingsData = JsonSerializer.Deserialize<UpdateSettings>(fs);
                    if (settingsData != null)
                    {
                        Settings.UpdateSettings(settingsData);
                    }
                }
                catch { }
            }
        }

        private void UpdateMdiLayout(MdiLayout mdiLayout)
        {
            this.mdiLayout = mdiLayout;
            LayoutMdi(mdiLayout);
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

        private async void NotepadForm_FormClosingAsync(object sender, FormClosingEventArgs e)
        {
            var isClosWindow = MessageBox.Show("Вы уверены что хотите выйти из блокнота?", "Закрытие блокнота", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isClosWindow == DialogResult.Yes)
            {
                var hasChanged = false;
                foreach (var blank in MdiChildren.OfType<Blank>())
                {
                    if (blank.IsTextChanged)
                    {
                        hasChanged = true;
                        break;
                    }
                }
                if (hasChanged)
                {
                    var isSaveChanges = MessageBox.Show("Сохранить изменения?", "Закрытие блокнота", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (isSaveChanges == DialogResult.Yes)
                    {
                        await SaveBlanks();

                    }
                }

                await SaveSettings();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private async Task SaveSettings()
        {
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
                await JsonSerializer.SerializeAsync(fs, savedSettings);
                fs.Flush();
            }
        }

        private async void SaveFile_Click(object sender, EventArgs e)
        {
            await SaveBlanks();
        }

        private async Task SaveBlanks()
        {
            foreach (var blank in MdiChildren.OfType<Blank>())
            {
                if (blank.IsTextChanged)
                {
                    if (!string.IsNullOrWhiteSpace(blank.FilePath))
                    {
                        SaveFileDialog.FileName = blank.FilePath;
                        await blank.SaveFile(blank.FilePath);
                    }
                    else
                    {
                        SaveFileDialog.FileName = blank.DockName;
                        if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
                        {
                            await blank.SaveFile(SaveFileDialog.FileName);
                        }
                    }
                }
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenNewBlankFromFile();
        }

        private void OpenNewBlankFromFile()
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                var text = System.IO.File.ReadAllText(OpenFileDialog.FileName);
                var blank = CreateNewBlank(filePath: OpenFileDialog.FileName, text: text);
                blank.Show();
            }
            UpdateMdiLayout(mdiLayout);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewBlank();
        }

        private void OpenNewBlank()
        {
            var newBlank = CreateNewBlank(title: $"Новый документ {++openDocuments}");
            newBlank.Show();
            UpdateMdiLayout(mdiLayout);
        }

        private Blank CreateNewBlank(string? title = null, string? filePath = null, string? text = null)
        {
            var newBlank = new Blank();
            newBlank.DockName = title ?? string.Empty;
            newBlank.FilePath = filePath;
            newBlank.RichTextBox.Text = text ?? string.Empty;
            newBlank.MdiParent = this;
            return newBlank;
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMdiLayout(MdiLayout.ArrangeIcons);
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMdiLayout(MdiLayout.Cascade);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMdiLayout(MdiLayout.TileHorizontal);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMdiLayout(MdiLayout.TileVertical);
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutFromBlank();
        }

        private void CutFromBlank()
        {
            if (ActiveMdiChild is Blank blank)
            {
                blank.Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyFromBlank();
        }

        private void CopyFromBlank()
        {
            if (ActiveMdiChild is Blank blank)
            {
                blank.Copy();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteInBlank();
        }

        private void PasteInBlank()
        {
            if (ActiveMdiChild is Blank blank)
            {
                blank.Paste();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Blank blank)
            {
                blank.Delete();
            }
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Blank blank)
            {
                blank.SelectAll();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var findForm = new FindForm();
            if (findForm.ShowDialog(this) == DialogResult.OK)
            {
                if (ActiveMdiChild is Blank blank)
                {
                    var start = blank.RichTextBox.SelectionStart;
                    blank.RichTextBox.Find(findForm.FindText, findForm.FindCondition);
                }
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            OpenNewBlank();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenNewBlankFromFile();
        }

        private async void saveToolStripButton_Click(object sender, EventArgs e)
        {
            await SaveBlanks();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            CutFromBlank();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            CopyFromBlank();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            PasteInBlank();
        }
    }
}
