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

namespace AppMultiTool.MainForms
{
    public partial class GPTMessenger : Form
    {
        public GPTMessenger()
        {
            InitializeComponent();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Global.AllowCloseApp)
                this.Hide();
            else
                Master.SwitchScreen(Global.Forms.MainMenu, this);
        }

        private void GPTMessenger_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Global.AllowCloseApp)
                Application.Exit();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string prompt = rtxtPrompt.Text;
            rtxtResponse.Text = string.Empty;
            Color greenColor = btnSend.BackColor;

            Utilix.DisableControlColor(btnSend, false, "AGUARDE");
            btnSend.BackColor = Color.Red;

            if (Utilix.IsNotNullOrEmptyOrWhiteSpace(prompt))
            {
                List<Func<string,ApiType,Task<ResponseHandler<string>>>> generateFuncs = new()
                {
                    GPTCommander.GenerateTextAsyncGPT,
                    GPTCommander.GenerateTextAsyncGPT, 
                    GPTCommander.GenerateTextAsyncHuggingFace, 
                    GPTCommander.GenerateTextAsyncGemini,
                    GPTCommander.GenerateTextAsyncDeepSeek
                };

                var radioOptions = Master.ListControls<RadioButton>(this);
                int index = 0;

                for (int i = 0; i < radioOptions.Count; i++)
                {
                    if (radioOptions[i].Checked)
                    {
                        index = i;
                        break;
                    }
                }

                if(index == 2)
                {
                    Master.ShowInfoMessage("HuggingFace -> WORK IN PROGRESS", "WIP");
                    Utilix.EnableControlColor(btnSend, false, "Enviar");
                    btnSend.BackColor = greenColor;
                    return;
                }

                var apiType = (ApiType)index;
                var generateTextFunc = generateFuncs[index];
                var resp = await generateTextFunc(prompt, apiType);

                if (!resp.WasSuccessful)
                {
                    rtxtResponse.Text = resp.ResponseErr;
                }
                else
                {
                    rtxtResponse.Text = resp.Response;
                }
            }

            Utilix.EnableControlColor(btnSend, false, "Enviar");
            btnSend.BackColor = greenColor;
        }

        private void lblCopyResponse_Click(object sender, EventArgs e)
        {
            string resp = rtxtResponse.Text;

            if (Utilix.IsNotNullOrEmptyOrWhiteSpace(resp))
            {
                Clipboard.SetText(resp);
                Master.ShowQuickly(lblCopyInfo);
            }
        }
    }
}
