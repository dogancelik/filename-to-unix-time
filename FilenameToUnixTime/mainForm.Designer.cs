namespace FilenameToUnixTime
{
    partial class MainForm
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
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonFiles = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(103, 12);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(85, 30);
            this.buttonFolder.TabIndex = 1;
            this.buttonFolder.Text = "Add Folder...";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.Location = new System.Drawing.Point(637, 12);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(85, 30);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.Location = new System.Drawing.Point(12, 48);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(710, 362);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preview";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // fileDialog
            // 
            this.fileDialog.Multiselect = true;
            // 
            // buttonFiles
            // 
            this.buttonFiles.Location = new System.Drawing.Point(12, 12);
            this.buttonFiles.Name = "buttonFiles";
            this.buttonFiles.Size = new System.Drawing.Size(85, 30);
            this.buttonFiles.TabIndex = 0;
            this.buttonFiles.Text = "Add Files...";
            this.buttonFiles.UseVisualStyleBackColor = true;
            this.buttonFiles.Click += new System.EventHandler(this.buttonFiles_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(194, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 30);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLog.Location = new System.Drawing.Point(455, 12);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(85, 30);
            this.buttonLog.TabIndex = 7;
            this.buttonLog.Text = "View Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonRevert
            // 
            this.buttonRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRevert.Enabled = false;
            this.buttonRevert.Location = new System.Drawing.Point(546, 12);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(85, 30);
            this.buttonRevert.TabIndex = 8;
            this.buttonRevert.Text = "Revert";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.Location = new System.Drawing.Point(364, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(85, 30);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 422);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonRevert);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonFiles);
            this.Controls.Add(this.buttonFolder);
            this.MinimumSize = new System.Drawing.Size(750, 38);
            this.Name = "MainForm";
            this.Text = "Filename to Unix Time";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainForm_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button buttonFiles;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.Button buttonAbout;
    }
}

