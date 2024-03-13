using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System.Configuration;

namespace AwsS3Uploader
{
    public partial class FormAwsS3Uploader : Form
    {
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.APSoutheast1;
        private static IAmazonS3 client;
        private string bucketName = "upload-gift";
        private string accessKey;
        private string secretKey;
        private string S3Storage = S3StorageClass.Standard;
        private string filePath;
        private string fileName;

        public FormAwsS3Uploader()
        {
            InitializeComponent();

            client = new AmazonS3Client(bucketRegion);

            accessKey = ConfigurationManager.AppSettings["AWS_ACCESS_KEY"];
            secretKey = ConfigurationManager.AppSettings["AWS_SECRET_KEY"];
        }

        private async void button_Upload_Click(object sender, EventArgs e)
        {
            var url = await UploadAwsS3();
            this.textBox_LinkImage.Text = url;

            MessageBox.Show("Upload Success");
        }

        private async Task<string> UploadAwsS3()
        {
            try
            {
                var fileTransferUtility = new TransferUtility(accessKey, secretKey, bucketRegion);
                var fileTransferUtilityRequest = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    FilePath = this.filePath,
                    StorageClass = S3Storage,
                    ContentType = "image/jpeg",
                    Key = $"avatars/{this.fileName}",
                    //CannedACL = S3CannedACL.PublicRead,
                };
                await fileTransferUtility.UploadAsync(fileTransferUtilityRequest);

                // Upload and get url of image
                var url = $"https://{bucketName}.s3-ap-southeast-1.amazonaws.com/avatars/{this.fileName}";
                return url;
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
                throw;
            }
            return null;
        }

        private async Task<string> GetPreSignedUrl(string bucketName, string objectKey)
        {
            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                Expires = DateTime.Now.AddMinutes(60)
            };
            var url = client.GetPreSignedURL(request);
            return url;
        }

        /// <summary>
        /// Upload image from url to S3
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<string> UploadAwsS3FromUrl()
        {
            this.filePath = textBox_UrlFileUpload.Text.Trim();
            this.fileName = Path.GetFileName(this.filePath);
            var keyName = $"avatars/{this.fileName}";

            try
            {
                var fileTransferUtility = new TransferUtility(accessKey, secretKey, bucketRegion);

                // Get the file from the URL
                var httpClient = new HttpClient();
                var fileStream = await httpClient.GetStreamAsync(filePath);

                // Upload the file
                var uploadRequest = new TransferUtilityUploadRequest
                {
                    InputStream = fileStream,
                    //FilePath = this.filePath,

                    BucketName = bucketName,
                    StorageClass = S3Storage,
                    ContentType = "image/jpeg",
                    Key = keyName,
                };

                await fileTransferUtility.UploadAsync(uploadRequest);
                Console.WriteLine("File uploaded successfully.");

                var url = $"https://{bucketName}.s3-ap-southeast-1.amazonaws.com/avatars/{this.fileName}";
                return url;
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
                throw;
            }
            return null;
        }

        private void button_ChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Image.BackgroundImage = new Bitmap(openFileDialog.FileName);
                this.filePath = openFileDialog.FileName;
                this.fileName = openFileDialog.SafeFileName;
            }
        }

        private async Task<Stream> GetFileFromUrl(string url)
        {
            var httpClient = new HttpClient();
            var fileStream = await httpClient.GetStreamAsync(url);
            return fileStream;
        }

        private async void button_UploadFile_Click(object sender, EventArgs e)
        {
            var url = await UploadAwsS3FromUrl();
            textBox_LinkImage.Text = url;
            MessageBox.Show("Upload Success");
        }

        private async void button_DownloadFiles_Click(object sender, EventArgs e)
        {
            List<string> listUrl = this.richTextBox_FileList.Lines.ToList();
            var folderPath = this.textBox_Path.Text.Trim();
            progressBar.Maximum = listUrl.Count;
            progressBar.Value = 0;

            Stream fileStream;
            // Download files from list url to local folder
            using (var httpClient = new HttpClient())
            {
                foreach (var url in listUrl)
                {
                    var fileName = Path.GetFileName(url);
                    var filePath = Path.Combine(folderPath, fileName);
                    fileStream = await httpClient.GetStreamAsync(url);
                    // Save file to local
                    using (var fileStreamLocal = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        fileStream.CopyTo(fileStreamLocal);
                        progressBar.Value++;
                        label_ProcessValue.Text = $"{progressBar.Value} / {progressBar.Maximum}";
                    }
                }
            }
           MessageBox.Show("Download Success");
        }
    }
}
