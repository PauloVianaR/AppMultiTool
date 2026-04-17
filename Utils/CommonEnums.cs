using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiTool.Utils
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public enum AppKeys
    {
        JoyStickDeviceName,
        AudioSamplingRate,
        ChannelType,
        InactivityTimeOut,
        UseTimeOut,
        YoutubeDownloadMethod,
        FontSizeDefault,
        ShowRealTime,
        UseDarkTheme,
        CloseAfterCheckedDefaultRoutine,
        WallPaper,
        DefaultDownloadFolderPath,
        UseSpreedSheetConverterLogger
    }

    public enum CommonFile
    {
        AppSettings
    }

    public enum SearcherType
    {
        None,
        DataBase,
        FilePath
    }
}
