namespace notepad
{
    partial class Blank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            richTextBox = new RichTextBox();
            contextMenuStrip = new ContextMenuStrip(components);
            CutToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem = new ToolStripMenuItem();
            PasteToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SelectAllToolStripMenuItem = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            statusStrip = new StatusStrip();
            toolStripStatusSymbolsPerMinuteLabel = new ToolStripStatusLabel();
            toolStripStatusLineLabel = new ToolStripStatusLabel();
            toolStripStatusColumnLabel = new ToolStripStatusLabel();
            contextMenuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.ContextMenuStrip = contextMenuStrip;
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Location = new Point(0, 0);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(800, 450);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            richTextBox.SelectionChanged += richTextBox_SelectionChanged;
            richTextBox.TextChanged += richTextBox_TextChanged;
            richTextBox.KeyPress += richTextBox_KeyPress;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, DeleteToolStripMenuItem, toolStripSeparator1, SelectAllToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(142, 120);
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            CutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            CutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            CutToolStripMenuItem.ShowShortcutKeys = false;
            CutToolStripMenuItem.Size = new Size(141, 22);
            CutToolStripMenuItem.Text = "Вырезать";
            CutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            CopyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            CopyToolStripMenuItem.ShowShortcutKeys = false;
            CopyToolStripMenuItem.Size = new Size(141, 22);
            CopyToolStripMenuItem.Text = "Скопировать";
            CopyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            PasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            PasteToolStripMenuItem.ShowShortcutKeys = false;
            PasteToolStripMenuItem.Size = new Size(141, 22);
            PasteToolStripMenuItem.Text = "Вставить";
            PasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            DeleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            DeleteToolStripMenuItem.ShowShortcutKeys = false;
            DeleteToolStripMenuItem.Size = new Size(141, 22);
            DeleteToolStripMenuItem.Text = "Удалить";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(138, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            SelectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            SelectAllToolStripMenuItem.ShowShortcutKeys = false;
            SelectAllToolStripMenuItem.Size = new Size(141, 22);
            SelectAllToolStripMenuItem.Text = "Выделить всё";
            SelectAllToolStripMenuItem.Click += SelectAllToolStripMenuItem_Click;
            // 
            // timer
            // 
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusSymbolsPerMinuteLabel, toolStripStatusLineLabel, toolStripStatusColumnLabel });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 1;
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
            // Blank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(richTextBox);
            Name = "Blank";
            Text = "Blank";
            WindowState = FormWindowState.Maximized;
            FormClosed += Blank_FormClosed;
            Load += Blank_Load;
            contextMenuStrip.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox;
        private System.Windows.Forms.Timer timer;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusSymbolsPerMinuteLabel;
        private ToolStripStatusLabel toolStripStatusLineLabel;
        private ToolStripStatusLabel toolStripStatusColumnLabel;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem CutToolStripMenuItem;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private ToolStripMenuItem PasteToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SelectAllToolStripMenuItem;
    }
}