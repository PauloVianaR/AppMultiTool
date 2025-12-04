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
using NReco.VideoConverter;
using AppMultiTool.Utils;
using NAudio.Wave;
using NAudio.Lame;
using System.IO;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class MediaConverter : Form
    {
        int timesCutted = 1;
        string originalpath = string.Empty;
        string exitpath = string.Empty;
        string format = string.Empty;
        string originalfilename = string.Empty;
        readonly string[] videoFormats = { "Selecione", "MP4", "AVI", "MKV", "MOV", "WMV" };
        readonly string[] audioFormats = { "Selecione", "MP3", "WAV", "M4A", "AIFF", "AAC", "FLAC" };

        public MediaConverter()
        {
            InitializeComponent();
            cbbFormatPicker.SelectedIndex = 0;
            cbbConversionType.SelectedIndex = 0;

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            exitpath = xml.GetValueByAddKey(AppKeys.DefaultDownloadFolderPath).Response + @"\";
            ChangeExitPath(exitpath);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        private void VideoConverter_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => Master.SwitchScreen(Global.Forms.MainMenu, this);

        private void btnGetVideoToConvert_Click(object sender, EventArgs e)
        {
            btnGetVideoToConvert.Enabled = false;
            btnGetVideoToConvert.Text = "Aguarde...";

            OpenFileDialog fd = new()
            {
                Filter = "Arquivo de áudio|*.mp3;*.wav;*.ogg;*.m4a;*.aiff;*.flac;*.aac;*.mpeg|Arquivo de vídeo|*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.flv;*.webm",
                Title = $"Escolher arquivo de {(cbbConversionType.SelectedIndex == 3 ? "áudio" : "vídeo")}",
                Multiselect = false
            };            

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string foldername = fd.FileName.Split(@"\").Last();
                lblFolderName.Text = foldername;
                originalpath = fd.FileName;
                originalfilename = fd.SafeFileName;
                ChangeExitPath(fd.FileName.Replace(foldername, ""));
            }

            btnGetVideoToConvert.Enabled = true;
            btnGetVideoToConvert.Text = "Escolher arquivo";
        }

        private void btnSwitchExitPath_Click(object sender, EventArgs e)
        {
            btnSwitchExitPath.Enabled = false;
            btnSwitchExitPath.Text = "Aguarde...";

            if (fbdExitPathPicker.ShowDialog() == DialogResult.OK)
            {
                exitpath = fbdExitPathPicker.SelectedPath;
                ChangeExitPath(exitpath + @"\");
            }

            btnSwitchExitPath.Enabled = true;
            btnSwitchExitPath.Text = "Alterar caminho de saída";
        }

        private void ChangeExitPath(string newpath)
        {
            exitpath = newpath;
            txtExitPath.Text = exitpath;
        }

        private void PickMediaFormat(object sender, EventArgs e)
        {
            string selectedformat = (sender as ComboBox)?.SelectedItem.ToString().ToUpper().Trim();
            int selectedIndex = ((ComboBox)sender).SelectedIndex;

            if (originalpath == string.Empty)
                cbbFormatPicker.SelectedIndex = 0;
            else
            {
                lblObsFormat.Visible = selectedformat == GetFolderFormat() && !ckbCutAudio.Checked;
                format = selectedformat;
            }
        }

        private void PickConversionType(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    format = string.Empty;
                    break;
                case 1:
                    ChangeMediaFormats(false);
                    break;
                case 2:
                    ChangeMediaFormats(true);
                    break;
                case 3:
                    ChangeMediaFormats(true);
                    break;
            }
        }

        private string GetFolderFormat() => originalpath.Split(".").Last().ToString().ToUpper().Replace(".", "").Trim();

        private TimeSpan ConvertToSeconds(string time) => TimeSpan.ParseExact(time, @"m\:ss", null);
        private bool CanConvertSeconds(string time) => TimeSpan.TryParseExact(time, @"m\:ss", null, out TimeSpan _);

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Color btnColor = btnConvert.BackColor;
            btnConvert.BackColor = Color.Red;
            btnConvert.Text = "AGUARDE";
            btnConvert.Enabled = false;            

            try
            {
                if (string.IsNullOrEmpty(originalpath))
                    throw new Exception("Arquivo não escolhido!");

                if (string.IsNullOrEmpty(exitpath))
                    throw new Exception("Caminho de saída não escolhido!");

                string newFilePath = string.Empty;

                if (ckbCutAudio.Checked)
                {
                    if (!string.Equals(Path.GetExtension(originalpath).ToString().ToUpper(), ".MP3"))
                        throw new Exception("Só é possível editar arquvios '.mp3'");

                    if (rdbDuration.Checked && numDuration.Value == 0)
                        throw new Exception("O valor de duração não pode ser 0!");

                    if (!this.CanConvertSeconds(txtStartTime.Text))
                        throw new Exception("O formato do tempo inicial deve ser -> 00:00");

                    if(rdbFinalTime.Checked && !this.CanConvertSeconds(txtFinalTime.Text))
                        throw new Exception("O formato do tempo final deve ser -> 00:00");

                    var startTime = this.ConvertToSeconds(txtStartTime.Text);
                    var duration = rdbDuration.Checked ? TimeSpan.FromSeconds((double)numDuration.Value) : this.ConvertToSeconds(txtFinalTime.Text);

                    string newFileName = Utilix.SanitizeFileName(originalfilename.Split(".").First().ToString() + $" (CONVERTIDO) - {timesCutted}");
                    newFilePath = string.Concat(exitpath, newFileName, ".mp3");

                    if (File.Exists(newFilePath))
                        throw new Exception($"Já existe um arquivo com o nome {newFileName}");

                    this.CutAndSaveMp3(originalpath, newFilePath, startTime, duration);
                    timesCutted++;
                }
                else
                {
                    if (cbbFormatPicker.SelectedItem.ToString().ToUpper().Trim() == this.GetFolderFormat())
                        throw new Exception("O novo formato deve ser diferente do atual");

                    newFilePath = string.Concat(exitpath, Utilix.SanitizeFileName(originalfilename.Split(".").First().ToString()), ".", format.ToLower());
                    var converter = new FFMpegConverter();
                    converter.ConvertMedia(originalpath, newFilePath, format.ToLower());
                }

                Master.ShowInfoMessage("Arquivo convertido com sucesso", "Pronto!");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            btnConvert.BackColor = btnColor;
            btnConvert.Text = "CONVERTER";
            btnConvert.Enabled = true;
        }

        private void ChangeMediaFormats(bool convertToAudio)
        {
            cbbFormatPicker.Items.Clear();
            cbbFormatPicker.Items.AddRange(convertToAudio ? audioFormats : videoFormats);
            cbbFormatPicker.SelectedIndex = 0;
            format = string.Empty;
            lblObsFormat.Visible = false;
        }

        public void CutAndSaveMp3(string inputFilePath, string outputFilePath, TimeSpan startTime, TimeSpan duration)
        {
            using var reader = new AudioFileReader(inputFilePath);
            int startSample = (int)(startTime.TotalSeconds * reader.WaveFormat.SampleRate * reader.WaveFormat.Channels);
            int samplesToRead = (int)(duration.TotalSeconds * reader.WaveFormat.SampleRate * reader.WaveFormat.Channels);

            // Buffer para leitura de samples
            var buffer = new float[reader.WaveFormat.SampleRate * reader.WaveFormat.Channels];
            var byteBuffer = new byte[buffer.Length * sizeof(float)]; // Converte float para byte

            using var writer = new LameMP3FileWriter(outputFilePath, reader.WaveFormat, LAMEPreset.STANDARD);
            reader.Position = startSample * sizeof(float);

            while (samplesToRead > 0)
            {
                int samplesRead = reader.Read(buffer, 0, Math.Min(buffer.Length, samplesToRead));
                if (samplesRead == 0) break;

                // Converte float[] para byte[]
                Buffer.BlockCopy(buffer, 0, byteBuffer, 0, samplesRead * sizeof(float));
                writer.Write(byteBuffer, 0, samplesRead * sizeof(float));

                samplesToRead -= samplesRead;
            }
        }

        private void ckbCutAudio_CheckedChanged(object sender, EventArgs e)
            => lblObsFormat.Visible = !ckbCutAudio.Checked && cbbFormatPicker.SelectedItem.ToString().ToUpper().Trim() == this.GetFolderFormat();

        private void numDuration_ValueChanged(object sender, EventArgs e) => ckbCutAudio.Checked = true;

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDuration.Checked)
            {
                lblDuration.Text = "Duração (s):";
                numDuration.Visible = true;
                txtFinalTime.Visible = false;
                return;
            }

            if (rdbFinalTime.Checked)
            {
                lblDuration.Text = "Cortar até (m:s):";
                numDuration.Visible = false;
                txtFinalTime.Visible = true;
                return;
            }
        }
    }
}
