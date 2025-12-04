using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MasterWindowsForms;

namespace AppMultiTool.Models
{
    public class SongItem : MasterItem
    {
        public string Path { get; set; }        
        public int IdPlaylist { get; set; }
        public int NumSeq { get; set; }
        public bool Active { get; set; }
        public string Lyrics { get; set; }

        public SongItem(MasterItem item) : base(item) => CreateItem();

        public SongItem(SongItem song) : this(song.ID, song.Title, song.Path, song.IdPlaylist, song.NumSeq, song.Active, song.Lyrics) { }

        public SongItem(int id, string name, string path, int idplaylist, int numseq, bool active, string lyrics = "")
        {
            ID = id;
            Title = name;
            Path = path;
            IdPlaylist = idplaylist;
            NumSeq = numseq;
            Active = active;
            Lyrics = lyrics;
        }        

        private void CreateItem()
        {
            List<string> props = this.Propertys.Split("|").ToList();
            bool active = props[3] == "True" || props[3] == "1";

            Path = props[0];
            IdPlaylist = Convert.ToInt32(props[1]);
            NumSeq = Convert.ToInt32(props[2]);
            Active = active;
            Lyrics = props[4];
        }

        public static async Task<ResponseHandler<int>> GetNextNumSeq(PlayListItem _playList, MySqlConnection connection)
        {
            ResponseHandler<int> response = new();

            try
            {
                string query = $"SELECT max(numseq)+1 FROM songs_playlist WHERE idplaylist = {_playList.ID}";

                var resp = await MasterMySQLService.ReadSingledQuery(query, connection);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                int result = resp.Response == string.Empty ? 1 : Convert.ToInt32(resp.Response);

                response.IsSuccess(result);
            }
            catch(Exception ex)
            {
                response.IsNotSuccess(ex.Message);
            }

            return response;
        }

        public static string GetSongName(string oldname)
        {
            var list = oldname.Split("]");
            string newName;

            if (list.Length > 2)
            {
                StringBuilder sb = new();

                for (int i = 1; i < list.Length; i++)
                {
                    if (i == 1)
                        sb.Append(string.Concat(list[i], "]"));
                    else
                        sb.Append(list[i]);
                }

                newName = sb.ToString();
            }
            else
                newName = list[1];

            return newName.Trim();
        }

        public static decimal GetNumSeq(string song)
        {
            var _numseq = song.Split("]").GetValue(0).ToString();
            bool canParse = decimal.TryParse(_numseq.Replace("[", "").Trim(), out decimal numseq);
            return canParse ? numseq : 0;
        }

        public string ConcatNumSeq(string newSongName = "") => string.Concat("[", this.NumSeq.ToString(), "] ", newSongName == string.Empty ? this.Title : newSongName);
        public static string ConcatNumSeq(SongItem song,string newSongName = "") => string.Concat("[", song.NumSeq.ToString(), "] ", newSongName == string.Empty ? song.Title : newSongName);
    }
}
