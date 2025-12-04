using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MasterWindowsForms;
using HtmlAgilityPack;

namespace AppMultiTool.Utils
{
    public static class LyricsExtractor
    {
        public static async Task<ResponseHandler<string>> WebExtraction(string artist, string song)
        {
            ResponseHandler<string> resp = new();

            try
            {
                string query = HttpUtility.UrlEncode($"{artist} {song}");
                string url = $"https://www.letras.mus.br/?q={query}";

                using var httpClient = new HttpClient();
                string htmlSearch = await httpClient.GetStringAsync(url);

                var docSearch = new HtmlDocument();
                docSearch.LoadHtml(htmlSearch);

                var linkMusica = docSearch.DocumentNode
                .SelectSingleNode("//a[contains(@class, 'gs-title') and @data-ctorig]") ?? throw new Exception("Não foi possível encontrar a música.");

                string urlMusica = linkMusica.GetAttributeValue("data-ctorig", null);

                if (string.IsNullOrWhiteSpace(urlMusica))
                    throw new Exception("URL da música não encontrada.");

                // Baixar a página da música
                string htmlSong = await httpClient.GetStringAsync(urlMusica);
                var docSong = new HtmlDocument();
                docSong.LoadHtml(htmlSong);

                var divLyric = docSong.DocumentNode.SelectSingleNode("//div[contains(@class, 'lyric-original')]") ?? throw new Exception("Letra não encontrada na página da música.");
                resp.IsSuccess(HtmlEntity.DeEntitize(divLyric.InnerText.Trim()));
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess($"Erro: {ex.Message}");
            }

            return resp;
        }
    }
}
