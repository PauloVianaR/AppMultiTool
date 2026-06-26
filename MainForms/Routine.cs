using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppMultiTool.Utils;
using AppMultiTool.Models;
using MasterWindowsForms;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class Routine : Form
    {
        private readonly MasterMySQLService sql;
        private readonly List<ProcessItem> processItems;
        private const string corpEmail = "paulo@syncsoftwares.com.br";

        public Routine() 
        {
            InitializeComponent();
            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));
            processItems = [];

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            chbCloseAppAfter.Checked = bool.Parse(xml.GetValueByAddKey(AppKeys.CloseAfterCheckedDefaultRoutine).Response);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => Master.SwitchScreen(Global.Forms.MainMenu,this);
        private void Routine_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private async void Routine_Load(object sender, EventArgs e) => await ConnectBd();
        private void txtArgs_TextChanged(object sender, EventArgs e) => lblArgsInfo.Visible = true;

        private async Task ConnectBd()
        {
            try
            {
                string query = "SELECT * FROM routineprocess";

                var resp = await sql.ReadQuery(query);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                var listItems = resp.Response;

                if(listItems.Count > 0)
                {
                    listItems.ForEach(item => processItems.Add(new ProcessItem(item)));
                }

                processItems.ForEach(p => clsbProcess.Items.Add(p.Title, p.Using));

                lblLoading.Visible = false;
                lblArgsInfo.Visible = false;
                List<Button> buttons = Master.ListControls<Button>(this);
                Master.EnableControls<Button>(buttons);
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void btnSelectProcessPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog filehandler = new() { Filter = "Aplicativo Executável|*.exe" };

            if (filehandler.ShowDialog() == DialogResult.OK)
            {
                txtProcessPath.Text = filehandler.FileName;
            }
        }
        private void clsbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                if(!string.IsNullOrEmpty((sender as CheckedListBox)?.SelectedItem?.ToString()))
                {
                    ProcessItem pitem = processItems?.First(p => p?.Title == (sender as CheckedListBox)?.SelectedItem.ToString());

                    txtArgs.Text = pitem.Args;
                    txtProcessName.Text = pitem.Title;
                    txtProcessPath.Text = pitem.Path;
                }                
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
            lblArgsInfo.Visible = false;
        }

        private async void btnAttArgs_Click(object sender, EventArgs e)
        {
            ProcessItem pitem = processItems.First(p => p.Title == clsbProcess.SelectedItem.ToString());
            string sqlquery = $"UPDATE routineprocess SET arguments = '{txtArgs.Text.Trim()}' WHERE idroutineprocess = {pitem.ID};";
            
            if(pitem.Path != this.txtProcessPath.Text)
            {
                sqlquery += $"UPDATE routineprocess SET path = '{txtProcessPath.Text.Replace("\\", "\\\\")}' WHERE idroutineprocess = {pitem.ID};";
                pitem.Path = this.txtProcessPath.Text;
            }

            if (await UpdateItemSucess(sqlquery))
            {
                pitem.Args = txtArgs.Text.Trim();
                lblArgsInfo.Visible = false;
            }
        }

        private async void btnRenameProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProcessName.Text) || string.IsNullOrEmpty(txtProcessName.Text.Trim()))
                Master.ShowErrorMessage("Nome do processo não pode ser vazio!");
            else
            {
                ProcessItem pitem = processItems.First(p => p.Title == clsbProcess.SelectedItem.ToString());
                string sqlquery = $"UPDATE routineprocess SET processname = '{txtProcessName.Text.Trim()}' WHERE idroutineprocess = {pitem.ID}";

                if (await UpdateItemSucess(sqlquery))
                {
                    pitem.Title = txtProcessName.Text.Trim();
                    clsbProcess.Items[clsbProcess.SelectedIndex] = pitem.Title;
                }                    
            }
        }

        private async void clsbProcess_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(!lblLoading.Visible)
            {
                ProcessItem pitem = processItems.First(p => p.Title == clsbProcess.Items[e.Index].ToString());
                string sqlquery = $"UPDATE routineprocess SET active = {(int)e.NewValue} WHERE idroutineprocess = {pitem.ID}";

                if (await UpdateItemSucess(sqlquery))
                    pitem.Using = e.NewValue == CheckState.Checked;
            }            
        }

        private async Task<bool> UpdateItemSucess(string sqlquery)
        {
            bool sucess = false;
            try
            {
                var resp = await sql.ExecuteQuery(sqlquery);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    sucess = true;
                    ShowItemStatus("ATUALIZADO!");
                }
                else
                    Master.ShowInfoMessage("Nenhum item foi atualizado");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
            return sucess;
        }

        private async void btnInsertProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProcessName.Text) || string.IsNullOrEmpty(txtProcessName.Text.Trim()))
                    throw new Exception("Processo não selecionado para a adesão na rotina!");

                int nextID = 1;

                if (processItems.Count > 0)
                {
                    ProcessItem lastTC = processItems.OrderByDescending(tc => tc.ID).First();
                    nextID = lastTC.ID + 1;
                }

                string processname = string.IsNullOrWhiteSpace(txtProcessName.Text) || string.IsNullOrEmpty(txtProcessName.Text.Trim()) ? $"Processo {nextID}" : txtProcessName.Text;
                string path = txtProcessPath.Text;
                string args = txtArgs.Text;
                string sqlquery = $"INSERT INTO routineprocess(idroutineprocess,processname,path,arguments,active) VALUES ({nextID},'{processname}'," +
                    $"'{path.Replace("\\", "\\\\")}','{args}',1)";

                var resp = await sql.ExecuteQuery(sqlquery);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    ProcessItem pitem = new(nextID, processname, path, args);
                    processItems.Add(pitem);
                    clsbProcess.Items.Add(pitem.Title, pitem.Using);
                    clsbProcess.SelectedIndex = clsbProcess.Items.IndexOf(pitem.Title);
                    lblArgsInfo.Visible = false;

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

        private async void btnDeleteProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProcessName.Text) || string.IsNullOrEmpty(txtProcessName.Text.Trim()))
                    throw new Exception("Nenhum item selecionado para a remoção");

                var dr = Master.ShowQuestionMessage("Deseja mesmo remover o item?", "Atenção");
                if (dr == DialogResult.Yes)
                {
                    ProcessItem pitem = processItems.First(p => p.Title == clsbProcess.SelectedItem.ToString());
                    string sqlquery = $"DELETE FROM routineprocess WHERE idroutineprocess = {pitem.ID}";

                    var resp = await sql.ExecuteQuery(sqlquery);

                    if (!resp.WasSuccessful)
                        throw new Exception(resp.ResponseErr);

                    if (resp.Response > 0)
                    {
                        Master.ShowInfoMessage("Item removido com sucesso");

                        int index = clsbProcess.SelectedIndex;
                        processItems.Remove(pitem);
                        clsbProcess.Items.RemoveAt(index);

                        txtProcessName.Text = string.Empty;
                        txtProcessPath.Text = string.Empty;
                        txtArgs.Text = string.Empty;

                        lblArgsInfo.Visible = false;
                    }
                    else
                        Master.ShowInfoMessage("Nenhum item foi removido");
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void ShowItemStatus(string infomsg)
        {
            lblPItemStatus.Text = infomsg;
            lblPItemStatus.Visible = true;

            Task task = Task.Run(() => Thread.Sleep(1000));

            task.Wait();
            lblPItemStatus.Visible = false;
        }

        private void btnStartRoutine_Click(object sender, EventArgs e)
        {
            try
            {
                processItems.ForEach(p =>
                {
                    if (p.Using)
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = p.Path,
                            Arguments = p.Args,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        });
                    Thread.Sleep(150);
                });

                if(chbEmailCopy.Checked)
                    Clipboard.SetText(corpEmail);

                if (chbCloseAppAfter.Checked)
                {
                    Thread.Sleep(500);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void chbEmailCopy_CheckedChanged(object sender, EventArgs e) => lblEmailCopy.Visible = !chbEmailCopy.Checked;
        private void lblEmailCopy_MouseEnter(object sender, EventArgs e) => lblEmailCopy.Cursor = Cursors.Hand;
        private void lblEmailCopy_MouseLeave(object sender, EventArgs e) => lblEmailCopy.Cursor = Cursors.Default;

        private void lblEmailCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(corpEmail);
            lblEmailCopy.Cursor = Cursors.Default;
        }
    }
}
