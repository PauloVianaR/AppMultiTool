using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppMultiTool.Utils;
using AppMultiTool.Models;
using AppMultiTool.RelatedForms;
using MasterWindowsForms;
using MySql.Data.MySqlClient;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class ClipboardCopies : Form
    {
        private int LocateIndex = 0;
        private string hiddenText = string.Empty;
        private readonly MasterMySQLService sql;
        private readonly List<TextItem> textItems;
        private readonly XMLHandler xml;

        public ClipboardCopies()
        {
            InitializeComponent();
            Global.InactivityMonitor.ResetTimer();

            cbbListItens.SelectedIndex = 0;
            cbbFontSize.SelectedIndex = 2;
            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));
            textItems = [];

            xml = new(CommonFile.AppSettings);
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

        private void ClipboardCopies_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Global.AllowCloseApp)
                Application.Exit();
        }

        private async void ClipboardCopies_Load(object sender, EventArgs e)
        {
            await ConnectDB();

            var resp = xml.GetValueByAddKey(AppKeys.FontSizeDefault);

            string size = resp.WasSuccessful ? resp.Response : "11";
            int cbbindex = cbbFontSize.Items.IndexOf($"{size}pt");
            cbbFontSize.SelectedIndex = cbbindex;
        }

        private void copiarDeArquivosTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Global.Forms.ClipBoardCopiesTxt;

            if (form.IsDisposed)
                Global.Forms.ClipBoardCopiesTxt = new();

            Master.SwitchScreen(Global.Forms.ClipBoardCopiesTxt, this);
        }

        private string GetTitle() => txtShowItem.Text.Contains("[title]") ? txtShowItem.Text.Split("[title]").GetValue(0).ToString() : string.Empty;
        private int GetTextCopyID() => textItems[cbbListItens.SelectedIndex - 1].ID;
        private void chkCanHighLight_CheckedChanged(object sender, EventArgs e) => cbbListItens_SelectedIndexChanged(cbbListItens, EventArgs.Empty);

        private void txtShowItem_TextChanged(object sender, EventArgs e)
        {
            lblInfoTxtChanged.Visible = true;
            if (txtShowItem.Text.Trim() == "")
            {
                cbbListItens.SelectedIndex = 0;
                txtShowItem.Focus();
            }

            if (chkCanHighLight.Checked)
                Utilix.HighlightSyntax(sender as RichTextBox);
        }

        private void cbbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtShowItem.Font = new("Segoe UI", float.Parse((sender as ComboBox).SelectedItem.ToString().Replace("pt", "")), txtShowItem.Font.Style, GraphicsUnit.Point);
            lblInfoTxtChanged.Visible = false;
            btnCopyToClipboard.Focus();
        }

        private void cbbListItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            txtShowItem.Text = index == 0 ? string.Empty : textItems[index - 1].Textbody;
            hiddenText = index == 0 ? string.Empty : textItems[index - 1].Textbody;
            lblInfoTxtChanged.Visible = false;

            if (index != 0)
                ConvertTextTags(textItems[index - 1].Textbody);

            lblInfoTxtChanged.Visible = false;
            btnCopyToClipboard.Focus();
        }

        private void ConvertTextTags(string textbody, bool useHiddenText = false)
        {
            List<string> styletext = [];

            Regex regex = new(@"<bold>(.*?)</bold>");
            var matches = MatchList.ConvertBy(regex.Matches(textbody));
            matches.ForEach(m => styletext.Add(m.Groups[1].Value));

            txtShowItem.Text = textbody.Replace("<bold>", "").Replace("</bold>", "");

            if (useHiddenText)
            {
                string[] formats = { "<bold>", "</bold>", "<italic>", "</italic>", "<underline>", "</underline>", "<strikeout>", "</strikeout>" };
                string format = string.Join("|", formats);

                hiddenText = Regex.Replace(textbody, format, string.Empty);
            }

            styletext.ForEach(t =>
            {
                txtShowItem.Select(txtShowItem.Text.IndexOf(t), t.Length);
                txtShowItem.SelectionFont = new System.Drawing.Font(txtShowItem.Font, FontStyle.Bold);
            });
        }

        private async Task ConnectDB()
        {
            try
            {
                string query = "SELECT * FROM textcopies ORDER BY title";

                var resp = await sql.ReadQuery(query);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                var listItems = resp.Response;

                if (listItems.Count > 1)
                {
                    listItems.ForEach(item =>
                    {
                        TextItem textitem = new(item.ID, item.Title, item.Propertys);
                        textItems.Add(textitem);
                        cbbListItens.Items.Add(textitem.Title);
                    });
                }

                for (int i = 1; i < cbbListItens.Items.Count; i++)
                {
                    textItems[i - 1].ComboBoxIndex = i;
                }

                lblLoading.Visible = false;
                Master.EnableControls<Button>(this);

                cbbFontSize.Enabled = true;
                cbbListItens.Enabled = true;
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilix.IsNotNullOrEmptyOrWhiteSpace(txtShowItem.Text))
                {
                    string item = txtShowItem.Text.Contains("[title]") ? txtShowItem.Text.Split("[title]").GetValue(1).ToString().TrimStart() : txtShowItem.Text;

                    Clipboard.SetText(item);
                    Master.ShowQuickly(lblCopied);
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void ActionItem(object sender, EventArgs e)
        {
            if (cbbListItens.SelectedIndex > 0)
            {
                var btn = (sender as Button);
                string text = btn.Text;
                btn.Enabled = false;
                btn.Text = "Aguarde...";

                Action execute = (sender as Button).TabIndex == 1 ? UpdateItem : DeleteItem;
                execute();

                btn.Text = text;
                btn.Enabled = true;
            }

            btnCopyToClipboard.Focus();
        }

        private async void btnInsertItem_Click(object sender, EventArgs e)
        {
            if (cbbListItens.SelectedIndex == 0 && txtShowItem.Text == "#bypass $auto_clicker#")
                Master.SwitchScreen(new AutoClicker(), this);
            else
            {
                lblLoading.Visible = true;
                try
                {
                    if (!txtShowItem.Text.Contains("[title]"))
                        throw new Exception("É necessário declarar o nome antes da tag [title] para poder fazer uma nova inserção!");

                    string title = GetTitle();
                    string body = txtShowItem.Text;

                    int nextID = 1;

                    if (textItems.Count > 0)
                    {
                        TextItem lastTC = textItems.OrderByDescending(tc => tc.ID).First();
                        nextID = lastTC.ID + 1;
                    }

                    string sqlquery = $"INSERT INTO textcopies(id,title,textbody) VALUES ({nextID},@title,@body)";
                    var command = new MySqlCommand(sqlquery, sql.Connection);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@body", body);

                    var resp = await sql.ExecuteQuery(command);

                    if (!resp.WasSuccessful)
                        throw new Exception(resp.ResponseErr);

                    if (resp.Response > 0)
                    {
                        int nextindex = cbbListItens.Items.Count;

                        textItems.Add(new TextItem(nextID, title, body, nextindex));
                        cbbListItens.Items.Add(title);
                        cbbListItens.SelectedIndex = nextindex;
                        lblInfoTxtChanged.Visible = false;
                        lblLoading.Visible = false;
                        ShowItemStatus("INSERIDO!");
                    }
                    else
                        Master.ShowInfoMessage("Nenhum valor foi inserido");
                }
                catch (Exception ex)
                {
                    Master.ShowErrorMessage(ex.Message);
                }
                lblLoading.Visible = false;
            }
        }

        private async void UpdateItem()
        {
            try
            {
                if (cbbListItens.SelectedIndex <= 0)
                    throw new Exception("Necessário escolher um item para atualizá-lo");

                if (!txtShowItem.Text.Contains("[title]"))
                    throw new Exception("O item precisar conter a tag [title] antes do título para ser possível atualizá-lo!");

                string title = GetTitle();
                string body = txtShowItem.Text;
                int id = GetTextCopyID();

                string sqlquery = $"UPDATE textcopies SET title = @title,textbody = @body where id = {id}";
                var command = new MySqlCommand(sqlquery, sql.Connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@body", body);

                var resp = await sql.ExecuteQuery(command);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    cbbListItens.Items[cbbListItens.SelectedIndex] = title;

                    TextItem textCopy = textItems.First(tc => tc.ID == id);
                    textCopy.Title = title;
                    textCopy.Textbody = body;
                    textCopy.ComboBoxIndex = cbbListItens.SelectedIndex;
                    txtShowItem.Text = body;

                    cbbListItens.Items[textCopy.ComboBoxIndex] = textCopy.Title;
                    lblInfoTxtChanged.Visible = false;
                    lblLoading.Visible = false;
                    ShowItemStatus("ATUALIZADO!");
                }
                else
                    Master.ShowInfoMessage("Nenhum item foi atualizado");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private async void DeleteItem()
        {
            try
            {
                if (cbbListItens.SelectedIndex <= 0)
                    throw new Exception("Necessário escolher um item para removê-lo!");

                DialogResult dr = Master.ShowQuestionMessage("Deseja mesmo remover o item?", "Atenção");
                if (dr != DialogResult.Yes)
                    return;

                int id = GetTextCopyID();
                string sqlquery = $"DELETE FROM textcopies WHERE id = {id}";

                var resp = await sql.ExecuteQuery(sqlquery);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    Master.ShowInfoMessage("Item removido com sucesso");

                    TextItem textcopy = textItems.First(tc => tc.ComboBoxIndex == cbbListItens.SelectedIndex);
                    textItems.Remove(textcopy);

                    int index = cbbListItens.SelectedIndex;
                    cbbListItens.SelectedIndex = 0;
                    cbbListItens.Items.RemoveAt(index);

                    lblInfoTxtChanged.Visible = false;
                }
                else
                    Master.ShowInfoMessage("Nenhum item foi removido");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void ShowItemStatus(string txtINFO)
        {
            lblStatusInfo.Text = txtINFO;
            Master.ShowQuickly(lblStatusInfo, 1500);
        }

        private void btnLocateText_Click(object sender, EventArgs e)
        {
            if (Utilix.IsNotNullOrEmptyOrWhiteSpace(txtLocateText.Text) && Utilix.IsNotNullOrEmptyOrWhiteSpace(txtShowItem.Text))
            {
                string text = txtLocateText.Text;

                int index = txtShowItem.Text.IndexOf(text, LocateIndex, StringComparison.OrdinalIgnoreCase);

                if (index >= 0)
                {
                    txtShowItem.Select(index, text.Length);
                    txtShowItem.Focus();
                    LocateIndex += text.Length;
                }
                else
                {
                    Master.ShowErrorMessage("Texto não localizado!");
                    LocateIndex = 0;
                }
            }
            else
                LocateIndex = 0;
        }

        private void ChangeFontStyle(object sender, EventArgs e)
        {
            if (txtShowItem.SelectionLength > 0)
            {
                try
                {
                    FontStyle _fs = txtShowItem.SelectionFont.Style;
                    FontStyle fs = (FontStyle)Convert.ToInt32((sender as Button).Tag.ToString());

                    string selectedTXT = txtShowItem.SelectedText;

                    if (fs.Equals(_fs))
                    {
                        fs = FontStyle.Regular;
                        ConvertTextTags(hiddenText, true); // to fix
                    }
                    else
                    {
                        hiddenText = txtShowItem.Text.Replace(selectedTXT, string.Concat("<", fs.ToString().ToLower(), ">", selectedTXT, "</", fs.ToString().ToLower(), ">"));
                    }

                    txtShowItem.Select(txtShowItem.Text.IndexOf(selectedTXT), selectedTXT.Length);
                    txtShowItem.SelectionFont = new(txtShowItem.Font, fs);
                }
                catch (Exception ex)
                {
                    Master.ShowErrorMessage(ex.Message);
                }
            }

            btnCopyToClipboard.Focus();
        }

        private async void btnExportTxt_Click(object sender, EventArgs e)
        {
            string textBtn = btnExportTxt.Text;
            btnExportTxt.Enabled = false;
            btnExportTxt.Text = "Aguarde...";

            try
            {
                SaveFileDialog fileHandler = new()
                {
                    Filter = "Arquivos de texto|*.txt",
                    Title = "Salvar arquivo de texto"
                };
                string _filename = this.GetTitle().Trim();
                fileHandler.FileName = Utilix.SanitizeFileName(_filename == string.Empty ? "Meu TXT" : _filename);

                if (fileHandler.ShowDialog() == DialogResult.OK)
                {
                    string path = fileHandler.FileName;
                    await File.WriteAllTextAsync(path, txtShowItem.Text.Replace("[title]", string.Empty));

                    this.ShowItemStatus("Exportado!");
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            btnExportTxt.Enabled = true;
            btnExportTxt.Text = textBtn;
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            string textBtn = btnExportPDF.Text;
            btnExportPDF.Enabled = false;
            btnExportPDF.Text = "Aguarde...";

            try
            {
                SaveFileDialog fileHandler = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Salvar como PDF"
                };

                string _filename = this.GetTitle().Trim();
                fileHandler.FileName = Utilix.SanitizeFileName(_filename == string.Empty ? "Meu PDF" : _filename);

                if (fileHandler.ShowDialog() == DialogResult.OK)
                {
                    string text = txtShowItem.Text;

                    PdfDocument document = new();
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont font = new("Arial", 12);
                    gfx.DrawString(text, font, XBrushes.Black, new XPoint(40, 40));

                    double yPosition = 40;

                    string[] linhas = text.Split([Environment.NewLine], StringSplitOptions.None);

                    foreach (var linha in linhas)
                    {
                        gfx.DrawString(linha, font, XBrushes.Black, new XPoint(40, yPosition));
                        yPosition += 16;
                    }

                    document.Save(fileHandler.FileName);

                    this.ShowItemStatus("Exportado!");
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            btnExportPDF.Enabled = true;
            btnExportPDF.Text = textBtn;
        }        

        private void lblSearchText_MouseEnter(object sender, EventArgs e) => lblSearchText.Cursor = Cursors.Hand;
        private void lblSearchText_MouseLeave(object sender, EventArgs e) => lblSearchText.Cursor = Cursors.Default;
        private void lblSearchText_Click(object sender, EventArgs e)
        {
            lblSearchText.Cursor = Cursors.Default;

            Global.Forms.TextSearcher.Dispose();
            Global.Forms.TextSearcher = new(SearcherType.DataBase);

            Global.Forms.TextSearcher.SelectedText += PickSelectedText;
            Master.ShowScreen(Global.Forms.TextSearcher);
        }

        private void PickSelectedText(string selectedText)
        {
            int index = cbbListItens.Items.IndexOf(selectedText);
            cbbListItens.SelectedIndex = index;
        }
    }
}
