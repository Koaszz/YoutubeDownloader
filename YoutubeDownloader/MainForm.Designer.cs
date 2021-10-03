namespace YoutubeDownloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.videoUrlInput = new System.Windows.Forms.TextBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoSeachButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoThumbnailImage = new System.Windows.Forms.PictureBox();
            this.videoTitleLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.resolutionDropdown = new System.Windows.Forms.ComboBox();
            this.downloadProgressbar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbnailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // videoUrlInput
            // 
            this.videoUrlInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoUrlInput.Location = new System.Drawing.Point(13, 37);
            this.videoUrlInput.Name = "videoUrlInput";
            this.videoUrlInput.PlaceholderText = "Enter video link";
            this.videoUrlInput.Size = new System.Drawing.Size(450, 29);
            this.videoUrlInput.TabIndex = 1;
            this.videoUrlInput.TextChanged += new System.EventHandler(this.videoUrlInput_TextChanged);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directoryLabel.Location = new System.Drawing.Point(231, 163);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(65, 19);
            this.directoryLabel.TabIndex = 2;
            this.directoryLabel.Text = "Directory";
            // 
            // directoryInput
            // 
            this.directoryInput.Enabled = false;
            this.directoryInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directoryInput.Location = new System.Drawing.Point(233, 186);
            this.directoryInput.Name = "directoryInput";
            this.directoryInput.ReadOnly = true;
            this.directoryInput.Size = new System.Drawing.Size(362, 27);
            this.directoryInput.TabIndex = 3;
            this.directoryInput.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downloadButton.Location = new System.Drawing.Point(406, 221);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(291, 29);
            this.downloadButton.TabIndex = 5;
            this.downloadButton.Text = "Download Video";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.videoSeachButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.videoUrlInput);
            this.panel1.Location = new System.Drawing.Point(221, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 109);
            this.panel1.TabIndex = 9;
            // 
            // videoSeachButton
            // 
            this.videoSeachButton.Location = new System.Drawing.Point(13, 72);
            this.videoSeachButton.Name = "videoSeachButton";
            this.videoSeachButton.Size = new System.Drawing.Size(152, 29);
            this.videoSeachButton.TabIndex = 2;
            this.videoSeachButton.Text = "Find video";
            this.videoSeachButton.UseVisualStyleBackColor = true;
            this.videoSeachButton.Click += new System.EventHandler(this.videoSeachButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube Video URL:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // videoThumbnailImage
            // 
            this.videoThumbnailImage.Location = new System.Drawing.Point(12, 134);
            this.videoThumbnailImage.Name = "videoThumbnailImage";
            this.videoThumbnailImage.Size = new System.Drawing.Size(203, 114);
            this.videoThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoThumbnailImage.TabIndex = 11;
            this.videoThumbnailImage.TabStop = false;
            // 
            // videoTitleLabel
            // 
            this.videoTitleLabel.AutoSize = true;
            this.videoTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoTitleLabel.Location = new System.Drawing.Point(230, 134);
            this.videoTitleLabel.Name = "videoTitleLabel";
            this.videoTitleLabel.Size = new System.Drawing.Size(98, 25);
            this.videoTitleLabel.TabIndex = 12;
            this.videoTitleLabel.Text = "Video title";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseButton.Location = new System.Drawing.Point(602, 185);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(95, 29);
            this.browseButton.TabIndex = 13;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // resolutionDropdown
            // 
            this.resolutionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionDropdown.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resolutionDropdown.FormattingEnabled = true;
            this.resolutionDropdown.Location = new System.Drawing.Point(234, 223);
            this.resolutionDropdown.Name = "resolutionDropdown";
            this.resolutionDropdown.Size = new System.Drawing.Size(152, 25);
            this.resolutionDropdown.TabIndex = 14;
            this.resolutionDropdown.SelectedIndexChanged += new System.EventHandler(this.resolutionDropdown_SelectedIndexChanged);
            // 
            // downloadProgressbar
            // 
            this.downloadProgressbar.Location = new System.Drawing.Point(12, 256);
            this.downloadProgressbar.Name = "downloadProgressbar";
            this.downloadProgressbar.Size = new System.Drawing.Size(685, 19);
            this.downloadProgressbar.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 280);
            this.Controls.Add(this.downloadProgressbar);
            this.Controls.Add(this.resolutionDropdown);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.videoTitleLabel);
            this.Controls.Add(this.videoThumbnailImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.directoryInput);
            this.Controls.Add(this.directoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Youtube Video Downloader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbnailImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox videoUrlInput;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox directoryInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button videoSeachButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox videoThumbnailImage;
        private System.Windows.Forms.Label videoTitleLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ComboBox resolutionDropdown;
        private System.Windows.Forms.StatusStrip loadingBarStrip;
        private System.Windows.Forms.ProgressBar downloadProgressbar;
    }
}

