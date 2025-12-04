using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterWindowsForms;
using AppMultiTool.Utils;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;


namespace AppMultiTool.MainForms
{
    public partial class VideoAudioDownloader : Form
    {
        string exitpath = string.Empty;

        public VideoAudioDownloader()
        {
            InitializeComponent();
            cbbSelectDownloadType.SelectedIndex = 0;
            exitpath = txtExitPath.Text;

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            exitpath = xml.GetValueByAddKey(AppKeys.DefaultDownloadFolderPath).Response + @"\";
            txtExitPath.Text = exitpath;

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void YoutubeVideoDownloader_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => Master.SwitchScreen(Global.Forms.MainMenu, this);

        private void btnDownloadInit_Click(object sender, EventArgs e)
        {
            if (Utilix.IsNotNullOrEmptyOrWhiteSpace(txtURL.Text))
                DownloadVideo();
        }

        private void btnChooseExitPath_Click(object sender, EventArgs e)
        {
            btnChooseExitPath.Enabled = false;
            fbdExitPathPicker.Description = "Escolha a pasta para salvar";

            if(fbdExitPathPicker.ShowDialog() == DialogResult.OK)
            {
                exitpath = fbdExitPathPicker.SelectedPath + @"\";
                txtExitPath.Text = exitpath;
            }
            btnChooseExitPath.Enabled = true;
        }

        private async void DownloadVideo()
        {
            Color backcolor = btnDownloadInit.BackColor;

            lblProgress.Text = "0.00%";
            pgbDownloadProgress.Value = 0;
            btnDownloadInit.Text = "AGUARDE";
            btnDownloadInit.Enabled = false;
            btnDownloadInit.BackColor = Color.Red;

            try
            {
                ResponseHandler<string> resp = new();
                YTDownloader ytdownloader = new();
                string url = txtURL.Text;

                var progress = new Progress<double>(percent =>
                {
                    Invoke((Action)(() =>
                    {
                        pgbDownloadProgress.Value = (int)(percent * 100);
                        lblProgress.Text = $"{percent * 100:0.00}%";
                    }));
                });

                switch (cbbSelectDownloadType.SelectedIndex)
                {
                    case 0:
                        resp = await ytdownloader.DownloadVideo(url, this.exitpath, progress);
                        break;
                    case 1:
                        resp = await ytdownloader.DownloadAudio(url, this.exitpath, progress);
                        break;
                    case 2:
                        resp = await InternetMediaDownloader.DownloadVideo(url, this.exitpath, progress);
                        break;
                    case 3:
                        resp = await InternetMediaDownloader.DownloadAudio(url, this.exitpath, progress);
                        break;
                }

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                Master.ShowQuickly(lblCompleted);
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            btnDownloadInit.Text = "BAIXAR";
            btnDownloadInit.Enabled = true;
            btnDownloadInit.BackColor = backcolor;
        }
    }
}
