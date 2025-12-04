using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMultiTool.Utils;
using AppMultiTool.Utils.Controllers;
using MasterWindowsForms;

namespace AppMultiTool.RelatedForms
{
    public partial class JoyStickConfigs : Form
    {
        private readonly XMLHandler xml;

        public JoyStickConfigs()
        {
            InitializeComponent();

            xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
        }
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => this.Hide();

        private void JoyStickConfigs_Shown(object sender, EventArgs e)
        {
            try
            {
                string errorList = string.Empty;

                errorList += this.GetControlInfo(txtDeviceName, lblDeviceName, "JoyStickDeviceName");
                errorList += this.GetControlInfo(cbbSamplesRate, lblSampleRate, "AudioSamplingRate");
                errorList += this.GetControlInfo(cbbChannelType, lblChannelType, "ChannelType");

                lblChangesInfo.Visible = false;

                if (!string.IsNullOrEmpty(errorList) || errorList.Length > 0)
                    throw new Exception(errorList.ToString());
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message,"Falha ao carregar configurações");
            }
        }

        private string GetControlInfo<T>(T sender,Label bindLabel,string tagName) where T : Control
        {
            StringBuilder errorList = new();

            try
            {
                switch (sender)
                {
                    case TextBox txt:
                        var resp = xml.GetValueByAddKey(tagName);

                        if (!resp.WasSuccessful)
                            errorList.AppendLine($"{bindLabel} {resp.ResponseErr}\n");
                        else
                            txt.Text = resp.Response;
                        break;
                    case ComboBox cbb:
                        resp = xml.GetValueByAddKey(tagName);

                        if (!resp.WasSuccessful)
                            errorList.AppendLine($"{bindLabel} {resp.ResponseErr}\n");

                        int index = cbb.Items.IndexOf($"{resp.Response}");

                        if (index != -1)
                            cbb.SelectedIndex = index;
                        else
                            errorList.AppendLine($"{bindLabel} resposta não identificada: {resp.Response}\n");
                        break;
                }
            }
            catch(Exception ex)
            {
                errorList.AppendLine(ex.Message);
            }

            return errorList.ToString();
        }

        private void ConfigChanged(object sender, EventArgs e)
        {
            lblChangesInfo.Visible = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder errorList = new();

            try
            {
                errorList.AppendLine(this.SetControlValue(txtDeviceName, "JoyStickDeviceName"));
                errorList.AppendLine(this.SetControlValue(cbbSamplesRate, "AudioSamplingRate"));
                errorList.AppendLine(this.SetControlValue(cbbChannelType, "ChannelType"));

                string errors = errorList.ToString().Trim();

                if (!string.IsNullOrEmpty(errors.Trim()))
                    throw new Exception(errors);

                lblChangesInfo.Visible = false;
                Master.ShowQuickly(lblSucess);

            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private string SetControlValue<T>(T sender, string tagName) where T : Control
        {
            string errorMsg = string.Empty;
            bool success;

            try
            {
                string newValue = string.Empty;

                switch (sender)
                {
                    case TextBox txt:
                        if (Utilix.IsNullOrEmptyOrWhiteSpace(txt.Text))
                            throw new Exception($"O novo valor da TextBox '{txt.Name}' não pode ser vazio");

                        newValue = txt.Text.Trim();
                        break;
                    case ComboBox cbb:
                        if (cbb.SelectedIndex == -1)
                            throw new Exception($"Indíce selecionado na ComboBox '{cbb.Name}' foi inválido!");

                        newValue = cbb.SelectedItem.ToString().Trim();
                        break;
                }

                var resp = xml.SetValueByAddKey(tagName, newValue.Trim());

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                success = resp.Response;

                if (!success)
                    throw new Exception("Falha não identificada!");
            }
            catch(Exception ex)
            {
                errorMsg = ex.Message;
            }

            return errorMsg;
        }
    }
}
