using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using MasterWindowsForms;
using AppMultiTool.Utils;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class DateCalculator : Form
    {
        public DateCalculator()
        {
            InitializeComponent();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void DateCalculator_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnCalcDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (numShortestHour.Value >= numLongestHour.Value)
                    throw new Exception("No intervalo de horas permitidas a hora da esquerda(menor) não pode ser maior ou igual à hora da direita(maior)!");

                DateTime currentDate = DateTime.Now;
                int hoursToAdd = (int)numHoursToAdd.Value;
                int hoursOfDay = (int)numDayHours.Value;

                int fullDays = hoursToAdd / hoursOfDay;
                int remainingHours = hoursToAdd % hoursOfDay;

                DateTime resultDate = currentDate.AddDays(fullDays).AddHours(remainingHours);

                if (chkSkipWeekend.Checked)
                {
                    double daysToAdd = resultDate.DayOfWeek == DayOfWeek.Saturday ? 2 : resultDate.DayOfWeek == DayOfWeek.Sunday ? 1 : 0;
                    resultDate = resultDate.AddDays(daysToAdd);
                }

                if (resultDate.Hour < numShortestHour.Value)
                {
                    DateTime newResultDate = new(resultDate.Year, resultDate.Month, resultDate.Day, Convert.ToInt32(numShortestHour.Value), 0, 0);
                    resultDate = newResultDate;
                }
                else if(resultDate.Hour > numLongestHour.Value)
                {
                    DateTime newResultDate = new(resultDate.Year, resultDate.Month, resultDate.Day, Convert.ToInt32(numLongestHour.Value), 0, 0);
                    resultDate = newResultDate;
                }

                string formattedResult = resultDate.ToString("dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm", new CultureInfo("pt-BR"));
                formattedResult = string.Concat(char.ToUpper(formattedResult[0]), formattedResult[1..],$"\n[{resultDate:g}]");

                txtDateResult.Text = formattedResult;
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }            
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            if (Utilix.IsNotNullOrEmptyOrWhiteSpace(txtDateResult.Text))
            {
                Clipboard.SetText(txtDateResult.Text);
                Master.ShowQuickly(lblCopiedText);
            }                
        }        
    }
}
