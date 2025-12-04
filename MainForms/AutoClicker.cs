using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using MasterWindowsForms;
using Tesseract;
using AppMultiTool.Utils;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;
using System.Media;

namespace AppMultiTool.MainForms
{
    public partial class AutoClicker : Form
    {
        private CancellationTokenSource _cancellationTokenSource;
        private readonly System.Windows.Forms.Timer clickTimer;
        private string phraseToFind;
        private SoundPlayer soundConnected = new(Path.Combine(Global.MaterialPath, "SoundConnected.wav"));
        private SoundPlayer soundDisconnected = new(Path.Combine(Global.MaterialPath, "SoundDisconnected.wav"));

        public AutoClicker()
        {
            InitializeComponent();

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.InactivityMonitor.StopTimer();

            clickTimer = new();
            clickTimer.Tick += OnTimedEvent;
            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void BackToMainMenu(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            Master.SwitchScreen(Global.Forms.MainMenu, this);
        }

        private void AutoClicker_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void chkFindWordToClick_CheckedChanged(object sender, EventArgs e) => txtPhraseToFind.Visible = (sender as CheckBox).Checked;
        private void OnTimedEvent(object sender, EventArgs e) => ClickAtPosition(Cursor.Position);

        private void Start_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            Utilix.EnableControlColor(btnStop);
            chkFindWordToClick.Enabled = false;

            if (!chkFindWordToClick.Checked)
            {
                clickTimer.Interval = ((int)numIntervalValue.Value) * 1000;
                clickTimer.Start();
            }
            else
            {
                txtPhraseToFind.ReadOnly = true;
                phraseToFind = txtPhraseToFind.Text.Trim();
                txtPhraseToFind.Text = string.Empty;
                txtPhraseToFind.PlaceholderText = "BUSCANDO....";
                btnStop.Focus();

                string searchText = phraseToFind;
                _cancellationTokenSource = new CancellationTokenSource();
                Task.Run(() => StartCapture(searchText, _cancellationTokenSource.Token));
            }

            soundConnected.Play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {            
            Utilix.DisableControlColor(btnStop);
            btnStart.Enabled = true;
            chkFindWordToClick.Enabled = true;

            if (chkFindWordToClick.Checked)
            {
                _cancellationTokenSource?.Cancel();
                txtPhraseToFind.ReadOnly = false;
                txtPhraseToFind.Text = phraseToFind;
                txtPhraseToFind.PlaceholderText = string.Empty;
            }
            else
            {
                clickTimer.Stop();
            }

            soundDisconnected.Play();
        }

        private void StartCapture(string searchText, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Bitmap screenshot = CaptureScreen();
                Point? position = FindTextPosition(screenshot, searchText);

                if (position.HasValue)
                {
                    ClickAtPosition(position.Value);
                }

                Thread.Sleep(((int)numIntervalValue.Value) * 1000);
            }
        }

        private static Bitmap CaptureScreen()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap bitmap = new(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }

            return bitmap;
        }

        private static Point? FindTextPosition(Bitmap bitmap, string searchText)
        {
            string tesseract_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\net5.0-windows", ""), @"Material\Tesseract\tessdata_fast-main");

            using (var engine = new TesseractEngine(tesseract_path, "por", EngineMode.Default))
            {
                using (var img = PixConverter.ToPix(bitmap))
                {
                    using (var page = engine.Process(img))
                    {
                        var iterator = page.GetIterator();
                        iterator.Begin();

                        do
                        {
                            string text = iterator.GetText(PageIteratorLevel.Word);
                            if (text == searchText)
                            {
                                if (iterator.TryGetBoundingBox(PageIteratorLevel.Word, out var boundingBox))
                                {
                                    return new Point(boundingBox.X1, boundingBox.Y1);
                                }
                            }
                        } while (iterator.Next(PageIteratorLevel.Word));
                    }
                }
            }

            return null;
        }

        private void ClickAtPosition(Point position)
        {
            try
            {
                Cursor.Position = position;
                MachineController.MouseClickPosition(position);
            }
            catch(Exception ex)
            {
                Stop_Click(this, EventArgs.Empty);
                Master.ShowErrorMessage(ex.Message);
            }            
        }
    }

    public static class PixConverter
    {
        public static Pix ToPix(Bitmap bitmap)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                stream.Position = 0;
                return Pix.LoadFromMemory(stream.ToArray());
            }
        }
    }
}
