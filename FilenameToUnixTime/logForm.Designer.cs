namespace FilenameToUnixTime
{
    partial class LogForm
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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.checkLog = new System.Windows.Forms.CheckBox();
            this.checkError = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(12, 35);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(461, 262);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // checkLog
            // 
            this.checkLog.AutoSize = true;
            this.checkLog.Checked = true;
            this.checkLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLog.Location = new System.Drawing.Point(12, 12);
            this.checkLog.Name = "checkLog";
            this.checkLog.Size = new System.Drawing.Size(44, 17);
            this.checkLog.TabIndex = 2;
            this.checkLog.Text = "Info";
            this.checkLog.UseVisualStyleBackColor = true;
            this.checkLog.CheckedChanged += new System.EventHandler(this.checkLog_CheckedChanged);
            // 
            // checkError
            // 
            this.checkError.AutoSize = true;
            this.checkError.Checked = true;
            this.checkError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkError.Location = new System.Drawing.Point(62, 12);
            this.checkError.Name = "checkError";
            this.checkError.Size = new System.Drawing.Size(48, 17);
            this.checkError.TabIndex = 1;
            this.checkError.Text = "Error";
            this.checkError.UseVisualStyleBackColor = true;
            this.checkError.CheckedChanged += new System.EventHandler(this.checkLog_CheckedChanged);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 309);
            this.Controls.Add(this.checkLog);
            this.Controls.Add(this.checkError);
            this.Controls.Add(this.textBox);
            this.Name = "LogForm";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.logForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkLog;
        private System.Windows.Forms.CheckBox checkError;
        public System.Windows.Forms.RichTextBox textBox;

    }
}