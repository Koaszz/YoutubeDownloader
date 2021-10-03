using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using VideoLibrary;

// https://www.youtube.com/watch?v=AGnMNor_r-Y

// video
// get video data
// convert video to byte array
// save to mp4


namespace YoutubeDownloader
{
    public partial class MainForm : Form
    {
        public string FilePath = "";
        public string VideoURL = "";
        public string Resolution = "";
        public MainForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(730, 175);
            directoryLabel.Visible = false;
            directoryInput.Visible = false;
            downloadButton.Visible = false;
            videoSeachButton.Enabled = false;
            downloadButton.Enabled = false;

        }

        async Task SaveVideoToDisk(string link, string path, string Resolution)
        {
            var youtube = YouTube.Default;
            var client = new HttpClient();
            var video = await youtube.GetVideoAsync(link);
            var videoData = await youtube.GetAllVideosAsync(link);
            var resolutions = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Video && r.Format == VideoFormat.Mp4).Select(r => r.Resolution).Distinct();
            var videoToDownlaod = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Video && r.Format == VideoFormat.Mp4 && r.Resolution.ToString() == Resolution.ToString()).First();

            long? totalByte = 0;
            using (Stream output = File.OpenWrite(FilePath + "\\" + video.FullName))
            {
                using (var request = new HttpRequestMessage(HttpMethod.Head, videoToDownlaod.Uri))
                {
                    totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
                }
                using (var input = await client.GetStreamAsync(videoToDownlaod.Uri))
                {
                    downloadButton.Text = "Downloading...";
                    byte[] buffer = new byte[16 * 1024];
                    int read;
                    int totalRead = 0;
                    while ((read = await input.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await output.WriteAsync(buffer, 0, read);
                        totalRead += read;
                        downloadProgressbar.Value = (int)((totalRead / totalByte) * 100);
                    }

                    MessageBox.Show($"Successfuly downloaded {video.FullName} to \"{FilePath}\"", "Youtube downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm NewForm = new MainForm();
                    NewForm.Show();
                    this.Dispose(false);

                }
            }
        }

        private async void videoSeachButton_Click(object sender, EventArgs e)
        {
            videoSeachButton.Enabled = false;
            this.Size = new System.Drawing.Size(730, 175);
            Resolution = "";
            FilePath = "";
            directoryInput.Text = "";
            resolutionDropdown.Items.Clear();

            var videoURI = videoUrlInput.Text;
            var youtube = YouTube.Default;
            try
            {
                var video = youtube.GetVideo(videoURI);
                var videoId = HttpUtility.ParseQueryString(new Uri(videoURI).Query)["v"];
                var thumbnailURL = $"http://i.ytimg.com/vi/{videoId}/mqdefault.jpg";
                var videoInfo = await Client.For(YouTube.Default).GetAllVideosAsync(videoURI);
                var resolutions = videoInfo.Where(r => r.AdaptiveKind == AdaptiveKind.Video && r.Format == VideoFormat.Mp4 && r.AudioFormat.ToString() == AudioFormat.Aac.ToString()).Select(r => r.Resolution).Distinct().OrderBy(x => x);

                videoSeachButton.Enabled = true;
                VideoURL = videoURI;

                this.Size = new System.Drawing.Size(730, 320);
                directoryLabel.Visible = true;
                directoryInput.Visible = true;
                downloadButton.Visible = true;
                videoTitleLabel.Text = video.Title;

                foreach (var item in resolutions)
                {
                    resolutionDropdown.Items.Add(item + "p");
                }

                resolutionDropdown.SelectedItem = resolutions.Max(x => x) + "p";

                var request = WebRequest.Create(thumbnailURL);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    videoThumbnailImage.Image = Bitmap.FromStream(stream);
                }
                
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Youtube video not found", "Youtube Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = folderBrowserDialog.SelectedPath + "\\";
                directoryInput.Text = FilePath;
                downloadButton.Enabled = true;
            }
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            videoSeachButton.Enabled = false;
            videoUrlInput.Enabled = false;
            downloadButton.Enabled = false;
            resolutionDropdown.Enabled = false;
            browseButton.Enabled = false;
            downloadButton.Text = "Loading...";

            await SaveVideoToDisk(VideoURL, FilePath, Resolution);
        }

        private void resolutionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolution = resolutionDropdown.SelectedItem.ToString().Split("p")[0];
        }

        private void videoUrlInput_TextChanged(object sender, EventArgs e)
        {
            if (videoUrlInput.Text != "")
            {
                if (Regex.IsMatch(videoUrlInput.Text, @"https?:\/\/"))
                {
                    videoSeachButton.Enabled = true;
                } else
                {
                    videoSeachButton.Enabled = false;
                }
            } else
            {
                videoSeachButton.Enabled = false;   
            }
        }
    }
}

