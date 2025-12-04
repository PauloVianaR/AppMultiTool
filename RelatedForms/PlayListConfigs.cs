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
using MySql.Data.MySqlClient;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.RelatedForms
{
    public partial class PlayListConfigs : Form
    {
        private readonly MasterMySQLService sql;
        private List<MasterItem> configs;

        public PlayListConfigs()
        {
            InitializeComponent();
            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));
            configs = new();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();
        private async void PlayListConfigs_Shown(object sender, EventArgs e) => await ConnectDB();

        private async Task ConnectDB()
        {
            try
            {
                string query = "SELECT * FROM playlistmaker_configs";
                var resp = await sql.ReadQuery(query);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                configs = resp.Response;

                for (int i = 0; i < configs.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            txtBasePath.Text = configs[i].Propertys;
                            break;
                        case 1:
                            numVolConfig.Value = Convert.ToInt32(configs[i].Propertys);
                            break;
                        case 2:
                            chbLoopPlaylist.Checked = configs[i].Propertys == "1";
                            break;
                        case 3:
                            chbRandomizePlaylist.Checked = configs[i].Propertys == "1";
                            break;
                    }
                }

                lblWaitConnect.Visible = false;
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void numVolConfig_ValueChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
            configs[1].Propertys = numVolConfig.Value.ToString();
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            btnPickFolder.Enabled = false;
            lblWaitPath.Enabled = true;
            btnSaveChanges.Enabled = true;

            FolderBrowserDialog fbd = new();
            fbd.SelectedPath = configs[0].Propertys;

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                configs[0].Propertys = fbd.SelectedPath;
                txtBasePath.Text = fbd.SelectedPath;
            }

            btnPickFolder.Enabled = true;
            lblWaitPath.Enabled = false;
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                btnSaveChanges.Enabled = false;

                string query1 = $"UPDATE playlistmaker_configs SET configvalue = '{txtBasePath.Text.Replace("\\","\\\\")}' WHERE idplaylistconfig = 1";
                string query2 = $"UPDATE playlistmaker_configs SET configvalue = '{numVolConfig.Value}' WHERE idplaylistconfig = 2";
                string query3 = $"UPDATE playlistmaker_configs SET configvalue = '{Utilix.ConvertBoolToInt(chbLoopPlaylist.Checked)}' WHERE idplaylistconfig = 3";
                string query4 = $"UPDATE playlistmaker_configs SET configvalue = '{Utilix.ConvertBoolToInt(chbRandomizePlaylist.Checked)}' WHERE idplaylistconfig = 4";

                List<string> querys = new() { query1, query2, query3, query4 };

                var resp = await sql.ExecuteTransactionQuerys(querys);
                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                Master.ShowQuickly(lblSaveCompleted);
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
                btnSaveChanges.Enabled = true;
            }
        }        
    }
}
