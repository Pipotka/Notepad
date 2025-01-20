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
            saveFileDialog = new SaveFileDialog();
            timer = new System.Windows.Forms.Timer(components);
            statusStrip = new StatusStrip();
            toolStripStatusSymbolsPerMinuteLabel = new ToolStripStatusLabel();
            toolStripStatusLineLabel = new ToolStripStatusLabel();
            toolStripStatusColumnLabel = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.BorderStyle = BorderStyle.None;
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
            FormClosing += Blank_FormClosing;
            FormClosed += Blank_FormClosed;
            Load += Blank_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox;
        private SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer timer;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusSymbolsPerMinuteLabel;
        private ToolStripStatusLabel toolStripStatusLineLabel;
        private ToolStripStatusLabel toolStripStatusColumnLabel;
    }
}