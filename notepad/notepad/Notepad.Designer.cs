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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadWindow));
            Menu = new MenuStrip();
            File = new ToolStripMenuItem();
            OpenFile = new ToolStripMenuItem();
            SaveFile = new ToolStripMenuItem();
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
            findToolStripMenuItem = new ToolStripMenuItem();
            QuestionToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            SaveFileDialog = new SaveFileDialog();
            OpenFileDialog = new OpenFileDialog();
            toolStrip = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            Menu.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { File, EditToolStripMenuItem, Viwe, WindowToolStripMenuItem, findToolStripMenuItem, QuestionToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(787, 24);
            Menu.TabIndex = 1;
            Menu.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { OpenFile, SaveFile, NewToolStripMenuItem, toolStripSeparator2, ExitToolStripMenuItem });
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
            // SaveFile
            // 
            SaveFile.Name = "SaveFile";
            SaveFile.ShortcutKeys = Keys.Control | Keys.S;
            SaveFile.Size = new Size(208, 22);
            SaveFile.Text = "Сохранить";
            SaveFile.Click += SaveFile_Click;
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
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
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
            CutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            CopyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            CopyToolStripMenuItem.Size = new Size(190, 22);
            CopyToolStripMenuItem.Text = "Скопировать";
            CopyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            PasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            PasteToolStripMenuItem.Size = new Size(190, 22);
            PasteToolStripMenuItem.Text = "Вставить";
            PasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            DeleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            DeleteToolStripMenuItem.Size = new Size(190, 22);
            DeleteToolStripMenuItem.Text = "Удалить";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
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
            SelectAllToolStripMenuItem.Click += SelectAllToolStripMenuItem_Click;
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
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findToolStripMenuItem.ShowShortcutKeys = false;
            findToolStripMenuItem.Size = new Size(53, 20);
            findToolStripMenuItem.Text = "&Найти";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
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
            AboutToolStripMenuItem.Size = new Size(180, 22);
            AboutToolStripMenuItem.Text = "О программе...";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
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
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, cutToolStripButton, copyToolStripButton, pasteToolStripButton });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(787, 25);
            toolStrip.TabIndex = 3;
            toolStrip.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "toolStripButton2";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "toolStripButton3";
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = (Image)resources.GetObject("cutToolStripButton.Image");
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(23, 22);
            cutToolStripButton.Text = "toolStripButton4";
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(23, 22);
            copyToolStripButton.Text = "toolStripButton5";
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = (Image)resources.GetObject("pasteToolStripButton.Image");
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(23, 22);
            pasteToolStripButton.Text = "toolStripButton6";
            // 
            // NotepadWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 525);
            Controls.Add(toolStrip);
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
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip Menu;
        private ToolStripMenuItem File;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem SaveFile;
        private ToolStripMenuItem Viwe;
        private ToolStripMenuItem FontViwe;
        private ToolStripMenuItem BackgroundColorViwe;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private SaveFileDialog SaveFileDialog;
        private OpenFileDialog OpenFileDialog;
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
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
    }
}
