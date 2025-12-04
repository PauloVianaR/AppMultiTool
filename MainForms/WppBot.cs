using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using AppMultiTool.RelatedForms;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils;
using MasterWindowsForms;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class WppBot : Form
    {
        public WppBot()
        {
            InitializeComponent();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        public ChromeDriver driver;
        public bool ChaveTel = false;
        public bool ChaveCont = false;
        public LogErros telaLogErros = new();
        private void button1_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
            string url = "https://web.whatsapp.com/";

            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.Maximize();

            txtContato.ReadOnly = false;
            txtMsg.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            chkUseCont.Enabled = true;
            chkUseTel.Enabled = true;
            btnEnviar.Visible = true;
            btnEnviar.Enabled = false;
            button1.Enabled = false;
        }

        private void chkUseTel_CheckedChanged(object sender, EventArgs e)
        {
            if(chkUseTel.Checked == true)
            {
                chkUseCont.Enabled = false;
                btnEnviar.Enabled = true;
                ChaveTel = true;
                ChaveCont = false;
            }
            else if(chkUseTel.Checked == false)
            {
                chkUseCont.Enabled = true;
                btnEnviar.Enabled = false;
                ChaveTel = false;
            }
        }

        private void chkUseCont_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseCont.Checked == true)
            {
                chkUseTel.Enabled = false;
                btnEnviar.Enabled = true;
                ChaveCont = true;
                ChaveTel = false;
            }
            else if (chkUseCont.Checked == false)
            {
                chkUseTel.Enabled = true;
                btnEnviar.Enabled = false;
                ChaveCont = false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string cont = txtContato.Text;
            string tel = txtTelefone.Text;
            string msg = txtMsg.Text;

            string[] contatos = cont.Split(',', StringSplitOptions.RemoveEmptyEntries);

            if (ChaveCont == true && ChaveTel == false)
                EnviaMSGContato(contatos,msg);
            else if (ChaveCont == false && ChaveTel == true)
                EnviaMSGTel(tel,msg);
            else
                MessageBox.Show("Selecione a opção de 'Usar Contato' ou 'Usar Telefone'!",
                    "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        public void EnviaMSGContato(string[] contatos, string msg)
        {
            Thread.Sleep(500);

            var pesq = driver.FindElement(By.ClassName("_28-cz"));
            var digit = driver.FindElement(By.ClassName("_13NKt"));

            for (int i = 0; i < contatos.Length; i++)
            {
                try
                {
                    pesq.Click();

                    Thread.Sleep(500);

                    digit.SendKeys(contatos[i]);

                    Thread.Sleep(1000);

                    digit.SendKeys(OpenQA.Selenium.Keys.Enter);

                    Thread.Sleep(2000);

                    var digitemsg = driver.FindElement(By.CssSelector("._1UWac._1LbR4"));

                    Thread.Sleep(1000);

                    digitemsg.SendKeys(msg);

                    Thread.Sleep(2500);

                    var enviar = driver.FindElement(By.CssSelector("._3HQNh._1Ae7k"));
                    enviar.Click();
                    
                }
                catch (Exception ext)
                {
                    telaLogErros.preencheErros(("Whastbot Erro EnviaMSGContato: " + ext.Message).ToString());
                }
                finally
                {
                    Thread.Sleep(1000);
                }
            }            
        }

        public void EnviaMSGTel(string tel, string msg)
        {
            //Thread.Sleep(1000);

            MessageBox.Show("Work in process (WIP), select other option","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (driver != null)
                driver.Quit();
            else
                Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /*if(telaLogErros.Visible == false)
                telaLogErros.Show();*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //telaLogErros = new LogErros();
        }

        private void toolLogErros_Click(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Text == "Voltar")
            {
                MasterWindowsForms.Master.SwitchScreen(Global.Forms.MainMenu,this);
            }
            else if (((ToolStripMenuItem)sender).Text == "Log Erros")
            {
                telaLogErros.Show();
            }
        }
    }
}
