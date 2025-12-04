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
using AppMultiTool.Utils.GlobalItems;
using MasterWindowsForms;

namespace AppMultiTool.MainForms
{
    public partial class GenValidatorCPF : Form
    {
        bool gerarpontuacaoCPF = true;
        bool gerarpontuacaoCNPJ = true;

        public GenValidatorCPF()
        {
            InitializeComponent();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void GenValidatorCPF_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => Master.SwitchScreen(Global.Forms.MainMenu,this);

        #region CPF_FLOW
        private void chbGerarPont_CheckedChanged(object sender, EventArgs e) => gerarpontuacaoCPF = ((CheckBox)sender).Checked;

        private void txtCPFVal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = ((TextBox)sender).Text;
                string newtext = text;

                if (text.Length == 11)
                    newtext = text.Substring(0, 3) + "." + text.Substring(3, 3) + "." + text.Substring(6, 3) + "-" + text.Substring(9, 2);
                else if(text.Length != 14 && (text.Contains("-") || text.Contains(".")))
                    newtext = text.Replace(".", string.Empty).Replace("-", string.Empty).Trim();
                
                if(newtext != text)
                    txtCPFVal.Text = newtext;

                Master.MoveCursorToEnd(sender as TextBox);
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random x = new();
            string CPF = string.Empty;

            for (int i = 0; i < 9; i++)
                CPF += (x.Next(0, 9)).ToString();

            CPF += GenerateCheckDigitCPF(CPF);

            if (gerarpontuacaoCPF)
                txtCPFGerated.Text = CPF.Substring(0, 3) + "." + CPF.Substring(3, 3) + "." + CPF.Substring(6, 3) + "-" + CPF.Substring(9, 2);
            else
                txtCPFGerated.Text = CPF;

            Clipboard.SetText(txtCPFGerated.Text);
        }

        private void btnValidateCPF_Click(object sender, EventArgs e)
        {
            string CPF = txtCPFVal.Text.Replace("-", string.Empty).Replace(".", string.Empty).Trim();
            try
            {
                if (CPF.Length != 11)
                    throw new Exception("Quantidade inválidada de caracteres");

                string checkDigit = GenerateCheckDigitCPF(CPF.Substring(0, 9));

                if (CPF.Substring(9,2) == checkDigit)
                {
                    lblValidCPF.Visible = true;
                    lblInvalidCPF.Visible = false;
                }
                else
                {
                    lblValidCPF.Visible = false;
                    lblInvalidCPF.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
                txtCPFVal.Text = string.Empty;
                lblInvalidCPF.Visible = false;
                lblValidCPF.Visible = false;
            }            
        }
        private void txtCPFVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
                btnValidateCPF_Click(sender, e);
        }

        private string GenerateCheckDigitCPF(string CPF)
        {
            int digit1, digit2;
            int buffer = 0;
            int aux = 10;
            int y;

            for (int i = 0; i < CPF.Length; i++)
            {
                y = Convert.ToInt32(CPF.Substring(i,1));
                buffer += y * aux;
                aux--;
            }

            digit1 = buffer % 11 >= 2 ? 11 - (buffer % 11) : 0;
            buffer = 0;
            aux = 11;

            CPF += digit1.ToString();

            for (int i = 0; i < CPF.Length; i++)
            {
                y = Convert.ToInt32(CPF.Substring(i, 1));
                buffer += y * aux;
                aux--;
            }

            digit2 = buffer % 11 >= 2 ? 11 - (buffer % 11) : 0;

            return digit1.ToString() + digit2.ToString();
        }
        #endregion

        #region CNPJ_FLOW
        private void checkBox1_CheckedChanged(object sender, EventArgs e) => gerarpontuacaoCNPJ = ((CheckBox) sender).Checked;
        private void txtCNPJVal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = ((TextBox)sender).Text;
                string newtext = text;

                if (text.Length == 14)
                    newtext = text.Substring(0, 2) + "." + text.Substring(2, 3) + "." + text.Substring(5, 3) + "/" + text.Substring(8, 4) + "-" + text.Substring(12, 2);
                else if (text.Length != 18 && (text.Contains("-") || text.Contains(".") || text.Contains("/")))
                    newtext = text.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/","").Trim();

                if (newtext != text)
                    txtCNPJVal.Text = newtext;

                Master.MoveCursorToEnd(sender as TextBox);
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }
        private void btnGenCNPJ_Click(object sender, EventArgs e)
        {
            Random x = new();

            string CNPJ = string.Empty;

            for (int i = 0; i < 8; i++)
                CNPJ += (x.Next(0, 9)).ToString();

            CNPJ += "0001";
            CNPJ += GenerateCheckDigitCNPJ(CNPJ);

            if (gerarpontuacaoCNPJ)
                txtCNPJGerated.Text = CNPJ.Substring(0, 2) + "." + CNPJ.Substring(2, 3) + "." + CNPJ.Substring(5, 3) + "/" + CNPJ.Substring(8, 4) + "-" + CNPJ.Substring(12, 2);
            else
                txtCNPJGerated.Text = CNPJ;

            Clipboard.SetText(txtCNPJGerated.Text);
        }
        private void btnValidateCNPJ_Click(object sender, EventArgs e)
        {
            string CNPJ = txtCNPJVal.Text.Replace("-", string.Empty).Replace(".", string.Empty).Replace("/","").Trim();
            try
            {
                if (CNPJ.Length != 14)
                    throw new Exception("Quantidade inválidada de caracteres");

                string checkDigit = GenerateCheckDigitCNPJ(CNPJ.Substring(0, 12));

                if (CNPJ.Substring(12, 2) == checkDigit)
                {
                    lblValidCNPJ.Visible = true;
                    lblInvalidCNPJ.Visible = false;
                }
                else
                {
                    lblValidCNPJ.Visible = false;
                    lblInvalidCNPJ.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
                txtCNPJVal.Text = string.Empty;
                lblInvalidCNPJ.Visible = false;
                lblValidCNPJ.Visible = false;
            }
        }
        private void txtCNPJVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
                btnValidateCNPJ_Click(sender, e);
        }

        private string GenerateCheckDigitCNPJ(string CNPJ)
        {
            int[] mult1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int digit1, digit2;
            int buffer = 0;
            int y;

            for (int i = 0; i < CNPJ.Length; i++)
            {
                y = Convert.ToInt32(CNPJ.Substring(i, 1));
                buffer += y * mult1[i];
            }

            digit1 = buffer % 11 >= 2 ? 11 - (buffer % 11) : 0;
            buffer = 0;
            CNPJ = CNPJ + digit1.ToString();

            for (int i = 0; i < CNPJ.Length; i++)
            {
                y = Convert.ToInt32(CNPJ.Substring(i, 1));
                buffer += y * mult2[i];
            }

            digit2 = buffer % 11 >= 2 ? 11 - (buffer % 11) : 0;

            return digit1.ToString() + digit2.ToString();
        }

        #endregion
    }
}
