using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiTool.Utils
{
    public class FavSites
    {
        public const string Google = "https://www.google.com";
        public const string Youtube = "https://www.youtube.com/";
        public const string Crunchyroll = "https://www.crunchyroll.com/pt-br/watchlist";
        public const string Netflix = "https://www.netflix.com/browse";
        public const string Prime = "https://www.primevideo.com/";
        public const string Max = "https://play.max.com/";
        public const string Disney = "https://www.disneyplus.com/pt-br/select-profile";

        public string GetURL(int index)
        {
            List<string> sites = new() { Google, Youtube, Crunchyroll, Netflix, Prime, Max, Disney };
            return sites[index];
        }
    }
}
