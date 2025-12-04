using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace AppMultiTool.Models
{
    public class PlayListMakerModel
    {
        public List<PlayListItem> Playlists { get; set; }
        public List<SongItem> Songs { get; set; }
        public List<SongItem> CurrentPlaylist { get; set; }
        public List<SongItem> OriginalPlaylist { get; set; }
        public List<bool> Boolpropsbtns { get; set; }
        public List<int> SongsPlayedIndex { get; set; } = new();
        public WindowsMediaPlayer Player { get; set; }
        public int CurrentTrackIndex { get; set; } = 0;
        public string SelectedSongTitle { get; set; } = string.Empty;
        public bool IsSongStarted { get; set; } = false;
        public bool IsSongPaused { get; set; } = false;
        public bool ManualSongSelected { get; set; } = false;
        public bool LoopPlaylist { get; set; } = false;
        public bool RandomPlaylist { get; set; } = false;
        public bool AutoNextSong { get; set; } = false;

        public List<SongItem> DeepCopyPlaylist(List<SongItem> songs) => songs.Select(song => new SongItem(song)).ToList();

        public List<SongItem> SortPlayList(List<SongItem> songs)
        {
            List<SongItem> sortedPlaylist = new();

            for (int i = 0; i < songs.Count; i++)
            {
                var item = songs[i];
                item.NumSeq = i + 1;
                sortedPlaylist.Add(item);
            }

            return sortedPlaylist;
        }
    }
}
