﻿namespace notepad
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadWindow));
            Menu = new MenuStrip();
            File = new ToolStripMenuItem();
            OpenFile = new ToolStripMenuItem();
            SafeFile = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            CutToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem = new ToolStripMenuItem();
            PasteToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SelectAllToolStripMenuItem = new ToolStripMenuItem();
            Viwe = new ToolStripMenuItem();
            FontViwe = new ToolStripMenuItem();
            BackgroundColorViwe = new ToolStripMenuItem();
            WindowToolStripMenuItem = new ToolStripMenuItem();
            ArrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            CascadeToolStripMenuItem = new ToolStripMenuItem();
            TileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            TileVerticalToolStripMenuItem = new ToolStripMenuItem();
            QuestionToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            SaveFileDialog = new SaveFileDialog();
            OpenFileDialog = new OpenFileDialog();
            statusStrip = new StatusStrip();
            toolStripStatusSymbolsPerMinuteLabel = new ToolStripStatusLabel();
            toolStripStatusLineLabel = new ToolStripStatusLabel();
            toolStripStatusColumnLabel = new ToolStripStatusLabel();
            Menu.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { File, EditToolStripMenuItem, Viwe, WindowToolStripMenuItem, QuestionToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(787, 24);
            Menu.TabIndex = 1;
            Menu.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { OpenFile, SafeFile, NewToolStripMenuItem, toolStripSeparator2, ExitToolStripMenuItem });
            File.Name = "File";
            File.Size = new Size(48, 20);
            File.Text = "&Файл";
            // 
            // OpenFile
            // 
            OpenFile.Name = "OpenFile";
            OpenFile.ShortcutKeys = Keys.Control | Keys.O;
            OpenFile.Size = new Size(208, 22);
            OpenFile.Text = "Открыть...";
            OpenFile.Click += OpenFile_Click;
            // 
            // SafeFile
            // 
            SafeFile.Name = "SafeFile";
            SafeFile.ShortcutKeys = Keys.Control | Keys.S;
            SafeFile.Size = new Size(208, 22);
            SafeFile.Text = "Сохранить";
            SafeFile.Click += SaveFile_Click;
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            NewToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            NewToolStripMenuItem.Size = new Size(208, 22);
            NewToolStripMenuItem.Text = "Создать новый...";
            NewToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(205, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            ExitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            ExitToolStripMenuItem.Size = new Size(208, 22);
            ExitToolStripMenuItem.Text = "Выйти";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, DeleteToolStripMenuItem, toolStripSeparator1, SelectAllToolStripMenuItem });
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(73, 20);
            EditToolStripMenuItem.Text = "Изменить";
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            CutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            CutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            CutToolStripMenuItem.Size = new Size(190, 22);
            CutToolStripMenuItem.Text = "Вырезать";
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            CopyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            CopyToolStripMenuItem.Size = new Size(190, 22);
            CopyToolStripMenuItem.Text = "Скопировать";
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            PasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            PasteToolStripMenuItem.Size = new Size(190, 22);
            PasteToolStripMenuItem.Text = "Вставить";
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            DeleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            DeleteToolStripMenuItem.Size = new Size(190, 22);
            DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            SelectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            SelectAllToolStripMenuItem.Size = new Size(190, 22);
            SelectAllToolStripMenuItem.Text = "Выделить всё";
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
            // WindowToolStripMenuItem
            // 
            WindowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ArrangeIconsToolStripMenuItem, CascadeToolStripMenuItem, TileHorizontalToolStripMenuItem, TileVerticalToolStripMenuItem });
            WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            WindowToolStripMenuItem.Size = new Size(48, 20);
            WindowToolStripMenuItem.Text = "Окно";
            // 
            // ArrangeIconsToolStripMenuItem
            // 
            ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem";
            ArrangeIconsToolStripMenuItem.Size = new Size(214, 22);
            ArrangeIconsToolStripMenuItem.Text = "Упорядочивание значков";
            ArrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // CascadeToolStripMenuItem
            // 
            CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            CascadeToolStripMenuItem.Size = new Size(214, 22);
            CascadeToolStripMenuItem.Text = "Каскад";
            CascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // TileHorizontalToolStripMenuItem
            // 
            TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem";
            TileHorizontalToolStripMenuItem.Size = new Size(214, 22);
            TileHorizontalToolStripMenuItem.Text = "Горизонтальная плитка";
            TileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // TileVerticalToolStripMenuItem
            // 
            TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem";
            TileVerticalToolStripMenuItem.Size = new Size(214, 22);
            TileVerticalToolStripMenuItem.Text = "Вертикальная плитка";
            TileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // QuestionToolStripMenuItem
            // 
            QuestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem });
            QuestionToolStripMenuItem.Name = "QuestionToolStripMenuItem";
            QuestionToolStripMenuItem.Size = new Size(24, 20);
            QuestionToolStripMenuItem.Text = "?";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(158, 22);
            AboutToolStripMenuItem.Text = "О программе...";
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
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusSymbolsPerMinuteLabel, toolStripStatusLineLabel, toolStripStatusColumnLabel });
            statusStrip.Location = new Point(0, 503);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(787, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
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
            ClientSize = new Size(787, 525);
            Controls.Add(statusStrip);
            Controls.Add(Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = Menu;
            MinimumSize = new Size(300, 400);
            Name = "NotepadWindow";
            Text = "Notepad";
            FormClosing += NotepadForm_FormClosingAsync;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip Menu;
        private ToolStripMenuItem File;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem SafeFile;
        private ToolStripMenuItem Viwe;
        private ToolStripMenuItem FontViwe;
        private ToolStripMenuItem BackgroundColorViwe;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private SaveFileDialog SaveFileDialog;
        private OpenFileDialog OpenFileDialog;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusSymbolsPerMinuteLabel;
        private ToolStripStatusLabel toolStripStatusLineLabel;
        private ToolStripStatusLabel toolStripStatusColumnLabel;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem CutToolStripMenuItem;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private ToolStripMenuItem PasteToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SelectAllToolStripMenuItem;
        private ToolStripMenuItem WindowToolStripMenuItem;
        private ToolStripMenuItem ArrangeIconsToolStripMenuItem;
        private ToolStripMenuItem CascadeToolStripMenuItem;
        private ToolStripMenuItem TileHorizontalToolStripMenuItem;
        private ToolStripMenuItem TileVerticalToolStripMenuItem;
        private ToolStripMenuItem QuestionToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
    }
}
