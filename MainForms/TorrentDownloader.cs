using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MasterWindowsForms;
using MonoTorrent;
using MonoTorrent.Client;
using AppMultiTool.Utils;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class TorrentDownloader : Form
    {
        private string torrentFilePath = string.Empty;
        private string saveFolderPath = string.Empty;

        private ClientEngine engine;
        private TorrentManager manager;
        private CancellationTokenSource cancellationTokenSource;

        public TorrentDownloader()
        {
            InitializeComponent();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => Master.SwitchScreen(Global.Forms.MainMenu, this);
        private void TorrentDownloader_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void btnPickTorrentFile_Click(object sender, EventArgs e)
        {
            btnPickTorrentFile.Enabled = false;

            var fileHandler = new OpenFileDialog
            {
                Filter = "Arquivo Torrent|*.torrent",
                Title = "Escolha o arquivo Torrent"
            };

            if (fileHandler.ShowDialog() == DialogResult.OK)
            {
                torrentFilePath = fileHandler.FileName;
                lblTorrentFile.Text = fileHandler.SafeFileName;
            }

            btnPickTorrentFile.Enabled = true;
        }

        private void btnPickFinalPath_Click(object sender, EventArgs e)
        {
            btnPickFinalPath.Enabled = false;

            var folderHandler = new FolderBrowserDialog();
            folderHandler.Description = "Escolha onde salvar o arquivo";

            if(folderHandler.ShowDialog() == DialogResult.OK)
            {
                saveFolderPath = folderHandler.SelectedPath;
                txtSaveFolderPath.Text = saveFolderPath;
            }

            btnPickFinalPath.Enabled = true;
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            btnStopDownload.Enabled = true;
            btnDownload.Enabled = false;
            try
            {
                if (string.IsNullOrEmpty(saveFolderPath))
                    throw new Exception("Caminho de saída não selecionado!");

                if (string.IsNullOrEmpty(torrentFilePath))
                    throw new Exception("Arquivo torrent não selecionado!");

                cancellationTokenSource = new CancellationTokenSource();
                var token = cancellationTokenSource.Token;

                if (chbCanVerifyVirusFile.Checked)
                {
                    var virusChecker = new VirusChecker();
                    var resp = await virusChecker.IsFileSafe(torrentFilePath);

                    if (!resp.WasSuccessful)
                        throw new Exception(resp.ResponseErr);

                    if (!resp.Response)
                        throw new Exception("O arquivo não é seguro!!");
                }                

                Torrent torrent = await Torrent.LoadAsync(torrentFilePath);
                manager = new TorrentManager(torrent, saveFolderPath, new TorrentSettings());
                engine = new ClientEngine(new EngineSettings());
                await engine.Register(manager);

                await Task.Run(() => manager.StartAsync(), cancellationTokenSource.Token);

                while (manager.State != TorrentState.Seeding)
                {
                    if (cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        await manager.StopAsync();
                        break;
                    }

                    Invoke((MethodInvoker)delegate
                    {
                        pgbDownloadStatus.Value = (int)manager.Progress;
                        lblProgress.Text = $"Progress: {manager.Progress:0.00}%";
                    });
                    await Task.Delay(1000);
                }

                if (manager.State == TorrentState.Stopped)
                {
                    Master.ShowInfoMessage("Download cancelado.");
                }
                else
                {
                    Master.ShowInfoMessage("Download concluído.");
                }
            }
            catch (OperationCanceledException)
            {
                Master.ShowInfoMessage("Download cancelado");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
                StopDownload();
            }
            finally
            {
                btnDownload.Enabled = true;
                btnStopDownload.Enabled = false;
            }            
        }

        private void btnStopDownload_Click(object sender, EventArgs e) => StopDownload();

        private void StopDownload()
        {
            cancellationTokenSource?.Cancel();
            manager?.StopAsync();
            engine?.Dispose();
            btnStopDownload.Enabled = false;
        }
    }
}
