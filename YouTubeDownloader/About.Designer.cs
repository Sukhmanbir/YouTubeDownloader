namespace YouTubeDownloader
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.okButton = new System.Windows.Forms.Button();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.descRichTextBox = new System.Windows.Forms.RichTextBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(233, 282);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(36, 37);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(75, 13);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product Name";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(36, 70);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version";
            // 
            // descRichTextBox
            // 
            this.descRichTextBox.Location = new System.Drawing.Point(39, 171);
            this.descRichTextBox.Name = "descRichTextBox";
            this.descRichTextBox.Size = new System.Drawing.Size(250, 86);
            this.descRichTextBox.TabIndex = 3;
            this.descRichTextBox.Text = "";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(36, 101);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(51, 13);
            this.copyrightLabel.TabIndex = 4;
            this.copyrightLabel.Text = "Copyright";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(36, 133);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(80, 13);
            this.companyNameLabel.TabIndex = 5;
            this.companyNameLabel.Text = "Company Label";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::YouTubeDownloader.Properties.Resources.splashscreen;
            this.pictureBox1.Image = global::YouTubeDownloader.Properties.Resources.splashscreen;
            this.pictureBox1.InitialImage = global::YouTubeDownloader.Properties.Resources.splashscreen;
            this.pictureBox1.Location = new System.Drawing.Point(295, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 317);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.descRichTextBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.RichTextBox descRichTextBox;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}