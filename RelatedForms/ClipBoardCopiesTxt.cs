using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppMultiTool.Utils;
using AppMultiTool.MainForms;
using MasterWindowsForms;
using IronPython.Runtime.Operations;
using MySql.Data.MySqlClient;
using AngleSharp.Common;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.RelatedForms
{
    public partial class ClipBoardCopiesTxt : Form
    {
        private string folderPath = string.Empty;
        private int LocateIndex = 0;
        private bool insertingFile = false;
        private readonly MasterMySQLService sql;
        private readonly Dictionary<string, string> items;
        private readonly XMLHandler xml;

        #region Config
        public ClipBoardCopiesTxt()
        {
            InitializeComponent();
            Master.EnableControls<Button>(this);
            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));
            items = [];

            xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private async void ClipBoardCopiesTxt_Shown(object sender, EventArgs e)
        {
            var resp = xml.GetValueByAddKey(AppKeys.FontSizeDefault);

            string size = resp.WasSuccessful ? resp.Response : "11";
            int cbbindex = cbbFontSize.Items.IndexOf($"{size}pt");
            cbbFontSize.SelectedIndex = cbbindex;

            await ConnectDB();
        }

        private void ClipBoardCopiesTxt_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Global.AllowCloseApp)
                Application.Exit();
        }

        private async Task ConnectDB()
        {
            try
            {
                string query = "SELECT * FROM shortcuts";

                var resp = await sql.ReadQuery(query);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                var listItems = resp.Response;

                if (listItems.Count < 1)
                    return;

                listItems.ForEach(item => items.Add(item.Title, item.Propertys));
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region Options

        private void BackToScreen(object sender, EventArgs e)
        {
            var tsmi = sender as ToolStripMenuItem;

            if (!Global.AllowCloseApp && tsmi != tsmiBackClipBoardCopies)
                this.Hide();
            else
            {
                Form form = tsmi == tsmiBackMainMenu ? Global.Forms.MainMenu : Global.Forms.ClipboardCopies;
                var type = tsmi == tsmiBackMainMenu ? typeof(MainMenu) : typeof(ClipboardCopies);

                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(type);

                    if (tsmi == tsmiBackClipBoardCopies)
                        Global.Forms.ClipboardCopies = (ClipboardCopies)form;
                }

                Master.SwitchScreen(form, this);
            }
        }

        private void ViewShortCuts(object sender, EventArgs e)
        {
            StringBuilder sb = new();

            foreach (var item in items)
            {
                sb.AppendLine($"{item.Key} -> {item.Value}");
            }

            Master.ShowInfoMessage("Para usar os seguintes atalhos basta digitar $ " +
                "+ nomeDoAtalho em 'Encontrar Palavra' que, assim, será direcionado para os seguintes caminhos: \n\n" +
                sb.ToString(), "Info Atalhos");
        }

        private async void AddShortCut(object sender, EventArgs e)
        {
            string prompt = Prompt.ShowDialog("nome|caminho", "Adicionar Atalho");

            if (Utilix.IsNullOrEmptyOrWhiteSpace(prompt))
                return;

            try
            {
                if (!prompt.Contains('|'))
                    throw new Exception("Necessário informar o pipe --> |");

                var values = prompt.Split('|');
                string scName = values[0];
                string scPath = values[1];

                if (scName.startswith("$"))
                    throw new Exception("O nome do atalho não pode iniciar com '$'");

                if (!scPath.Contains(@"\"))
                    throw new Exception(@"O caminho deve conter contrabarra --> \");

                string sqlquery = $"INSERT INTO shortcuts(shortCutName,shortCutPath) VALUES (@scname,@scpath)";
                var command = new MySqlCommand(sqlquery, sql.Connection);
                command.Parameters.AddWithValue("@scname", scName);
                command.Parameters.AddWithValue("@scpath", scPath);

                var resp = await sql.ExecuteQuery(command);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    items.Add(scName, scPath);
                    ShowItemStatus("INSERIDO!");
                }
                else
                    Master.ShowInfoMessage("Nenhum valor foi inserido");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private async void UpdateShortCut(object sender, EventArgs e)
        {
            string prompt = Prompt.ShowDialog("nome|NewPath", "Adicionar Atalho");

            if (Utilix.IsNullOrEmptyOrWhiteSpace(prompt))
                return;

            try
            {
                if (!prompt.Contains('|'))
                    throw new Exception("Necessário informar o pipe --> |");

                var values = prompt.Split('|');
                string scName = values[0];
                string scPath = values[1];

                if (!scPath.Contains(@"\"))
                    throw new Exception(@"O novo caminho deve conter contrabarra --> \");

                string sqlquery = $"UPDATE shortcuts SET shortCutPath = @scpath WHERE shortCutName = @scname";
                var command = new MySqlCommand(sqlquery, sql.Connection);
                command.Parameters.AddWithValue("@scname", scName);
                command.Parameters.AddWithValue("@scpath", scPath);

                var resp = await sql.ExecuteQuery(command);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    items.Add(scName, scPath);
                    ShowItemStatus("ATUALIZADO!");
                }
                else
                    Master.ShowInfoMessage("Nenhum valor foi atualizado");
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private async void RemoveShortCut(object sender, EventArgs e)
        {
            string shortCut = Prompt.ShowDialog("Nome do Atalho:", "Remover Atalho").Trim();

            if (Utilix.IsNullOrEmptyOrWhiteSpace(shortCut))
                return;

            if (Master.ShowQuestionMessage($"Deseja mesmo remover o atalho '{shortCut}'?") != DialogResult.Yes)
                return;

            try
            {
                if (!items.ContainsKey(shortCut))
                    throw new Exception($"O atalho {shortCut} não existe!");

                string sqlquery = $"DELETE FROM shortcuts WHERE shortCutName = '{shortCut}'";

                var resp = await sql.ExecuteQuery(sqlquery);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    items.Remove(shortCut);
                    ShowItemStatus("REMOVIDO");
                }
                else
                    Master.ShowInfoMessage("Nenhum item foi removido");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region Items
        private void ClearListItems()
        {
            cbbListItens.Items.Clear();
            cbbListItens.Items.Add("Selecione");
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            btnPickFolder.Enabled = false;
            btnPickFolder.Text = "AGUARDE...";
            this.ClearListItems();
            txtShowItem.Text = string.Empty;

            try
            {
                FolderBrowserDialog dialog = new();

                if (Utilix.IsNotNullOrEmptyOrWhiteSpace(txtFolderPath.Text))
                    dialog.SelectedPath = txtFolderPath.Text;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.FillItemsList(dialog.SelectedPath);
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
                this.ClearListItems();
                cbbListItens.Enabled = false;
                cbbFontSize.Enabled = false;
                txtFolderPath.Text = string.Empty;
            }

            btnPickFolder.Enabled = true;
            btnPickFolder.Text = "Escolher pasta";
        }

        private void FillItemsList(string path)
        {
            txtFolderPath.Text = path;
            folderPath = path;
            cbbListItens.Enabled = true;
            cbbFontSize.Enabled = true;

            var files = Directory.GetFiles(folderPath, "*.txt");

            foreach (string file in files)
            {
                cbbListItens.Items.Add(Path.GetFileNameWithoutExtension(file));
            }

            cbbListItens.SelectedIndex = 0;
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

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (Utilix.IsNotNullOrEmptyOrWhiteSpace(txtShowItem.Text))
            {
                Clipboard.SetText(txtShowItem.Text);
                Master.ShowQuickly(lblCopied);
            }
        }

        private void lblSearchText_MouseEnter(object sender, EventArgs e) => lblSearchText.Cursor = Cursors.Hand;
        private void lblSearchText_MouseLeave(object sender, EventArgs e) => lblSearchText.Cursor = Cursors.Default;
        private void lblSearchText_Click(object sender, EventArgs e)
        {
            if (Utilix.IsNullOrEmptyOrWhiteSpace(txtFolderPath.Text))
            {
                Master.ShowErrorMessage("Necessário informar um caminho para pesquisar itens!");
                return;
            }

            lblSearchText.Cursor = Cursors.Default;

            Global.Forms.TextSearcher.Dispose();
            Global.Forms.TextSearcher = new(SearcherType.FilePath, txtFolderPath.Text);

            Global.Forms.TextSearcher.SelectedText += PickSelectedText;

            Master.ShowScreen(Global.Forms.TextSearcher);
        }

        private void PickSelectedText(string selectedText)
        {
            int index = cbbListItens.Items.IndexOf(selectedText);
            cbbListItens.SelectedIndex = index;
        }

        private async void btnInsertItem_Click(object sender, EventArgs e)
        {
            insertingFile = true;
            btnInsertItem.Text = "Aguarde...";
            btnInsertItem.Enabled = false;

            try
            {
                if (cbbListItens.SelectedIndex > 0)
                    throw new Exception("Necessário que nenhum item esteja selecionado.");

                if (Utilix.IsNullOrEmptyOrWhiteSpace(txtFolderPath.Text))
                    throw new Exception("Pasta não selecionada!");

                if (Utilix.IsNullOrEmptyOrWhiteSpace(txtShowItem.Text))
                    throw new Exception("Texto do item está vazio.");

                SaveFileDialog fileHandler = new()
                {
                    Filter = "Arquivos de texto|*.txt",
                    Title = "Salvar arquivo de texto",
                    FileName = "Meu TXT",
                    InitialDirectory = folderPath
                };

                if (fileHandler.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.Combine(folderPath, fileHandler.FileName);
                    await File.WriteAllTextAsync(path, txtShowItem.Text);

                    string fileName = fileHandler.FileName[(fileHandler.FileName.LastIndexOf(@"\") + 1)..].Replace(".txt", string.Empty).Trim();

                    cbbListItens.Items.Add(fileName);

                    this.SortListItens(fileName);
                    lblInfoTxtChanged.Visible = false;

                    this.UpdateFilesCount(2);
                    this.ShowItemStatus("Inserido!");
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            insertingFile = false;
            btnInsertItem.Text = "Inserir Item";
            btnInsertItem.Enabled = true;
        }

        private async void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbListItens.SelectedIndex <= 0)
                    throw new Exception("Necessário selecionar um item para atualizar!");

                string path = this.GetCurrentFilePath();
                await File.WriteAllTextAsync(path, txtShowItem.Text);
                lblInfoTxtChanged.Visible = false;

                this.ShowItemStatus("Atualizado!");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void btnRenameItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbListItens.SelectedIndex <= 0)
                    throw new Exception("Nenhum item selecionado para renomear!");

                string newName = Utilix.SanitizeFileName(Prompt.ShowDialog("Novo nome:", "Renomear Arquivo") + ".txt");

                if (Utilix.IsNullOrEmptyOrWhiteSpace(newName))
                    throw new Exception("O arquivo precisa ter um nome!");

                string path = this.GetCurrentFilePath();
                string newPath = Path.Combine(folderPath, newName);

                var resp = PathHandler.MoveFile(path, newPath);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                int index = cbbListItens.SelectedIndex;
                cbbListItens.Items[index] = newName;

                this.SortListItens(newName);
                this.ShowItemStatus("Renomeado!");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbListItens.SelectedIndex <= 0)
                    throw new Exception("Necessário escolher um item para remover");

                if (Master.ShowQuestionMessage("Deseja mesmo remover o arquivo?", "Confirmação") != DialogResult.Yes)
                    return;

                string path = this.GetCurrentFilePath();

                if (!File.Exists(path))
                    throw new Exception("Arquivo inexistente!");

                File.Delete(path);

                int cbbindex = cbbListItens.SelectedIndex;
                cbbListItens.Items.RemoveAt(cbbindex);
                cbbListItens.SelectedIndex = 0;

                this.UpdateFilesCount(2);
                this.ShowItemStatus("Removido!");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void SortListItens(string fileNameToSelect)
        {
            cbbListItens.Items.RemoveAt(0);
            var sortedList = cbbListItens.Items.Cast<object>().OrderBy(i => i.ToString()).ToList();

            cbbListItens.Items.Clear();
            cbbListItens.Items.Add("Selecione");
            foreach (var item in sortedList)
            {
                cbbListItens.Items.Add(item);
            }

            int index = cbbListItens.Items.IndexOf(fileNameToSelect);
            cbbListItens.SelectedIndex = index;
        }

        private void cbbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtShowItem.Font = new Font("Segoe UI", float.Parse((sender as ComboBox).SelectedItem.ToString().Replace("pt", "")), txtShowItem.Font.Style, GraphicsUnit.Point);
            lblInfoTxtChanged.Visible = false;
            btnCopyToClipboard.Focus();
        }

        private async void cbbListItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbListItens.Items.Count > 0 && cbbListItens.SelectedIndex > 0 && !string.IsNullOrEmpty(folderPath) && !this.insertingFile)
            {
                try
                {
                    string path = this.GetCurrentFilePath();
                    txtShowItem.Text = await File.ReadAllTextAsync(path);
                    lblInfoTxtChanged.Visible = false;
                }
                catch (Exception ex)
                {
                    Master.ShowErrorMessage(ex.Message);
                }
            }

            if (cbbListItens.SelectedIndex == 0)
            {
                txtShowItem.Text = string.Empty;
                lblInfoTxtChanged.Visible = false;
            }
        }

        private void txtShowItem_TextChanged(object sender, EventArgs e)
        {
            lblInfoTxtChanged.Visible = true;
            if (Utilix.IsNullOrEmptyOrWhiteSpace(txtShowItem.Text))
            {
                cbbListItens.SelectedIndex = 0;
                txtShowItem.Focus();
            }
        }

        private string GetCurrentFilePath() => Path.Combine(folderPath, cbbListItens.SelectedItem.ToString() + ".txt");

        private void ShowItemStatus(string newStatus)
        {
            lblStatusInfo.Text = newStatus;
            Master.ShowQuickly(lblStatusInfo, 2000);
        }

        private void txtLocateText_TextChanged(object sender, EventArgs e)
        {
            string textLocate = (sender as TextBox).Text;

            if (textLocate.startswith("$") && textLocate.Length > 1)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    var item = items.GetItemByIndex(i);
                    if (textLocate.Replace("$", "") == item.Key)
                    {
                        string path = item.Value;
                        if (Directory.Exists(path))
                        {
                            this.ClearListItems();
                            this.FillItemsList(path);
                            this.UpdateFilesCount();

                            txtLocateText.Text = string.Empty;

                            break;
                        }
                    }
                }
            }
        }

        private void UpdateFilesCount(int subtractor = 1) => lblTitle.Text = $"Copiar itens de arquivos txt [{cbbListItens.Items.Count - subtractor} ARQUIVOS]";

        [Obsolete]
        private async void UploadToGoogleDocs_Click(object sender, EventArgs e)
        {
            btnUploadToGoogleDocs.Enabled = false;
            btnUploadToGoogleDocs.Text = "AGUARDE";
            btnUploadToGoogleDocs.BackColor = Color.LightSalmon;
            try
            {
                if (cbbListItens.SelectedIndex == 0 || cbbListItens.SelectedIndex == -1)
                    throw new Exception("Necessário escolher um item para exportar!");

                string filePath = this.GetCurrentFilePath();

                var service = await GoogleManager.GetDriveServiceAsync();

                if (!service.WasSuccessful)
                    throw new Exception(service.ResponseErr);

                var resp = await GoogleManager.UploadFileGoogleDocs(service.Response, filePath);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                this.ShowItemStatus($"Sincronizado [Id:{resp.Response}]");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
            btnUploadToGoogleDocs.Enabled = true;
            btnUploadToGoogleDocs.Text = "Sincronizar arquivo no Google Docs 🔄";
            btnUploadToGoogleDocs.BackColor = SystemColors.ActiveCaption;
        }

        private void tbarAutoRoll_Scroll(object sender, EventArgs e)
        {

        }

        private void scrollTimer_Tick(object sender, EventArgs e)
        {

        }
        #endregion        
    }
}
