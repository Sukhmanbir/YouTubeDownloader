namespace YouTubeDownloader
{
    partial class videoDownloaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(videoDownloaderForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlLabel = new System.Windows.Forms.Label();
            this.videoQualityLabel = new System.Windows.Forms.Label();
            this.saveLocationLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.saveLocationTextBox = new System.Windows.Forms.TextBox();
            this.getVideosButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.videoQualityComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(46, 56);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(79, 13);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "YouTube URL:";
            // 
            // videoQualityLabel
            // 
            this.videoQualityLabel.AutoSize = true;
            this.videoQualityLabel.Location = new System.Drawing.Point(46, 174);
            this.videoQualityLabel.Name = "videoQualityLabel";
            this.videoQualityLabel.Size = new System.Drawing.Size(72, 13);
            this.videoQualityLabel.TabIndex = 2;
            this.videoQualityLabel.Text = "Video Quality:";
            // 
            // saveLocationLabel
            // 
            this.saveLocationLabel.AutoSize = true;
            this.saveLocationLabel.Location = new System.Drawing.Point(46, 305);
            this.saveLocationLabel.Name = "saveLocationLabel";
            this.saveLocationLabel.Size = new System.Drawing.Size(79, 13);
            this.saveLocationLabel.TabIndex = 3;
            this.saveLocationLabel.Text = "Save Location:";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(49, 82);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(445, 20);
            this.urlTextBox.TabIndex = 0;
            // 
            // saveLocationTextBox
            // 
            this.saveLocationTextBox.Location = new System.Drawing.Point(49, 333);
            this.saveLocationTextBox.Name = "saveLocationTextBox";
            this.saveLocationTextBox.Size = new System.Drawing.Size(445, 20);
            this.saveLocationTextBox.TabIndex = 3;
            // 
            // getVideosButton
            // 
            this.getVideosButton.Location = new System.Drawing.Point(515, 80);
            this.getVideosButton.Name = "getVideosButton";
            this.getVideosButton.Size = new System.Drawing.Size(89, 23);
            this.getVideosButton.TabIndex = 1;
            this.getVideosButton.Text = "&Get Videos";
            this.getVideosButton.UseVisualStyleBackColor = true;
            this.getVideosButton.Click += new System.EventHandler(this.getVideosButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(515, 330);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(89, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(49, 403);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(113, 23);
            this.downloadButton.TabIndex = 5;
            this.downloadButton.Text = "&Download Now";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // videoQualityComboBox
            // 
            this.videoQualityComboBox.FormattingEnabled = true;
            this.videoQualityComboBox.Location = new System.Drawing.Point(49, 207);
            this.videoQualityComboBox.Name = "videoQualityComboBox";
            this.videoQualityComboBox.Size = new System.Drawing.Size(445, 21);
            this.videoQualityComboBox.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(189, 403);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // videoDownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 473);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.videoQualityComboBox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.getVideosButton);
            this.Controls.Add(this.saveLocationTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.saveLocationLabel);
            this.Controls.Add(this.videoQualityLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "videoDownloaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Downloader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label videoQualityLabel;
        private System.Windows.Forms.Label saveLocationLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox saveLocationTextBox;
        private System.Windows.Forms.Button getVideosButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ComboBox videoQualityComboBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

