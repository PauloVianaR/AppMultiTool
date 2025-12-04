using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using AppMultiTool.Utils;
using MySql.Data.MySqlClient;
using MasterWindowsForms;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.RelatedForms
{
    public partial class PlayListCreator : Form
    {
        private readonly MasterMySQLService sql;
        public PlayListCreator()
        {
            InitializeComponent();

            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));
            panelColorPanel.BackColor = Color.Black;

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var _color = panelColorPanel.BackColor;
                string plName = txtPlaylistName.Text;

                if (string.IsNullOrEmpty(plName) || string.IsNullOrWhiteSpace(plName))
                    throw new Exception("O nome da playlist não pode ser vazio!");

                string forecolor = string.Concat(_color.A.ToString(), "--", _color.R.ToString(), "--", _color.G.ToString(), "--", _color.B.ToString());

                string sqlquery = $"INSERT INTO playlists(name_pl,forecolor,path) SELECT '{plName}','{forecolor}',configvalue FROM playlistmaker_configs WHERE idplaylistconfig = 1";

                var resp = await sql.ExecuteQuery(sqlquery);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    Master.ShowInfoMessage("Playlist criada!");
                    Global.Forms.PlayListEditor = new(plName);

                    if (!Global.Forms.PlaylistMaker.IsDisposed)
                        Global.Forms.PlaylistMaker.Hide();

                    Master.SwitchScreen(Global.Forms.PlayListEditor, this);
                }
                else
                    Master.ShowInfoMessage("Nenhum valor foi inserido");
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message, "FALHA");
            }   
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDSelectColor.ShowDialog() == DialogResult.OK)
                panelColorPanel.BackColor = colorDSelectColor.Color;
        }
    }
}
