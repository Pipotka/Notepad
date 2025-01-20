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

        private async void NotepadForm_FormClosingAsync(object sender, FormClosingEventArgs e)
        {
            await SaveBlanks();

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

        private async void SaveFile_Click(object sender, EventArgs e)
        {
            await SaveBlanks();
        }

        private async Task SaveBlanks()
        {
            foreach (var blank in MdiChildren.OfType<Blank>())
            {
                await blank.SaveFile();
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                var text = System.IO.File.ReadAllText(OpenFileDialog.FileName);
                var blank = CreateNewBlank(filePath: OpenFileDialog.FileName, text: text);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newBlank = CreateNewBlank(title: $"Новый доумент {++openDocuments}");
            newBlank.Show();
        }

        private Blank CreateNewBlank(string? title = null, string? filePath = null, string? text = null)
        {
            var newBlank = new Blank();
            newBlank.DockName = title ?? string.Empty;
            newBlank.FilePath = filePath;
            newBlank.BlankText = text ?? string.Empty;
            newBlank.MdiParent = this;
            return newBlank;
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
