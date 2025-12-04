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
    public partial class TextConverter : Form
    {
        private bool converted = false;
        private bool autocommaEnabled = false;
        private string bkpText = string.Empty;
        private string textbase = string.Empty;
        private readonly XMLHandler xml;

        public TextConverter()
        {
            InitializeComponent();

            if (Global.Forms?.TextConverter is not null)
                Global.Forms.TextConverter = this;

            cbbFontSize.SelectedIndex = cbbFontSize.Items.IndexOf(txtText.Font.Size.ToString() + "pt");

            xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void TextConverter_Shown(object sender, EventArgs e)
        {
            var resp = xml.GetValueByAddKey(AppKeys.FontSizeDefault);

            string size = resp.WasSuccessful ? resp.Response : "11";
            int cbbindex = cbbFontSize.Items.IndexOf($"{size}pt");
            cbbFontSize.SelectedIndex = cbbindex;
        }

        private void TextConverter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Global.AllowCloseApp)
                Application.Exit();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Global.AllowCloseApp)
                this.Hide();
            else
                Master.SwitchScreen(Global.Forms.MainMenu, this);
        }

        private void brnClean_Click(object sender, EventArgs e) => txtText.Text = string.Empty;
        private void brnReset_Click(object sender, EventArgs e) => Master.SwitchScreen(new TextConverter(),this);

        private void SwitchOptionsRadio(object sender, EventArgs e)
        {
            converted = true;

            RadioButton rd = ((RadioButton)sender);

            switch (rd.TabIndex)
            {
                case 1:
                    if (txtText.Text != bkpText)
                        txtText.Text = bkpText;
                    break;
                case 2:
                    txtText.Text = txtText.Text.ToLower();
                    break;
                case 3:
                    txtText.Text = txtText.Text.ToUpper();
                    break;
            }
        }

        private void SwitchOptionsCheck(object sender, EventArgs e)
        {
            converted = true;
            CheckBox chk = ((CheckBox)sender);
            FontStyle fs = FontStyle.Regular;

            switch (chk.TabIndex)
            {
                case 1:
                    if (chk.Checked)
                    {
                        txtText.Text = txtText.Text.Replace(",", "").Replace(".", "").Replace(":", "").Replace(";", "").Replace("/", "").Replace("?", "").Replace(">", "").Replace("<", "").Replace("~", "")
                        .Replace("^", "").Replace("]", "").Replace("}", "").Replace("[", "").Replace("{", "").Replace("º", "").Replace("ª", "").Replace("´", "").Replace("`", "").Replace("!", "")
                        .Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("¨", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("-", "")
                        .Replace("_", "").Replace("+", "").Replace("=", "").Replace("|", "").Replace("'", "").Replace("¹", "").Replace("²", "").Replace("³", "").Replace("£", "").Replace("¢", "")
                        .Replace("¬", "");
                    }
                    else
                        txtText.Text = bkpText;
                    break;
                case 2:
                    if (chk.Checked)
                    {
                        txtText.Text = txtText.Text.Replace(",", " ").Replace(".", " ").Replace(":", " ").Replace(";", " ").Replace("/", " ").Replace("?", " ").Replace(">", " ").Replace("<", " ").Replace("~", " ")
                        .Replace("^", " ").Replace("]", " ").Replace("}", " ").Replace("[", " ").Replace("{", " ").Replace("º", " ").Replace("ª", " ").Replace("´", " ").Replace("`", " ").Replace("!", " ")
                        .Replace("@", " ").Replace("#", " ").Replace("$", " ").Replace("%", " ").Replace("¨", " ").Replace("&", " ").Replace("*", " ").Replace("(", " ").Replace(")", " ").Replace("-", " ")
                        .Replace("_", " ").Replace("+", " ").Replace("=", " ").Replace("|", " ").Replace("'", " ").Replace("¹", " ").Replace("²", " ").Replace("³", " ").Replace("£", " ").Replace("¢", " ")
                        .Replace("¬", " ");
                    }
                    else
                        txtText.Text = bkpText;
                    break;
            }

            txtText.Font = new Font("Segoe UI", txtText.Font.Size, fs, GraphicsUnit.Point);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            string text = ((RichTextBox)sender).Text;

            if (autocommaEnabled)
            {
                text += ",";
                txtText.Text = text;
                Master.MoveCursorToEnd(sender as RichTextBox);
            }                

            if (!converted && text != bkpText)
                bkpText = text;
            else if(text == string.Empty && converted)
            {
                converted = false;
                bkpText = string.Empty;
            }
        }

        private void cbbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new(txtText.Font.FontFamily, float.Parse((sender as ComboBox).SelectedItem.ToString().Replace("pt", "")), txtText.Font.Style, txtText.Font.Unit);
            txtText.Font = font;
        }

        private void SeparateStrings(object sender, EventArgs e)
        {
            if (!txtText.Text.Contains(","))
                return;

            bkpText = txtText.Text;
            string singleQuote = ckbAddSingleQuotes.Checked ? "'" : string.Empty;
            string stringBefore = txtStringAddBefore.Text.Trim();
            string stringAfter = txtStringAddAfter.Text.Trim();

            try
            {
                List<string> list = txtText.Text.Split(",").ToList();
                txtText.Text = string.Empty;
                StringBuilder sb = new();
                if(ckbConcatResult.Checked)
                    list.ForEach(e => sb.Append(string.Concat(stringBefore, singleQuote, e.Trim(), singleQuote, stringAfter)));
                else
                    list.ForEach(e => sb.AppendLine(string.Concat(stringBefore, singleQuote, e.Trim(), singleQuote, stringAfter)));

                txtText.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
                txtText.Text = bkpText;
            }
        }

        private void btnRemoveStrings_Click(object sender, EventArgs e)
        {
            try
            {
                bkpText = txtText.Text;
                txtText.Text = bkpText.Replace(txtStringToRemove.Text, "");
            }
            catch (Exception)
            {
                Master.ShowErrorMessage("String a ser removida não foi definida!");
            }
        }

        private void btnInvertSeq_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> texts = txtText.Text.Split(txtStringComparation.Text).ToList();
                texts.Reverse();

                StringBuilder sb = new();

                texts.ForEach(t => sb.Append(t));
                txtText.Text = sb.ToString();
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void btnCopyText_Click(object sender, EventArgs e)
        {
            if(Utilix.IsNotNullOrEmptyOrWhiteSpace(txtText.Text))
            {
                Clipboard.SetText(txtText.Text);
                Master.ShowQuickly(lblCopySucess);
            }
        }

        private void btnSaveTextBase_Click(object sender, EventArgs e)
        {
            textbase = txtText.Text;
            btnBackTextBase.Enabled = true;
            Master.ShowQuickly(lblTextBaseSaveInfo);
        }

        private void btnBackTextBase_Click(object sender, EventArgs e) => txtText.Text = textbase;

        private void tsmiAutoComma_Click(object sender, EventArgs e)
        {
            if (autocommaEnabled)
            {
                tsmiAutoComma.Text = "Ativar Vírgula Automática";
                tsmiAutoComma.ForeColor = Color.Black;
            }
            else
            {
                tsmiAutoComma.Text = "Desativar Vírgula Automática";
                tsmiAutoComma.ForeColor = Color.Red;
            }

            autocommaEnabled = !autocommaEnabled;
            lblAutoCommaInfo.Visible = autocommaEnabled;
        }

        private void TextConverter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Oemcomma)
            {
                tsmiAutoComma_Click(sender, e);
            }
        }
    }
}
