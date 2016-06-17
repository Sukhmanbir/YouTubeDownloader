namespace YouTubeDownloader
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splashscreenLabel = new System.Windows.Forms.Label();
            this.splashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.splashScreenPictureBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashscreenLabel
            // 
            this.splashscreenLabel.AutoSize = true;
            this.splashscreenLabel.Location = new System.Drawing.Point(216, 438);
            this.splashscreenLabel.Name = "splashscreenLabel";
            this.splashscreenLabel.Size = new System.Drawing.Size(192, 13);
            this.splashscreenLabel.TabIndex = 1;
            this.splashscreenLabel.Text = "Video Downloader by Sukhmanbir Kaur";
            // 
            // splashScreenTimer
            // 
            this.splashScreenTimer.Enabled = true;
            this.splashScreenTimer.Interval = 30;
            this.splashScreenTimer.Tick += new System.EventHandler(this.splashScreenTimer_Tick);
            // 
            // splashScreenPictureBox
            // 
            this.splashScreenPictureBox.ErrorImage = global::YouTubeDownloader.Properties.Resources.splashscreen;
            this.splashScreenPictureBox.Image = global::YouTubeDownloader.Properties.Resources.splashscreen;
            this.splashScreenPictureBox.InitialImage = global::YouTubeDownloader.Properties.Resources.splashscreen;
            this.splashScreenPictureBox.Location = new System.Drawing.Point(37, 12);
            this.splashScreenPictureBox.Name = "splashScreenPictureBox";
            this.splashScreenPictureBox.Size = new System.Drawing.Size(541, 352);
            this.splashScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashScreenPictureBox.TabIndex = 0;
            this.splashScreenPictureBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(141, 390);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 473);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splashscreenLabel);
            this.Controls.Add(this.splashScreenPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox splashScreenPictureBox;
        private System.Windows.Forms.Label splashscreenLabel;
        private System.Windows.Forms.Timer splashScreenTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}