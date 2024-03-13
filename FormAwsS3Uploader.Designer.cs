namespace AwsS3Uploader
{
    partial class FormAwsS3Uploader
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
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.button_ChooseImage = new System.Windows.Forms.Button();
            this.button_Upload = new System.Windows.Forms.Button();
            this.textBox_LinkImage = new System.Windows.Forms.TextBox();
            this.textBox_UrlFileUpload = new System.Windows.Forms.TextBox();
            this.button_UploadFile = new System.Windows.Forms.Button();
            this.button_DownloadFiles = new System.Windows.Forms.Button();
            this.richTextBox_FileList = new System.Windows.Forms.RichTextBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_ProcessValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Image.Location = new System.Drawing.Point(27, 23);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(224, 177);
            this.pictureBox_Image.TabIndex = 2;
            this.pictureBox_Image.TabStop = false;
            // 
            // button_ChooseImage
            // 
            this.button_ChooseImage.Location = new System.Drawing.Point(27, 237);
            this.button_ChooseImage.Name = "button_ChooseImage";
            this.button_ChooseImage.Size = new System.Drawing.Size(75, 42);
            this.button_ChooseImage.TabIndex = 3;
            this.button_ChooseImage.Text = "Choose Image";
            this.button_ChooseImage.UseVisualStyleBackColor = true;
            this.button_ChooseImage.Click += new System.EventHandler(this.button_ChooseImage_Click);
            // 
            // button_Upload
            // 
            this.button_Upload.Location = new System.Drawing.Point(102, 237);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(75, 42);
            this.button_Upload.TabIndex = 4;
            this.button_Upload.Text = "Upload Image";
            this.button_Upload.UseVisualStyleBackColor = true;
            this.button_Upload.Click += new System.EventHandler(this.button_Upload_Click);
            // 
            // textBox_LinkImage
            // 
            this.textBox_LinkImage.Location = new System.Drawing.Point(27, 285);
            this.textBox_LinkImage.Name = "textBox_LinkImage";
            this.textBox_LinkImage.Size = new System.Drawing.Size(224, 20);
            this.textBox_LinkImage.TabIndex = 6;
            // 
            // textBox_UrlFileUpload
            // 
            this.textBox_UrlFileUpload.Location = new System.Drawing.Point(27, 211);
            this.textBox_UrlFileUpload.Name = "textBox_UrlFileUpload";
            this.textBox_UrlFileUpload.Size = new System.Drawing.Size(224, 20);
            this.textBox_UrlFileUpload.TabIndex = 7;
            // 
            // button_UploadFile
            // 
            this.button_UploadFile.Location = new System.Drawing.Point(176, 237);
            this.button_UploadFile.Name = "button_UploadFile";
            this.button_UploadFile.Size = new System.Drawing.Size(75, 42);
            this.button_UploadFile.TabIndex = 8;
            this.button_UploadFile.Text = "Upload File";
            this.button_UploadFile.UseVisualStyleBackColor = true;
            this.button_UploadFile.Click += new System.EventHandler(this.button_UploadFile_Click);
            // 
            // button_DownloadFiles
            // 
            this.button_DownloadFiles.Location = new System.Drawing.Point(27, 408);
            this.button_DownloadFiles.Name = "button_DownloadFiles";
            this.button_DownloadFiles.Size = new System.Drawing.Size(224, 32);
            this.button_DownloadFiles.TabIndex = 10;
            this.button_DownloadFiles.Text = "Download Files";
            this.button_DownloadFiles.UseVisualStyleBackColor = true;
            this.button_DownloadFiles.Click += new System.EventHandler(this.button_DownloadFiles_Click);
            // 
            // richTextBox_FileList
            // 
            this.richTextBox_FileList.Location = new System.Drawing.Point(279, 23);
            this.richTextBox_FileList.Name = "richTextBox_FileList";
            this.richTextBox_FileList.Size = new System.Drawing.Size(644, 357);
            this.richTextBox_FileList.TabIndex = 11;
            this.richTextBox_FileList.Text = "";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(27, 382);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(224, 20);
            this.textBox_Path.TabIndex = 12;
            this.textBox_Path.Text = "D:/";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(279, 416);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(644, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 13;
            // 
            // label_ProcessValue
            // 
            this.label_ProcessValue.Location = new System.Drawing.Point(279, 390);
            this.label_ProcessValue.Name = "label_ProcessValue";
            this.label_ProcessValue.Size = new System.Drawing.Size(644, 23);
            this.label_ProcessValue.TabIndex = 14;
            this.label_ProcessValue.Text = "0 / 0";
            this.label_ProcessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormAwsS3Uploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 459);
            this.Controls.Add(this.label_ProcessValue);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.richTextBox_FileList);
            this.Controls.Add(this.button_DownloadFiles);
            this.Controls.Add(this.button_UploadFile);
            this.Controls.Add(this.textBox_UrlFileUpload);
            this.Controls.Add(this.textBox_LinkImage);
            this.Controls.Add(this.button_Upload);
            this.Controls.Add(this.button_ChooseImage);
            this.Controls.Add(this.pictureBox_Image);
            this.Name = "FormAwsS3Uploader";
            this.Text = "AWS S3 Uploader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Button button_ChooseImage;
        private System.Windows.Forms.Button button_Upload;
        private System.Windows.Forms.TextBox textBox_LinkImage;
        private System.Windows.Forms.TextBox textBox_UrlFileUpload;
        private System.Windows.Forms.Button button_UploadFile;
        private System.Windows.Forms.Button button_DownloadFiles;
        private System.Windows.Forms.RichTextBox richTextBox_FileList;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_ProcessValue;
    }
}

