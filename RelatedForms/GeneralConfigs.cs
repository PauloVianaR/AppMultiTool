using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterWindowsForms;
using AppMultiTool.Utils;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.RelatedForms
{
    public partial class GeneralConfigs : Form
    {
        private readonly XMLHandler xml;

        public GeneralConfigs()
        {
            InitializeComponent();

            xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);

            Global.InactivityMonitor?.ResetTimer();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.InactivityMonitor?.ResetTimer();
            this.Hide();
        }

        private void GeneralConfigs_Shown(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new();
                ResponseHandler<string> resp = new();

                sb.AppendLine(this.GetTagValue(AppKeys.InactivityTimeOut, out resp));
                numTimeOut.Value = int.Parse(resp.Response);

                sb.AppendLine(this.GetTagValue(AppKeys.UseTimeOut, out resp));
                chbUseInactivity.Checked = bool.Parse(resp.Response);

                sb.AppendLine(this.GetTagValue(AppKeys.YoutubeDownloadMethod, out resp));
                int index = cbbYTMethod.Items.IndexOf(resp.Response);
                cbbYTMethod.SelectedIndex = index;

                sb.AppendLine(this.GetTagValue(AppKeys.WallPaper, out resp));
                index = cbbWallPaperDefault.Items.IndexOf(resp.Response.Replace("None", "Nenhum"));
                cbbWallPaperDefault.SelectedIndex = index;

                sb.AppendLine(this.GetTagValue(AppKeys.FontSizeDefault, out resp));
                index = cbbFontSizeDefault.Items.IndexOf(string.Concat(resp.Response, "pt"));
                cbbFontSizeDefault.SelectedIndex = index;

                sb.AppendLine(this.GetTagValue(AppKeys.ShowRealTime, out resp));
                chbShowRealTime.Checked = bool.Parse(resp.Response);

                sb.AppendLine(this.GetTagValue(AppKeys.UseDarkTheme, out resp));
                chbUseDarkTheme.Checked = bool.Parse(resp.Response);

                sb.AppendLine(this.GetTagValue(AppKeys.CloseAfterCheckedDefaultRoutine, out resp));
                chbCloseAfterCheckedDefault.Checked = bool.Parse(resp.Response);

                sb.AppendLine(this.GetTagValue(AppKeys.DefaultDownloadFolderPath, out resp));
                txtFolderDefaultPath.Text = resp.Response;

                sb.AppendLine(this.GetTagValue(AppKeys.UseSpreedSheetConverterLogger, out resp));
                chbUseSSLogger.Checked = bool.Parse(resp.Response);

                lblNotSavedInfo.Visible = false;

                string errorList = sb.ToString().Trim();

                if (Utilix.IsNotNullOrEmptyOrWhiteSpace(errorList.Trim()))
                    throw new Exception(errorList);
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private string GetTagValue(AppKeys key, out ResponseHandler<string> response)
        {
            string error = string.Empty;

            var resp = xml.GetValueByAddKey(key);

            if (!resp.WasSuccessful)
                error = resp.ResponseErr;

            response = resp;
            return error;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new();
                ResponseHandler<bool> resp = new();

                sb.AppendLine(this.SetTagValue(AppKeys.InactivityTimeOut, numTimeOut.Value.ToString()));
                Global.InactivityMonitor.InactivityLimitInMinutes = (int)numTimeOut.Value;

                sb.AppendLine(this.SetTagValue(AppKeys.UseTimeOut, chbUseInactivity.Checked.ToString()));
                if (chbUseInactivity.Checked)
                    Global.InactivityMonitor.StopTimer();

                sb.AppendLine(this.SetTagValue(AppKeys.YoutubeDownloadMethod, cbbYTMethod.SelectedItem.ToString()));
                sb.AppendLine(this.SetTagValue(AppKeys.WallPaper, cbbWallPaperDefault.SelectedItem.ToString().Replace("Nenhum", "None")));
                sb.AppendLine(this.SetTagValue(AppKeys.FontSizeDefault, cbbFontSizeDefault.SelectedItem.ToString().Replace("pt", "")));
                sb.AppendLine(this.SetTagValue(AppKeys.ShowRealTime, chbShowRealTime.Checked.ToString()));
                sb.AppendLine(this.SetTagValue(AppKeys.UseDarkTheme, chbUseDarkTheme.Checked.ToString()));
                sb.AppendLine(this.SetTagValue(AppKeys.CloseAfterCheckedDefaultRoutine, chbCloseAfterCheckedDefault.Checked.ToString()));
                sb.AppendLine(this.SetTagValue(AppKeys.DefaultDownloadFolderPath, txtFolderDefaultPath.Text));
                sb.AppendLine(this.SetTagValue(AppKeys.UseSpreedSheetConverterLogger, chbUseSSLogger.Checked.ToString()));

                string errorList = sb.ToString().Trim();

                if (Utilix.IsNotNullOrEmptyOrWhiteSpace(errorList.Trim()))
                    throw new Exception(errorList);

                lblNotSavedInfo.Visible = false;
                Master.ShowQuickly(lblSavedSuccess, 800);

                string msg = $"Uma ou mais configurações foram alteradas e, para funcionar corretamente," +
                        "é necessário reiniciar o programa.\nDeseja reiniciar agora?";

                Global.ResetAppQuestionMsg(msg);
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private string SetTagValue(AppKeys key, string value)
        {
            string error = string.Empty;

            var resp = xml.SetValueByAddKey(key, value);

            if (!resp.WasSuccessful)
                error = resp.ResponseErr;

            return error;
        }

        private void CheckedChanged(object sender, EventArgs e) => lblNotSavedInfo.Visible = true;

        private void ValueChanged(object sender, EventArgs e) => lblNotSavedInfo.Visible = true;

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new() { Description = "Escolha a pasta" };

            if (dialog.ShowDialog() == DialogResult.OK)
                txtFolderDefaultPath.Text = dialog.SelectedPath;
        }
    }
}
