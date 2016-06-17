// Project:		    YouTubeDownloader
// Date:		    April 6, 2016
// Assignment No.:	3
// Description:	    This project takes input of youtube video url, asks user to select from available formats
//                  and selects save location and downloads it.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

using YoutubeExtractor;//to use YouTubeExtractor library of functions

namespace YouTubeDownloader
{
    public partial class videoDownloaderForm : Form
    {
        //create an array
        VideoInfo[] videoInfos;

        //variable for url
        string youTubeURLString;

        public videoDownloaderForm()
        {
            //create new thread to display splashScreen form
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);
              
            InitializeComponent();

            //abort the splashScreen
            t.Abort();
        }

        public void splashStart()
        {
            //start splashScreen
            Application.Run(new SplashScreen());
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            try {
                //check if user has given input the required information
                if (urlTextBox.Text != null && videoQualityComboBox.Text != null && saveLocationTextBox.Text != null) { 
            // Get YouTube URL link from url textbox
            youTubeURLString = urlTextBox.Text;

            // Get all the available video formats and put them in an array
            videoInfos = DownloadUrlResolver.GetDownloadUrls(youTubeURLString).ToArray();

            //the selected format is kept track of using index of item from dropdown
            VideoInfo video = videoInfos[videoQualityComboBox.SelectedIndex];

            // Decipher the video if it has a decrypted signature
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);


            // Initiate a new VideoDownloader object, passing the VideoInfo object and save path
            var videoDownloader = new VideoDownloader(video, saveLocationTextBox.Text + video.Title + "-" +
            video.Resolution + video.VideoExtension);


            // Execute the video downloader
            videoDownloader.Execute();

                    //download successful message
                    MessageBox.Show("Video has been successfully downloaded! :)", "Download Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //if the input is invalid
                    MessageBox.Show("Please verify if you have entered the URL or selected the format or location correctly!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //if the input is invalid
                MessageBox.Show("You have entered invalid values!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /*
            WebClient client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri(urlTextBox.Text), @saveLocationTextBox.Text);
            */

        }

        /*
        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed!");
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)(e.TotalBytesToReceive / 100);
            progressBar1.Value = (int)(e.BytesReceived / 100);
        }
        */

        private void getVideosButton_Click(object sender, EventArgs e)
        {
            try { 
                //check if user had input the url
                if(urlTextBox.Text != null) { 
            // Get YouTube URL link from url textbox
            youTubeURLString = urlTextBox.Text;
                       
            // Get all the available video formats and put them in an array
            videoInfos = DownloadUrlResolver.GetDownloadUrls(youTubeURLString).ToArray();

            // place all the formats in dropdown of quality box
            foreach(VideoInfo video in videoInfos)
            {
                //add all the available formats to the dropdown in quality field
                videoQualityComboBox.Items.Add(video);
            }
                }
                else
            {
                    //if the input is invalid
                    MessageBox.Show("Please enter the URL!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //if the input is invalid
                MessageBox.Show("You have entered wrong or invalid URL!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
                //set the properties of saveFileDialog
                saveFileDialog.Filter = "Mp4 Video|*.mp4|WEBM Video|*.webm|Mobile Video|*.3gp|Flash Video|*.flv|All files (*.*)|*.*";
                saveFileDialog.Title = "Save file as";
                saveFileDialog.FileName = Path.GetFileName(videoQualityComboBox.Text.Substring(12, 30));
                saveFileDialog.ShowDialog();
                saveLocationTextBox.Text = saveFileDialog.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the application
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate object
            About aboutForm = new About();
            //display the object
            aboutForm.ShowDialog(); ;
        }
    }
}
