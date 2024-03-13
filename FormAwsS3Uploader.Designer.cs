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
            this.textBox_LinkImage.Location = new System.Drawing.Point(27, 312);
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
            // FormAwsUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 345);
            this.Controls.Add(this.button_UploadFile);
            this.Controls.Add(this.textBox_UrlFileUpload);
            this.Controls.Add(this.textBox_LinkImage);
            this.Controls.Add(this.button_Upload);
            this.Controls.Add(this.button_ChooseImage);
            this.Controls.Add(this.pictureBox_Image);
            this.Name = "FormAwsUploader";
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
    }
}

