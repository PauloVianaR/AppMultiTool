using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMultiTool.MainForms;

namespace AppMultiTool.RelatedForms
{
    public partial class LogErros : Form
    {
        public LogErros()
        {
            InitializeComponent();
        }
        public WppBot Wpp;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /*
            Wpp.Show();
            this.Hide();*/
        }

        public void preencheErros(string erro)
        {
            string msgerro;

            try
            {
                msgerro = string.Format($"{Environment.NewLine} {erro};");
                rtxtAnotacoesErros.Text += msgerro;
            }
            catch(Exception es)
            {
                msgerro = string.Format($"{Environment.NewLine} {es.Message};");
                rtxtAnotacoesErros.Text += msgerro;
            }
            
        }
        
        private void LogErros_TextChanged(object sender, EventArgs e)
        {
        }

        private void LogErros_Load(object sender, EventArgs e)
        {
            Wpp = new WppBot();
        }

        private void toolWpp_Click(object sender, EventArgs e)
        {

        }
    }
}
