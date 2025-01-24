namespace notepad
{
    partial class FindForm
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
            btnOK = new Button();
            btnCancel = new Button();
            cbMatchCase = new CheckBox();
            cbMatchWhole = new CheckBox();
            txtFind = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(26, 100);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(193, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbMatchCase
            // 
            cbMatchCase.AutoSize = true;
            cbMatchCase.Location = new Point(26, 11);
            cbMatchCase.Name = "cbMatchCase";
            cbMatchCase.Size = new Size(130, 19);
            cbMatchCase.TabIndex = 2;
            cbMatchCase.Text = "Учитывать &Регистр";
            cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // cbMatchWhole
            // 
            cbMatchWhole.AutoSize = true;
            cbMatchWhole.Location = new Point(26, 36);
            cbMatchWhole.Name = "cbMatchWhole";
            cbMatchWhole.Size = new Size(158, 19);
            cbMatchWhole.TabIndex = 3;
            cbMatchWhole.Text = "Учитывать &Целое слово";
            cbMatchWhole.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(26, 61);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(192, 23);
            txtFind.TabIndex = 4;
            // 
            // FindForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 135);
            Controls.Add(txtFind);
            Controls.Add(cbMatchWhole);
            Controls.Add(cbMatchCase);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(328, 112);
            Name = "FindForm";
            Text = "Find";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private CheckBox cbMatchCase;
        private CheckBox cbMatchWhole;
        private TextBox txtFind;
    }
}