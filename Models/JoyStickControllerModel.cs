using System;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using SharpDX.DirectInput;
using NAudio.Wave;
using System.IO;
using AppMultiTool.Utils.GlobalItems;

namespace AppMultiTool.Models
{
    public class JoyStickControllerModel
    {
        public DirectInput DirectInput { get; set; }
        public Joystick Joystick { get; set; }
        public Thread PollingThread { get; set; }
        public bool KeepRunning { get; set; }
        public int MouseSpeed { get; set; }
        public bool ManualStopped { get; set; }
        public SoundPlayer SoundConnected { get; }
        public SoundPlayer SoundDisconnected { get; }
        public SoundPlayer SoundClick { get; }       
        public JoystickType JoyType { get; set; }
        public string DetectedNote { get; set; }
        public WaveInEvent WaveIn { get; set; }
        public bool IsProcessingAudio { get; set; }
        public byte[] AudioBuffer { get; set; }
        public int SampleRate { get; set; }
        public ChannelType ChannelType { get; set; }
        public float CurrentX { get; set; } = 0;
        public float CurrentY { get; set; } = 0;
        public float TargetX { get; set; } = 0;
        public float TargetY { get; set; } = 0;
        public float SmoothingFactor { get; } = 0.6f;

        public event EventHandler ConnectionChanged;

        private bool _joyConnected = false;
        public bool JoyConnected
        {
            get => _joyConnected;
            set
            {
                _joyConnected = value;
                ConnectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public JoyStickControllerModel()
        {
            SoundConnected = new SoundPlayer(Path.Combine(Global.MaterialPath, "SoundConnected.wav"));
            SoundDisconnected = new SoundPlayer(Path.Combine(Global.MaterialPath, "SoundDisconnected.wav"));
            SoundClick = new SoundPlayer(Path.Combine(Global.MaterialPath, "SoundClick.wav"));
            JoyType = JoystickType.XboxJoystick;
            KeepRunning = false;
            ManualStopped = false;
            IsProcessingAudio = false;
        }
    }

    public enum JoystickType
    {
        XboxJoystick,
        MusicalInstrument
    }

    public enum ChannelType
    {
        Mono = 1,
        Stereo
    }
}
