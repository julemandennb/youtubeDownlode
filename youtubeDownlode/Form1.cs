using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;
using Profil;
using Microsoft.WindowsAPICodePack.Dialogs;
using YoutubeExplode.Common;

namespace youtubeDownlode
{
    public partial class Form1 : Form
    {
        private User user;
        private YoutubeClient youtube;
        private int step = 0;
        private int ListNr = 0;
        private int IsOn = 0;

        public Form1()
        {
            InitializeComponent();

            var handler = new HttpClientHandler();
            var httpClient = new HttpClient(handler, true);
            handler.UseCookies = false;

            youtube = new YoutubeClient(httpClient);

            user = new User().GetUser();

            this.labelPAHT.Text = user.GetSetpath;


        }

        private void NullStil()
        {
            this.listBoxVideo.Items.Clear();
            this.progressBarDone.Value = 0;
            ListNr = 0;
            IsOn = 0;

    }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            this.NullStil();
            if (this.textBoxUrl.Text.Length > 0)
            {
                step = 100;
                ListNr = 1;
                _ = GetInfoAsync(this.textBoxUrl.Text);
            }
        }

        private void buttonPlayList_Click(object sender, EventArgs e)
        {
            this.NullStil();
            if (this.textBoxUrl.Text.Length > 0)
                _ = GetInfoPlayList();
        }

        private async Task GetInfoPlayList()
        {
            var playlist = await youtube.Playlists.GetVideosAsync(this.textBoxUrl.Text);
            ListNr = playlist.Count-1;
            var stepTonAdd = 100 / Convert.ToDecimal(playlist.Count);
            step = Convert.ToInt32(Math.Floor(stepTonAdd));

            foreach(var video in playlist)
            {
                _ = GetInfoAsync(video.Url);
            }
        }

        private async Task GetInfoAsync(string url)
        {

                var video = await youtube.Videos.GetAsync(url);
                string name = video.Title;
                name = name.Replace(" ", "_").Replace(":", "").Replace("|", "").Replace("*", "");

                getVideo(url, name);
        }

        private async void getVideo(string url,string name)
        {

            try
            {
                await youtube.Videos.DownloadAsync(url, user.GetSetpath + name + FileType);


                this.listBoxVideo.Items.Add(name + " Done");

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(user.GetSetpath + name + "errorYotube.txt", ex.ToString());
                this.listBoxVideo.Items.Add(name + " Error");
                
            }
            finally
            {

                if (IsOn >= ListNr)
                    this.progressBarDone.Value = 100;
                else
                {
                    this.progressBarDone.Value = this.progressBarDone.Value + this.step;

                    IsOn ++;

                }
            }
        }

        private void buttonPaht_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = this.user.GetSetpath;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                user.GetSetpath = dialog.FileName;
                this.labelPAHT.Text = dialog.FileName;
            }

        }


        private string FileType
        {
            get
            {

                if (this.radioMp3.Checked)
                    return ".mp3";
                else
                    return ".mp4";
            }
        }


    }
}
