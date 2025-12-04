using AppMultiTool;
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
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class Contador : Form
    {
        bool counting = false;
        public Contador()
        {
            InitializeComponent();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => Master.SwitchScreen(Global.Forms.MainMenu ,this);

        private void btnContar_Click(object sender, EventArgs e)
        {
            timerMy.Start();
            btnContar.Enabled = false;
            btnReset.Text = "PARAR";
            txtInput1.Enabled = false;
            txtInput2.Enabled = false;
            pgbBarra.Visible = true;

            counting = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (counting)
            {
                timerMy.Stop();
                counting = !counting;
                btnReset.Text = "Resetar";
            }
            else
            {
                lblTime.Text = "00:00:00";
                txtInput1.Text = "1";
                txtInput2.Text = "2";
                pgbBarra.Value = 0;
                pgbBarra.Visible = false;
                txtInput1.Enabled = true;
                txtInput2.Enabled = true;
                btnContar.Enabled = true;
            }
        }

        private void txtInput1_TextChanged(object sender, EventArgs e) => lblCurrentValue.Text = txtInput1.Text;

        private void timerMy_Tick(object sender, EventArgs e)
        {
            Invoke(new Action(() => 
            {
                if (pgbBarra.Value == pgbBarra.Maximum)
                {
                    timerMy.Stop();
                    btnContar.Enabled = true;
                    txtInput1.Enabled = true;
                    txtInput2.Enabled = true;
                    counting = !counting;
                    btnReset.Text = "Resetar";
                }
                else
                {
                    pgbBarra.Value++;
                    lblCurrentValue.Text = pgbBarra.Value.ToString();

                    TimeSpan ts = TimeSpan.FromSeconds(pgbBarra.Value);
                    lblTime.Text = string.Concat(ts.Hours.ToString("D2"), ":", ts.Minutes.ToString("D2"), ":", ts.Seconds.ToString("D2"));
                }

            }));
        }

        private void Contador_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void txtInput2_TextChanged(object sender, EventArgs e) => pgbBarra.Maximum = Convert.ToInt32(((TextBox)sender).Text);
    }
}
