using System;
using System.Windows.Forms;
using MasterWindowsForms;
using AppMultiTool.Utils;
using AppMultiTool.RelatedForms;
using AppMultiTool.Models;
using System.Timers;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            lblPickApp.Focus();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this,wpp);

            Global.InactivityMonitor.ResetTimer();
            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        #region SwitchScreen
        private void MenuInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Global.AllowCloseApp)
                Application.Exit();
        }

        private void btnWppBot_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.WppBot);
        private void btnGPTMessenger_click(object sender, EventArgs e) => SwitchScreen(Global.Forms.GPTMessenger);
        private void btnVideoAudioDownloader_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.VideoAudioDownloader);
        private void btnCPFUsings_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.GenValidatorCPF);
        private void btnClipboardCopies_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.ClipboardCopies);
        private void btnConvertText_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.TextConverter);
        private void btnSSConvert_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.SpreadSheetConverter);
        private void btnMediaConverter_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.MediaConverter);
        private void btnStartsJobsRoutine_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.Routine);
        private void btnJoyStickController_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.JoyStickController);
        private void btnPlaylistMaker_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.PlaylistMaker);
        private void btnDateCalculator_Click(object sender, EventArgs e) => SwitchScreen(Global.Forms.DateCalculator);
        private void SwitchScreen(Form form) => Master.SwitchScreen(form, this);
        #endregion

        #region Options
        private void tsmiCommandLine_Click(object sender, EventArgs e) => CommandLine.Show(this);

        private void tsmiConfigs_Click(object sender, EventArgs e)
        {
            if (Global.Forms.GeneralConfigs.IsDisposed)
                Global.Forms.GeneralConfigs = new();

            Master.ShowScreen(Global.Forms.GeneralConfigs);
        }

        #endregion
    }
}
