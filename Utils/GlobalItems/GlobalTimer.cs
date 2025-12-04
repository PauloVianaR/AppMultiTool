using AppMultiTool.Utils.Controllers;
using NPOI.OpenXmlFormats.Dml.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMultiTool.Utils.GlobalItems
{
    public class GlobalTimer
    {
        private readonly Timer timer;
        private readonly bool showTimeTitle = false;
        public event EventHandler UpdateTitleTime;

        public GlobalTimer()
        {
            timer = new()
            {
                Enabled = false,
                Interval = 1000
            };

            timer.Tick += TimerTick;

            try 
            {
                XMLHandler xml = new(CommonFile.AppSettings);
                var resp = xml.GetValueByAddKey(AppKeys.ShowRealTime);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                showTimeTitle = bool.Parse(resp.Response);
            }
            catch(Exception)
            {
                showTimeTitle = false;
            }                   
        }

        public void StartTimer()
        {
            if (showTimeTitle)
            {
                timer.Enabled = true;
                timer.Start();
            }
        }

        public void TimerTick(object sender, EventArgs e)
        {
            if(timer.Enabled)
                UpdateTitleTime.Invoke(this, EventArgs.Empty);
        }

        public void UpdateTitleTimeLabelForm(Label titleLabel)
        {
            string rawTitle = titleLabel.Text;

            if (titleLabel.Text.Contains(':'))
            {
                var originalTitle = new List<char>();
                for (int i = 0; i < titleLabel.Text.Length; i++)
                {
                    if (titleLabel.Text[i] == ':')
                        break;

                    originalTitle.Add(titleLabel.Text[i]);
                }

                originalTitle.RemoveAt(originalTitle.Count - 1);
                originalTitle.RemoveAt(originalTitle.Count - 1);
                originalTitle.RemoveAt(originalTitle.Count - 1);

                StringBuilder sb = new();
                foreach (char item in originalTitle)
                {
                    sb.Append(item);
                }

                rawTitle = sb.ToString();
            }

            string newTextLabel = $"{rawTitle} {DateTime.Now:HH:mm}";

            if (titleLabel.InvokeRequired)
            {
                titleLabel.Invoke(new Action(() => titleLabel.Text = newTextLabel));
            }
            else
            {
                titleLabel.Text = newTextLabel;
            }

        }
    }
}
