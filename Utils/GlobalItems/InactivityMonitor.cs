using AppMultiTool.Utils.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMultiTool.Utils.GlobalItems
{
    public class InactivityMonitor
    {
        private readonly Timer inactivityTimer;
        private int inactivityLimitInMinutes;
        public event EventHandler OnInactivityTimeout;

        public int InactivityLimitInMinutes
        {
            get => inactivityLimitInMinutes;
            set
            {
                inactivityLimitInMinutes = value;
                inactivityTimer.Interval = inactivityLimitInMinutes * 60 * 1000;
                ResetTimer();
            }
        }

        public InactivityMonitor()
        {
            inactivityLimitInMinutes = 5;

            try
            {
                XMLHandler xml = new(CommonFile.AppSettings);
                var resp = xml.GetValueByAddKey(AppKeys.InactivityTimeOut);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                inactivityLimitInMinutes = int.Parse(resp.Response);
            }
            catch (Exception)
            {
                inactivityLimitInMinutes = 5;
            }

            inactivityTimer = new();
            inactivityTimer.Interval = InactivityLimitInMinutes * 60 * 1000;
            inactivityTimer.Tick += InactivityTimer_Tick;
            inactivityTimer?.Start();
        }

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            inactivityTimer?.Stop();
            OnInactivityTimeout?.Invoke(this, EventArgs.Empty);
        }

        public void ResetTimer()
        {
            inactivityTimer?.Stop();

            try
            {
                XMLHandler xml = new(CommonFile.AppSettings);
                var resp = xml.GetValueByAddKey(AppKeys.UseTimeOut);

                if (!resp.WasSuccessful)
                    return;

                bool usetimeout = bool.Parse(resp.Response);
                if (!usetimeout)
                    return;

                inactivityTimer?.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StopTimer() => inactivityTimer?.Stop();
        public void StartTimer() => inactivityTimer?.Start();
    }
}
