using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;
using YoutubeDLSharp.Metadata;
using System.IO;
using MasterWindowsForms;
using AppMultiTool.Utils.GlobalItems;

namespace AppMultiTool.Utils.Controllers
{
    public class YTDownloader
    {
        private readonly string youtubeDLPath = Path.Combine(Global.MaterialPath, "youtube-dl.exe");        
        private readonly YoutubeClient Client;
        private readonly YoutubeDL Ytdl;
        public YTMethod Method { get; set; }

        public YTDownloader(YTMethod _method)
        {
            Client = new();
            Ytdl = new();
            Initialize(_method);
        }

        public YTDownloader()
        {
            XMLHandler xml = new(CommonFile.AppSettings);
            var resp = xml.GetValueByAddKey(AppKeys.YoutubeDownloadMethod);

            YTMethod _method = YTMethod.YoutubeExplode;
            if (resp.WasSuccessful)
            {
                bool canParse = Enum.TryParse(resp.Response, out YTMethod result);
                _method = canParse ? result : YTMethod.YoutubeExplode;
            }

            Client = new();
            Ytdl = new();
            Initialize(_method);
        }

        private void Initialize(YTMethod _method)
        {
            Method = _method;
            Ytdl.YoutubeDLPath = youtubeDLPath;
            Ytdl.FFmpegPath = Global.FFmpegPath;
            Ytdl.RestrictFilenames = true;
        }

        public async Task<ResponseHandler<string>> DownloadVideo(string url, string exitpath, IProgress<double> progress = null)
        {
            ResponseHandler<string> resp = new();

            try
            {
                switch (Method)
                {
                    case YTMethod.YoutubeExplode:
                        YoutubeClient client = new();
                        var video = await client.Videos.GetAsync(url);
                        var streamManifest = await client.Videos.Streams.GetManifestAsync(video.Id);

                        var videoTitle = Utilix.SanitizeFileName(video.Title);

                        string outputPath = Path.Combine(exitpath, $"{videoTitle}.mp4");
                        await client.Videos.DownloadAsync(url, outputPath, progress);

                        resp.IsSuccess(videoTitle);
                        break;

                    case YTMethod.YoutubeDLSharp:
                        Ytdl.OutputFolder = exitpath;

                        var result = await Ytdl.RunVideoDownload(url);
                        var videoData = await Ytdl.RunVideoDataFetch(url);

                        if (!result.Success)
                        {
                            StringBuilder sb = new();
                            foreach (string error in result.ErrorOutput)
                            {
                                sb.AppendLine(error);
                            }

                            throw new Exception(sb.ToString());
                        }

                        resp.IsSuccess(Utilix.SanitizeFileName(videoData.Data.Title));
                        break;

                    case YTMethod.PythonModule:
                        var respPython = await Pype.PythonDownloadVideo(url, exitpath);

                        if (!respPython.WasSuccessful)
                            throw new Exception(respPython.ResponseErr);

                        resp.IsSuccess(respPython.Response);
                        break;
                }
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }

        public async Task<ResponseHandler<string>> DownloadAudio(string url, string exitpath, IProgress<double> progress = null)
        {
            ResponseHandler<string> resp = new();

            try
            {
                switch (Method)
                {
                    case YTMethod.YoutubeExplode:
                        YoutubeClient client = new();
                        var video = await client.Videos.GetAsync(url);
                        var streamManifest = await client.Videos.Streams.GetManifestAsync(video.Id);

                        var videoTitle = Utilix.SanitizeFileName(video.Title);

                        string outputPath = Path.Combine(exitpath, $"{videoTitle}.mp4");
                        outputPath = Path.ChangeExtension(outputPath, ".mp3");

                        if (progress is not null)
                            await client.Videos.DownloadAsync(url, outputPath, o => o.SetContainer("mp3").SetFFmpegPath(Global.FFmpegPath), progress);
                        else
                            await client.Videos.DownloadAsync(url, outputPath, o => o.SetContainer("mp3").SetFFmpegPath(Global.FFmpegPath));

                        resp.IsSuccess(videoTitle);
                        break;

                    case YTMethod.YoutubeDLSharp:
                        Ytdl.OutputFolder = exitpath;

                        var result = await Ytdl.RunAudioDownload(url);
                        var videoData = await Ytdl.RunVideoDataFetch(url);

                        if (!result.Success)
                            throw new Exception(result.ErrorOutput.ToString());

                        resp.IsSuccess(Utilix.SanitizeFileName(videoData.Data.Title));
                        break;

                    case YTMethod.PythonModule:
                        var respPython = await Pype.PythonDownloadAudio(url, exitpath);

                        if (!respPython.WasSuccessful)
                            throw new Exception(respPython.ResponseErr);

                        resp.IsSuccess(respPython.Response);
                        break;
                }
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }
    }

    public enum YTMethod
    {
        YoutubeExplode,
        YoutubeDLSharp,
        PythonModule
    }
}
