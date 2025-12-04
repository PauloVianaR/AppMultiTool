using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMultiTool.MainForms;
using AppMultiTool.RelatedForms;
using AppMultiTool.Utils;

namespace AppMultiTool.Models
{
    public class InstanceForms
    {
        public readonly static InstanceForms None;

        public AutoClicker AutoClicker { get; set; } = new();
        public ClipboardCopies ClipboardCopies { get; set; } = new();
        public Contador Contador { get; set; } = new();
        public DateCalculator DateCalculator { get; set; } = new();
        public GenValidatorCPF GenValidatorCPF { get; set; } = new();
        public GPTMessenger GPTMessenger { get; set; } = new();
        public JoyStickController JoyStickController { get; set; } = new();
        public MainMenu MainMenu { get; set; } = new();
        public MediaConverter MediaConverter { get; set; } = new();
        public PlaylistMaker PlaylistMaker { get; set; } = new();
        public Routine Routine { get; set; } = new();
        public SpreadSheetConverter SpreadSheetConverter { get; set; } = new();
        public TextConverter TextConverter { get; set; } = new();
        public TorrentDownloader TorrentDownloader { get; set; } = new();
        public WppBot WppBot { get; set; } = new();
        public VideoAudioDownloader VideoAudioDownloader { get; set; } = new();

        public ClipBoardCopiesTxt ClipBoardCopiesTxt { get; set; } = new();
        public GeneralConfigs GeneralConfigs { get; set; } = new();
        public JoyStickConfigs JoyStickConfigs { get; set; } = new();
        public LogErros LogErros { get; set; } = new();
        public PlayListConfigs PlayListConfigs { get; set; } = new();
        public PlayListCreator PlayListCreator { get; set; } = new();
        public PlayListEditor PlayListEditor { get; set; } = new();
        public TextSearcher TextSearcher { get; set; } = new(SearcherType.None);
    }
}
