using AppMultiTool.Models;
using AppMultiTool.Utils;
using AppMultiTool.Utils.Controllers;
using AppMultiTool.Utils.GlobalItems;
using MasterWindowsForms;
using MySql.Data.MySqlClient;
using NPOI.HSSF.UserModel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace AppMultiTool.MainForms
{
    public partial class SpreadSheetConverter : Form
    {
        private readonly SSConverterModel controller = new();
        private readonly XMLHandler xml;
        private readonly MasterMySQLService sql;
        private readonly string defaultSeparator = "|";

        public SpreadSheetConverter()
        {
            InitializeComponent();

            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));
            xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            defaultSeparator = xml.GetValueByAddKey(AppKeys.DefaultSeparator).Response;

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void SpreadSheetConverter_Shown(object sender, EventArgs e)
        {
            var resp = xml.GetValueByAddKey(AppKeys.FontSizeDefault);

            string size = resp.WasSuccessful ? resp.Response : "11";
            int cbbindex = cbbFontSize.Items.IndexOf($"{size}pt");
            cbbFontSize.SelectedIndex = cbbindex;
            controller.WsContainsHeader = true;
            controller.CanHighLightWords = true;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Global.AllowCloseApp)
                this.Hide();
            else
                Master.SwitchScreen(Global.Forms.MainMenu, this);
        }

        private void SpreadSheetConverter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Global.AllowCloseApp)
                Application.Exit();
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            btnPickFolder.Enabled = false;
            btnPickFolder.Text = "AGUARDE...";

            OpenFileDialog folderPicker = new()
            {
                Filter = "Excel WorkSheet|*.xlsx;*.xls",
                Title = "Escolha a planilha",
                Multiselect = false
            };

            if (folderPicker.ShowDialog() == DialogResult.OK)
            {
                lblSelectWS.Text = string.Concat("Planilha Selecionada (", folderPicker.SafeFileName, ")");
                string filePath = folderPicker.FileName;
                
                if(Path.GetExtension(filePath) == ".xls")
                {
                    string newFilePath = Path.ChangeExtension(filePath, "xlsx");
                    filePath = ConvertToXLSX(filePath, newFilePath);
                }

                controller.Path = filePath;
                controller.WorkBookName = folderPicker.SafeFileName;
            }

            btnPickFolder.Enabled = true;
            btnPickFolder.Text = "Escolher arquivo";
        }

        private static string ConvertToXLSX(string xlsPath, string xlsxPath)
        {
            try
            {
                using var fs = new FileStream(xlsPath, FileMode.Open, FileAccess.Read);
                var hssfWorkbook = new HSSFWorkbook(fs);
                var sheet = hssfWorkbook.GetSheetAt(0);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using var package = new ExcelPackage();
                var ws = package.Workbook.Worksheets.Add(sheet.SheetName);

                for (int row = sheet.FirstRowNum; row <= sheet.LastRowNum; row++)
                {
                    var hssfRow = sheet.GetRow(row);
                    if (hssfRow == null) continue;

                    for (int col = hssfRow.FirstCellNum; col < hssfRow.LastCellNum; col++)
                    {
                        var cell = hssfRow.GetCell(col);
                        if (cell != null)
                        {
                            ws.Cells[row + 1, col + 1].Value = cell.ToString();
                        }
                    }
                }

                using var outStream = new FileStream(xlsxPath, FileMode.Create, FileAccess.Write);
                package.SaveAs(outStream);
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            return xlsxPath;
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilix.IsNullOrEmptyOrWhiteSpace(controller.Path))
                    throw new Exception("Arquivo não escolhido!");

                if (Utilix.IsNullOrEmptyOrWhiteSpace(txtCommand.Text))
                    throw new Exception("Comando SQL não definido!");

                if (Utilix.IsNullOrEmptyOrWhiteSpace(txtWorkSheetName.Text) && chkGetSheetName.Checked)
                    throw new Exception("A opção de especificar planilha está marcada no entanto a planilha em questão não foi especificada.");

                await ConvertToTxt();
            }
            catch(Exception ex)
            {
                string msg = ex.Message == "Sequence contains no matching element" ? "Planilha não identificada no arquivo." : ex.Message;
                Master.ShowErrorMessage(msg);
            }
        }

        private void btnResetNoValues_Click(object sender, EventArgs e) => Master.SwitchScreen(new SpreadSheetConverter(), this);

        private void lblShowFormats_Click(object sender, EventArgs e)
        {
            string msg = string.Concat("&NOMECÉLULA=TIPOFORMATAÇÃO. Exemplos:",
                "\n\n&A=INT      -> Result: A = 15",
                "\n&A=DECIMAL.      -> Result: A = 15.74",
                "\n&A=DECIMAL,      -> Result: A = 15,74",
                "\n&A=DATABR      -> Result: A = 20/04/2010",
                "\n&A=DATA      -> Result: A = 2010-04-20",
                "\n&A=FLOOR     -> Arredonda pra baixo, result = INT",
                "\n&A=CEILING   -> Arredonda pra cima, result = INT",
                "\n\nObs: formatos em texto não precisam ser explicitados na caixa de formatação.",
                $"\nObs 2: se for formatar em mais de uma célula então deve ser usado o separador padrão: '{defaultSeparator}'. Exemplo: &A=DECIMAL.{defaultSeparator}&B=INT");

            Master.ShowInfoMessage(msg,"Formatações Possíveis");
        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            if(chkHighLightSQL.Checked)
                Utilix.HighlightSyntax(sender as RichTextBox);
        }

        private void lblShowCommandExemple_Click(object sender, EventArgs e) => Master.ShowInfoMessage($"INSERT INTO table_name(COL1,COL2) VALUES({defaultSeparator}B{defaultSeparator},'{defaultSeparator}C{defaultSeparator}');","Exemplo de comando");
        private void chkVerifyHeader_CheckedChanged(object sender, EventArgs e)
        {
            bool ischecked = (sender as CheckBox).Checked;

            controller.WsContainsHeader = ischecked;
            numHeaderCount.Visible = ischecked;
            txtHowMuchHeader.Visible = ischecked;
        }        
        private void txtWorkSheetName_TextChanged(object sender, EventArgs e) => controller.WorkSheetName = chkGetSheetName.Checked ? txtWorkSheetName.Text : "*";

        private void chkHighLightSQL_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                Utilix.HighlightSyntax(txtCommand,true);
            else
                Utilix.HighlightSyntax(txtCommand);

            controller.CanHighLightWords = (sender as CheckBox).Checked;
        }

        private void chkGetSheetName_CheckedChanged(object sender, EventArgs e)
        {
            txtWorkSheetName.Visible = (sender as CheckBox).Checked;
            controller.CanGetWorkSheetName = (sender as CheckBox).Checked;
        }

        private void cbbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool canParse = int.TryParse(cbbFontSize.SelectedItem.ToString().Replace("pt",string.Empty), out int result);
            int size = canParse ? result : 11;

            txtCommand.Font = new Font(txtCommand.Font.FontFamily, size);
            txtCellFormat.Font = new Font(txtCellFormat.Font.FontFamily, size);
        }

        private async Task ConvertToTxt()
        {
            Color backcolor = btnConvert.BackColor;

            btnConvert.Enabled = false;
            btnConvert.Text = "Aguarde";
            btnConvert.BackColor = Color.Red;

            try
            {
                if (!txtCommand.Text.Contains(defaultSeparator))
                    throw new Exception($"O comando SQL precisar conter '{defaultSeparator}' ");

                List<string> sqlCommand = txtCommand.Text.Split(defaultSeparator).ToList();

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using ExcelPackage pkg = new(new FileInfo(controller.Path));
                var wb = pkg.Workbook;
                ExcelWorksheet worksheet = null;

                bool canOpenFinalFile = false;

                if (chkGetSheetName.Checked)
                {
                    worksheet = wb?.Worksheets?.FirstOrDefault(ws => ws.Name.ToUpper().Trim() == controller.WorkSheetName.ToUpper().Trim());
                    if (worksheet is null)
                        throw new Exception($"Planilha '{controller.WorkSheetName}' não encontrada.");
                }
                else
                {
                    if (wb.Worksheets.Count > 0)
                    {
                        worksheet = wb.Worksheets.ElementAt(0);
                    }
                    else
                    {
                        throw new Exception("Nenhuma planilha encontrada no arquivo Excel.");
                    }
                }

                SaveFileDialog fileHandler = new()
                {
                    Filter = "Arquivos de texto|*.txt",
                    Title = "Salvar arquivo convertido em texto",
                    FileName = "COMANDOS SQL"
                };

                if (fileHandler.ShowDialog() == DialogResult.OK)
                {
                    using StreamWriter writer = new(fileHandler.FileName);
                    try
                    {
                        int headercount = controller.WsContainsHeader ? (int)numHeaderCount.Value + 1 : 1;

                        for (int i = headercount; i <= worksheet.Dimension.Rows; i++)
                        {
                            StringBuilder sb = new();

                            for (int x = 0; x < sqlCommand.Count; x++)
                            {
                                string newValue = sqlCommand[x];
                                for (int j = 1; j <= worksheet.Dimension.Columns; j++)
                                {
                                    if (string.IsNullOrEmpty(worksheet?.GetValue(i, j)?.ToString()))
                                        continue;
                                    else
                                    {
                                        newValue = sqlCommand[x].Trim() == GetColumnName(j) ?
                                        string.IsNullOrEmpty(txtCellFormat.Text) ? worksheet.GetValue(i, j).ToString()
                                        : ValueConverted(worksheet.GetValue(i, j).ToString(), GetColumnName(j))
                                        : newValue;
                                    }
                                }

                                sb.Append(newValue);
                            }

                            writer.WriteLine(sb.ToString().Replace("| OfficeOpenXml.RowInternal |", string.Empty));
                        }

                        await LogCommand();

                        if (Master.ShowQuestionMessage("Arquivo criado com Êxito. Deseja já abrí-lo?", "Sucesso") == DialogResult.Yes)
                            canOpenFinalFile = true;

                        btnConvert.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Master.ShowErrorMessage(ex.Message);
                    }

                    writer?.Close();

                    if (canOpenFinalFile)
                        Process.Start("notepad.exe",fileHandler.FileName);
                }
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            btnConvert.Enabled = true;
            btnConvert.Text = "Converter";
            btnConvert.BackColor = backcolor;
            btnResetNoValues.ForeColor = Color.White;
        }

        private static string GetColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = string.Empty;
            int module;

            while (dividend > 0)
            {
                module = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + module).ToString() + columnName;
                dividend = (int)((dividend - module) / 26);
            }

            return columnName;
        }

        private string ValueConverted(string value,string columnName)
        {
            if (txtCellFormat.Text.Contains(defaultSeparator))
            {
                List<string> formats = txtCellFormat.Text.Split(defaultSeparator).ToList();
                string cellformat = formats.Find(f => f.Contains("&" + columnName));
                if (cellformat is not null)
                {
                    string format = cellformat[(cellformat.IndexOf("=") + 1)..].ToUpper().Trim();
                    value = string.Concat("&", columnName) == cellformat[..cellformat.IndexOf("=")] ? CastValue(value, format) : value;
                }
            }
            else
            {
                string cellformat = txtCellFormat.Text;
                string format = cellformat[(cellformat.IndexOf("=") + 1)..].ToUpper().Trim();

                value = string.Concat("&", columnName) == cellformat[..cellformat.IndexOf("=")] ? CastValue(value, format) : value;
            }

            return value;
        }

        private static string CastValue(string value,string format)
        {
            try
            {
                switch (format)
                {
                    case "INT":
                        if (int.TryParse(value.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out int newvalueINT))
                            value = newvalueINT.ToString();
                        break;
                    case "DECIMAL.":
                        value = value.Replace(".", "").Replace(",",".");
                        break;
                    case "DECIMAL,":
                        value = value.Replace(",", "").Replace(".",",");
                        break;
                    case "DATABR":
                        DateTime datebr = DateTime.Parse(value);
                        value = datebr.ToString("dd/MM/yyyy");
                        break;
                    case "DATA":
                        DateTime date = DateTime.Parse(value);
                        value = date.ToString("yyyy-MM-dd");
                        break;
                    case "FLOOR": double newvalue;
                        if (double.TryParse(value.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out newvalue))
                            value = Math.Floor(newvalue).ToString();
                        break;
                    case "CEILING":
                        if (double.TryParse(value.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out newvalue))
                            value = Math.Ceiling(newvalue).ToString("0");
                        break;
                }
            }
            catch (Exception) { }            

            return value;
        }

        private async Task LogCommand()
        {
            bool canlog = bool.Parse(xml.GetValueByAddKey(AppKeys.UseSpreedSheetConverterLogger).Response);
            if (!canlog)
            {
                await Task.CompletedTask;
                return;
            }

            try
            {
                string sqlquery = $"INSERT INTO log(route,log1,log2) VALUES (@route,@log1,@log2)";

                var command = new MySqlCommand(sqlquery, sql.Connection);
                command.Parameters.AddWithValue("@route", "SpreadSheetConverter");
                command.Parameters.AddWithValue("@log1", txtCommand.Text);
                command.Parameters.AddWithValue("@log2", txtCellFormat.Text);

                var resp = await sql.ExecuteQuery(command);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message,"Falha ao tentar salvar LOG");
            }
        }
    }
}
