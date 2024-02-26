namespace notepad
{
    partial class NotepadWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTextBox = new TextBox();
            Menu = new MenuStrip();
            File = new ToolStripMenuItem();
            OpenFile = new ToolStripMenuItem();
            SafeFile = new ToolStripMenuItem();
            SafeAsFile = new ToolStripMenuItem();
            Viwe = new ToolStripMenuItem();
            FontViwe = new ToolStripMenuItem();
            BackgroundColorViwe = new ToolStripMenuItem();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            SaveFileDialog = new SaveFileDialog();
            OpenFileDialog = new OpenFileDialog();
            panel1 = new Panel();
            ColumnLable = new Label();
            LineLable = new Label();
            Menu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainTextBox
            // 
            MainTextBox.Dock = DockStyle.Top;
            MainTextBox.Location = new Point(0, 24);
            MainTextBox.Multiline = true;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(1434, 575);
            MainTextBox.TabIndex = 0;
            MainTextBox.TextChanged += MainTextBox_TextChanged;
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { File, Viwe });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1434, 24);
            Menu.TabIndex = 1;
            Menu.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { OpenFile, SafeFile, SafeAsFile });
            File.Name = "File";
            File.Size = new Size(48, 20);
            File.Text = "Файл";
            // 
            // OpenFile
            // 
            OpenFile.Name = "OpenFile";
            OpenFile.ShortcutKeys = Keys.Control | Keys.O;
            OpenFile.Size = new Size(235, 22);
            OpenFile.Text = "Открыть...";
            OpenFile.Click += OpenFile_Click;
            // 
            // SafeFile
            // 
            SafeFile.Name = "SafeFile";
            SafeFile.ShortcutKeys = Keys.Control | Keys.S;
            SafeFile.Size = new Size(235, 22);
            SafeFile.Text = "Сохранить";
            SafeFile.Click += SafeFile_Click;
            // 
            // SafeAsFile
            // 
            SafeAsFile.Name = "SafeAsFile";
            SafeAsFile.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            SafeAsFile.Size = new Size(235, 22);
            SafeAsFile.Text = "Сохранить как...";
            SafeAsFile.Click += SafeAsFile_Click;
            // 
            // Viwe
            // 
            Viwe.DropDownItems.AddRange(new ToolStripItem[] { FontViwe, BackgroundColorViwe });
            Viwe.Name = "Viwe";
            Viwe.Size = new Size(39, 20);
            Viwe.Text = "Вид";
            // 
            // FontViwe
            // 
            FontViwe.Name = "FontViwe";
            FontViwe.Size = new Size(129, 22);
            FontViwe.Text = "Шрифт";
            FontViwe.Click += FontViwe_Click;
            // 
            // BackgroundColorViwe
            // 
            BackgroundColorViwe.Name = "BackgroundColorViwe";
            BackgroundColorViwe.Size = new Size(129, 22);
            BackgroundColorViwe.Text = "ЦветФона";
            BackgroundColorViwe.Click += BackgroundColorViwe_Click;
            // 
            // SaveFileDialog
            // 
            SaveFileDialog.DefaultExt = "txt";
            SaveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            SaveFileDialog.InitialDirectory = "Рабочий стол";
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.DefaultExt = "txt";
            OpenFileDialog.DereferenceLinks = false;
            OpenFileDialog.FileName = "openFileDialog";
            OpenFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            OpenFileDialog.InitialDirectory = "Рабочий стол";
            // 
            // panel1
            // 
            panel1.Controls.Add(ColumnLable);
            panel1.Controls.Add(LineLable);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 598);
            panel1.Name = "panel1";
            panel1.Size = new Size(1434, 36);
            panel1.TabIndex = 2;
            // 
            // ColumnLable
            // 
            ColumnLable.AutoSize = true;
            ColumnLable.Location = new Point(108, 4);
            ColumnLable.Name = "ColumnLable";
            ColumnLable.Size = new Size(63, 15);
            ColumnLable.TabIndex = 3;
            ColumnLable.Text = "Столбец 1";
            // 
            // LineLable
            // 
            LineLable.AutoSize = true;
            LineLable.Location = new Point(49, 4);
            LineLable.Name = "LineLable";
            LineLable.Size = new Size(55, 15);
            LineLable.TabIndex = 1;
            LineLable.Text = "Строка 1";
            // 
            // NotepadWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 634);
            Controls.Add(panel1);
            Controls.Add(MainTextBox);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "NotepadWindow";
            Text = "Notepad new text";
            FormClosing += NotepadForm_FormClosing;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MainTextBox;
        private MenuStrip Menu;
        private ToolStripMenuItem File;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem SafeFile;
        private ToolStripMenuItem SafeAsFile;
        private ToolStripMenuItem Viwe;
        private ToolStripMenuItem FontViwe;
        private ToolStripMenuItem BackgroundColorViwe;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private SaveFileDialog SaveFileDialog;
        private OpenFileDialog OpenFileDialog;
        private Panel panel1;
        private Label LineLable;
        private Label ColumnLable;
    }
}
