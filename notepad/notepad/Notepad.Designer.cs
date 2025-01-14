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
            components = new System.ComponentModel.Container();
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
            timer = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusSymbolsPerMinuteLabel = new ToolStripStatusLabel();
            toolStripStatusLineLabel = new ToolStripStatusLabel();
            toolStripStatusColumnLabel = new ToolStripStatusLabel();
            Menu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainTextBox
            // 
            MainTextBox.Dock = DockStyle.Fill;
            MainTextBox.Location = new Point(0, 24);
            MainTextBox.Multiline = true;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(1434, 610);
            MainTextBox.TabIndex = 0;
            MainTextBox.TextChanged += MainTextBox_TextChanged;
            MainTextBox.KeyPress += MainTextBox_KeyPress;
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
            FontViwe.Click += FontView_Click;
            // 
            // BackgroundColorViwe
            // 
            BackgroundColorViwe.Name = "BackgroundColorViwe";
            BackgroundColorViwe.Size = new Size(129, 22);
            BackgroundColorViwe.Text = "ЦветФона";
            BackgroundColorViwe.Click += BackgroundColorView_Click;
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
            // timer
            // 
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusSymbolsPerMinuteLabel, toolStripStatusLineLabel, toolStripStatusColumnLabel });
            statusStrip1.Location = new Point(0, 612);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1434, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusSymbolsPerMinuteLabel
            // 
            toolStripStatusSymbolsPerMinuteLabel.Name = "toolStripStatusSymbolsPerMinuteLabel";
            toolStripStatusSymbolsPerMinuteLabel.Size = new Size(131, 17);
            toolStripStatusSymbolsPerMinuteLabel.Text = "Символов в минуту: 0;";
            // 
            // toolStripStatusLineLabel
            // 
            toolStripStatusLineLabel.Name = "toolStripStatusLineLabel";
            toolStripStatusLineLabel.Size = new Size(58, 17);
            toolStripStatusLineLabel.Text = "Строка 1;";
            // 
            // toolStripStatusColumnLabel
            // 
            toolStripStatusColumnLabel.Name = "toolStripStatusColumnLabel";
            toolStripStatusColumnLabel.Size = new Size(66, 17);
            toolStripStatusColumnLabel.Text = "Столбец 1;";
            // 
            // NotepadWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 634);
            Controls.Add(statusStrip1);
            Controls.Add(MainTextBox);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            MinimumSize = new Size(300, 400);
            Name = "NotepadWindow";
            Text = "Notepad new text";
            FormClosing += NotepadForm_FormClosing;
            Load += NotepadWindow_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Timer timer;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusSymbolsPerMinuteLabel;
        private ToolStripStatusLabel toolStripStatusLineLabel;
        private ToolStripStatusLabel toolStripStatusColumnLabel;
    }
}
