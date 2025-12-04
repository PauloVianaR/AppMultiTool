using System;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMultiTool.Utils;
using AppMultiTool.RelatedForms;
using AppMultiTool.Models;
using MasterWindowsForms;
using SharpDX.DirectInput;
using NAudio.Wave;
using NAudio.Dsp;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class JoyStickController : Form
    {
        private readonly JoyStickControllerModel control;
        private readonly XMLHandler xml;

        #region Main

        public JoyStickController()
        {
            InitializeComponent();

            xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            control = new();
            control.ConnectionChanged += ChangeColorConnectionLabel;
            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);

            lsbSites.SelectedIndex = 0;
            cbbLTModo.SelectedIndex = 0;
            cbbDeviceType.SelectedIndex = 0;
        }

        private void VoltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(control.JoyConnected)
                DisposeProcedure();

            Master.SwitchScreen(Global.Forms.MainMenu, this);
        }

        private void ConfigsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(control.IsProcessingAudio || control.KeepRunning)
            {
                Master.ShowErrorMessage("Não é possível acessar as configurações com o dispositivo conectado!");
                return;
            }

            if (Global.Forms.JoyStickConfigs.IsDisposed)
                Global.Forms.JoyStickConfigs = new();

            Master.ShowScreen(Global.Forms.JoyStickConfigs);
        }

        private void JoyStickController_FormClosing(object sender, FormClosingEventArgs e) => DisposeProcedure();
        private void JoyStickController_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void ShowLTModoInfo_MouseHover(object sender, EventArgs e) 
            => Master.ShowInfoMessage("Use RB para aumentar e LB para diminiuir em qualquer modo escolhido!", "INFORMAÇÃO");

        private void ChangeColorConnectionLabel(object sender, EventArgs e)
        {
            if (control.JoyConnected)
            {
                lblConectionStatus.Text = "Conectado";
                lblConectionStatus.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblConectionStatus.Text = "Desconectado";
                lblConectionStatus.ForeColor = Color.DarkRed;
            }
        }

        private void CBBDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            control.JoyType = (JoystickType)cbbDeviceType.SelectedIndex;
            var joytype = control.JoyType;

            switch (joytype)
            {
                case JoystickType.XboxJoystick:
                    lblSensibiltyThreshold.Text = "Sensibilidade";
                    numSensibility.Value = 25;
                    numSensibility.Increment = 10;
                    numSensibility.Minimum = 10;
                    break;
                case JoystickType.MusicalInstrument:
                    lblSensibiltyThreshold.Text = "Limiar Vol.:";
                    numSensibility.Value = 210;
                    numSensibility.Increment = 1;
                    numSensibility.Minimum = 1;
                    break;
            }

            int newWidth = cbbDeviceType.SelectedIndex == 0 ? 355 : 664;
            int height = this.Height;
            this.MaximumSize = new(newWidth, height);
            this.Width = newWidth;
        }
        #endregion

        #region Joystick
        private void Initializecontrol()
        {
            control.DirectInput = new();
            var JoystickGuid = Guid.Empty;

            try
            {
                foreach (var deviceInstance in control.DirectInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                    JoystickGuid = deviceInstance.InstanceGuid;

                if (JoystickGuid == Guid.Empty)
                    foreach (var deviceInstance in control.DirectInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                        JoystickGuid = deviceInstance.InstanceGuid;

                if (JoystickGuid != Guid.Empty)
                {
                    control.Joystick = new(control.DirectInput, JoystickGuid);

                    foreach (var deviceObject in control.Joystick.GetObjects())
                    {
                        if ((deviceObject.ObjectId.Flags & DeviceObjectTypeFlags.Axis) != 0)
                            control.Joystick.GetObjectPropertiesById(deviceObject.ObjectId).Range = new(-1000, 1000);
                    }

                    control.Joystick.Properties.BufferSize = 128;
                    control.Joystick.Acquire();
                    control.JoyConnected = true;                    
                }
                else
                {
                    Master.ShowErrorMessage("Nenhum controle foi encontrado! \nVerifique a conexão do mesmo com o computador.", "FALHA AO ENCONTRAR CONTROLE");
                    control.JoyConnected = false;
                }              
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
                control.JoyConnected = false;
            }
            finally
            {
                lblUnconnectedMsg.Visible = !control.JoyConnected;
            }
        }

        private void PollJoystick()
        {
            while (control.KeepRunning)
            {
                control.Joystick.Poll();
                var datas = control.Joystick.GetBufferedData();
                foreach (var state in datas)
                {
                    // Left Joystick
                    if (state.Offset == JoystickOffset.X || state.Offset == JoystickOffset.Y)
                        this.BeginInvoke(new Action<JoystickUpdate>(MoveMouse),state);

                    //Right Joystick
                    if (state.Offset == JoystickOffset.RotationY)
                    {
                        int scrollValue = state.Value;

                        if (scrollValue < -200)
                            MachineController.ScrollScreen(Direction.Up);
                        else if (scrollValue > 200)
                            MachineController.ScrollScreen(Direction.Down);
                    }

                    //D-PAD
                    if(state.Offset == JoystickOffset.PointOfViewControllers0)
                    {
                        switch (state.Value)
                        {
                            case 0: //UP
                                this.BeginInvoke(new Action<bool>(NextSite), false);
                                break;
                            case 9000: // RIGHT
                                MachineController.PressKey(Keys.Right);
                                break;
                            case 18000: // DOWN
                                this.BeginInvoke(new Action<bool>(NextSite), true);
                                break;
                            case 27000: // LEFT
                                MachineController.PressKey(Keys.Left);
                                break;
                        }
                    }

                    if(state.Offset == JoystickOffset.Z && state.Value == -996) // Button RT
                        MachineController.PressKey(Keys.F5);

                    if (state.Offset == JoystickOffset.Z && state.Value == 996) // Button LT
                        this.BeginInvoke(new Action(SwitchLTMode));

                    if (state.Value == 128)
                    {
                        switch (state.Offset)
                        {
                            case JoystickOffset.Buttons0: // Button A
                                MachineController.MouseClickDown(MouseClickType.LeftClick);
                                break;
                            case JoystickOffset.Buttons1: // Button B
                                MachineController.PressKey(Keys.Escape);
                                break;
                            case JoystickOffset.Buttons2: // Button X
                                MachineController.MouseClickDown(MouseClickType.RightClick);
                                break;
                            case JoystickOffset.Buttons3: // Button Y
                                this.BeginInvoke(new Action(OpenBrowser));
                                break;
                            case JoystickOffset.Buttons4: // Button LB
                                this.BeginInvoke(new Action<bool>(HandlerLTMode), false);
                                break;
                            case JoystickOffset.Buttons5: // Button RB
                                this.BeginInvoke(new Action<bool>(HandlerLTMode), true);
                                break;
                            case JoystickOffset.Buttons6: // Button Back
                                MachineController.PressKey(Keys.BrowserBack);
                                break;
                            case JoystickOffset.Buttons7: // Button Start
                                MachineController.PressKey(Keys.MediaPlayPause);
                                break;
                            case JoystickOffset.Buttons8: // Left Joystick Click
                                MachineController.PressControlPlusKey(Keys.F4);
                                break;
                            case JoystickOffset.Buttons9: //Right Joystick Click
                                MachineController.PressKey(Keys.F11);
                                break;
                        }
                    }
                    else if(state.Value == 0)
                    {
                        switch (state.Offset)
                        {
                            case JoystickOffset.Buttons0: // Button A
                                MachineController.MouseClickUp(MouseClickType.LeftClick);
                                break;
                            case JoystickOffset.Buttons2: // Button X
                                MachineController.MouseClickUp(MouseClickType.RightClick);
                                break;
                        }
                    }
                }
                ApplySmoothMovement();
                Thread.Sleep(20);
            }
        }

        private void MoveMouse(JoystickUpdate state)
        {
            control.MouseSpeed = (int)numSensibility.Value;

            control.TargetX = state.Offset == JoystickOffset.X ? (state.Value / 1000.0f) * control.MouseSpeed : control.TargetX;
            control.TargetY = state.Offset == JoystickOffset.Y ? (state.Value / 1000.0f) * control.MouseSpeed : control.TargetY;
        }

        private void ApplySmoothMovement()
        {
            control.CurrentX += (control.TargetX - control.CurrentX) * control.SmoothingFactor;
            control.CurrentY += (control.TargetY - control.CurrentY) * control.SmoothingFactor;

            Cursor.Position = new Point(Cursor.Position.X + (int)control.CurrentX, Cursor.Position.Y + (int)control.CurrentY);
        }

        #endregion

        #region MusicalInstrument

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e) => control.AudioBuffer = e.Buffer;

        private void WaveTimer_Tick(object sender, EventArgs e)
        {
            if (!control.IsProcessingAudio)
            {
                Task.Run(() => DetectNoteFromAudio(control.AudioBuffer));
            }
        }

        private int GetAudioDeviceNumber()
        {
            try
            {
                var resp = xml.GetValueByAddKey(AppKeys.JoyStickDeviceName);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                string deviceName = resp.Response;

                for (int device = 0; device < WaveIn.DeviceCount; device++)
                {
                    var capabilities = WaveIn.GetCapabilities(device);
                    if (capabilities.ProductName.Contains(deviceName))
                    {
                        return device;
                    }
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private void DetectNoteFromAudio(byte[] buffer)
        {
            if (control.IsProcessingAudio || buffer is null)
                return;

            control.IsProcessingAudio = true;

            float volumeThreshold = (float)numSensibility.Value / 100.00f;
            float totalVolume = 0;
            int fftSize = 0;

            switch (control.ChannelType)
            {
                case ChannelType.Mono:
                    fftSize = buffer.Length / 2; // 2 bytes por amostra
                    for (int i = 0; i < fftSize; i++)
                    {
                        float sample = (float)(buffer[2 * i] | (buffer[2 * i + 1] << 8)) / 32768.0f;
                        totalVolume += Math.Abs(sample);
                    }
                    totalVolume /= fftSize;
                    break;

                case ChannelType.Stereo:
                    fftSize = buffer.Length / 4; // 4 bytes por amostra (2 bytes por canal)
                    for (int i = 0; i < fftSize; i++)
                    {
                        float sampleLeft = (float)(buffer[4 * i] | (buffer[4 * i + 1] << 8)) / 32768.0f;
                        float sampleRight = (float)(buffer[4 * i + 2] | (buffer[4 * i + 3] << 8)) / 32768.0f;
                        totalVolume += (Math.Abs(sampleLeft) + Math.Abs(sampleRight)) / 2.0f;
                    }
                    totalVolume /= fftSize;
                    break;
            }

            if (totalVolume < volumeThreshold)
            {
                control.IsProcessingAudio = false;
                return;
            }

            Complex[] fftBuffer = new Complex[fftSize];
            switch (control.ChannelType)
            {
                case ChannelType.Mono:
                    for (int i = 0; i < fftSize; i++)
                    {
                        float sample = (float)(buffer[2 * i] | (buffer[2 * i + 1] << 8)) / 32768.0f;
                        fftBuffer[i] = new Complex { X = sample, Y = 0 };
                    }
                    break;

                case ChannelType.Stereo:
                    for (int i = 0; i < fftSize; i++)
                    {
                        float sampleLeft = (float)(buffer[4 * i] | (buffer[4 * i + 1] << 8)) / 32768.0f;
                        float sampleRight = (float)(buffer[4 * i + 2] | (buffer[4 * i + 3] << 8)) / 32768.0f;
                        float sample = (sampleLeft + sampleRight) / 2.0f;
                        fftBuffer[i] = new Complex { X = sample, Y = 0 };
                    }
                    break;
            }

            FastFourierTransform.FFT(true, (int)Math.Log(fftSize, 2.0), fftBuffer);

            float[] magnitudes = new float[fftSize / 2];
            for (int i = 0; i < magnitudes.Length; i++)
            {
                magnitudes[i] = (float)Math.Sqrt(fftBuffer[i].X * fftBuffer[i].X + fftBuffer[i].Y * fftBuffer[i].Y);
            }

            int maxIndex = 0;
            for (int i = 1; i < magnitudes.Length; i++)
            {
                if (magnitudes[i] > magnitudes[maxIndex])
                {
                    maxIndex = i;
                }
            }

            float frequency = maxIndex * control.SampleRate / fftSize;
            string newNote = GetNoteFromFrequency(frequency);

            if (!string.IsNullOrEmpty(newNote))
            {
                control.DetectedNote = newNote;
                lsbPlayedNotes.BeginInvoke(new Action(() => lsbPlayedNotes.Items.Add(control.DetectedNote)));

                if (lsbPlayedNotes.Items.Count >= 32)
                {
                    BeginInvoke(new Action<object, EventArgs>(btnStop_Click), this, EventArgs.Empty);
                    return;
                }
            }

            control.IsProcessingAudio = false;
        }

        private static string GetNoteFromFrequency(float frequency)
        {
            string[] noteNames = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B" };
            double[] noteFrequencies = new double[120];

            for (int i = 0; i < noteFrequencies.Length; i++)
            {
                noteFrequencies[i] = 440.0 * Math.Pow(2, (i - 69) / 12.0);
            }

            int closestNoteIndex = 0;
            for (int i = 0; i < noteFrequencies.Length; i++)
            {
                if (Math.Abs(frequency - noteFrequencies[i]) < Math.Abs(frequency - noteFrequencies[closestNoteIndex]))
                {
                    closestNoteIndex = i;
                }
            }

            int octave = closestNoteIndex / 12;
            string noteName = noteNames[closestNoteIndex % 12];

            return $"{noteName} {octave}";
        }


        #endregion

        #region MachineController

        private void OpenBrowser()
        {
            FavSites sites = new();
            string url = sites.GetURL(lsbSites.SelectedIndex);

            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void NextSite(bool todown)
        {
            int selectedIndex = lsbSites.SelectedIndex;
            int verticalFactor = todown ? 1 : -1;

            if (selectedIndex != -1)
            {
                lsbSites.SelectedIndex = !todown && lsbSites.SelectedIndex == 0 ? lsbSites.Items.Count - 1 : (selectedIndex + verticalFactor) % lsbSites.Items.Count;
            }

            control.SoundClick.Play();
        }

        private void SwitchLTMode()
        {
            int nextIndex = cbbLTModo.SelectedIndex + 1 >= cbbLTModo.Items.Count ? 0 : cbbLTModo.SelectedIndex + 1;
            cbbLTModo.SelectedIndex = nextIndex;

            btnStop.Focus();
        }

        private void HandlerLTMode(bool increase)
        {
            LTModo modo = (LTModo)cbbLTModo.SelectedIndex;

            switch (modo)
            {
                case LTModo.VolumeControl:
                    Keys key = increase ? Keys.VolumeUp : Keys.VolumeDown;
                    MachineController.PressKey(key);
                    break;
                case LTModo.SensibilityControl:
                    HandlerSensibility(increase);
                    break;
            }
        }

        private void HandlerSensibility(bool increase)
        {
            if (increase)
                numSensibility.Value = numSensibility.Value < 1000 ? numSensibility.Value += 5 : numSensibility.Value;
            else
                numSensibility.Value = numSensibility.Value > 10 ? numSensibility.Value -= 5 : numSensibility.Value;
        }

        #endregion

        #region StartStop

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                switch (control.JoyType)
                {
                    case JoystickType.XboxJoystick:

                        this.Initializecontrol();

                        if (control.JoyConnected)
                        {
                            control.KeepRunning = true;
                            control.PollingThread = new(PollJoystick);
                            control.PollingThread.IsBackground = true;
                            control.PollingThread.Start();
                            control.ManualStopped = false;
                        }

                        break;

                    case JoystickType.MusicalInstrument:

                        var deviceNumber = GetAudioDeviceNumber();
                        if (deviceNumber == -1)
                        {
                            lblUnconnectedMsg.Visible = true;
                            return;
                        }

                        XMLHandler xml = new(CommonFile.AppSettings);
                        var resp = xml.GetValueByAddKey(AppKeys.AudioSamplingRate);

                        if (!resp.WasSuccessful)
                            throw new Exception(resp.ResponseErr);

                        bool canParse = int.TryParse(resp.Response, out int _samplerate);
                        control.SampleRate = canParse ? _samplerate : 48000;

                        resp = xml.GetValueByAddKey(AppKeys.ChannelType);

                        if (!resp.WasSuccessful)
                            throw new Exception(resp.ResponseErr);

                        canParse = Enum.TryParse(resp.Response, out ChannelType ctype);
                        control.ChannelType = canParse ? ctype : ChannelType.Mono;

                        lsbPlayedNotes.Items.Clear();

                        control.WaveIn = new WaveInEvent { DeviceNumber = deviceNumber, WaveFormat = new(control.SampleRate, (int)control.ChannelType) };

                        control.WaveIn.DataAvailable += WaveIn_DataAvailable;

                        control.WaveIn.StartRecording();
                        waveTimer.Start();
                        control.JoyConnected = true;

                        break;
                }

                if (control.JoyConnected)
                {
                    lblUnconnectedMsg.Visible = false;
                    btnStart.Enabled = false;
                    Utilix.EnableControlColor(btnStop);
                    control.SoundConnected.Play();
                    cbbDeviceType.Enabled = false;
                }                
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message,"Falha ao iniciar");
                this.btnStop_Click(this, EventArgs.Empty);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DisposeProcedure();
            Utilix.DisableControlColor(btnStop);
            btnStart.Enabled = true;
            control.ManualStopped = true;
            control.SoundDisconnected.Play();

            cbbDeviceType.Enabled = true;
        }
        
        private void DisposeProcedure()
        {
            control.KeepRunning = false;
            control.JoyConnected = false;
            control.IsProcessingAudio = false;
            control.PollingThread?.Join();            

            if (!control.ManualStopped || (!control.Joystick?.IsDisposed ?? false))
                control.Joystick?.Unacquire();

            control.Joystick?.Dispose();
            control.DirectInput?.Dispose();
            control.WaveIn?.StopRecording();
            control.WaveIn?.Dispose();
            waveTimer?.Stop();
        }

        #endregion
    }

    public enum LTModo
    {
        VolumeControl,
        SensibilityControl
    }    
}
