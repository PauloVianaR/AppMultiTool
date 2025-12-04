using AppMultiTool.Utils.GlobalItems;
using MasterWindowsForms;
using Microsoft.VisualBasic.Devices;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppMultiTool.Utils.Controllers
{
    public class InternetMediaDownloader
    {
        public static async Task<ResponseHandler<string>> DownloadVideo(string url, string outputFolder, IProgress<double> progress)
        {
            string args = $"\"{url}\" -o \"{outputFolder}\\%(title)s.%(ext)s\"";
            return await Download(args, progress);
        }

        public static async Task<ResponseHandler<string>> DownloadAudio(string url, string outputFolder, IProgress<double> progress)
        {
            string args = $"-x --audio-format mp3 \"{url}\" -o \"{outputFolder}\\%(title)s.%(ext)s\"";
            return await Download(args, progress);
        }

        private static async Task<ResponseHandler<string>> Download(string args, IProgress<double> progress)
        {
            ResponseHandler<string> resp = new();

            try
            {
                await DownloadMediaAsync(args, progress);
                resp.IsSuccess("sucesso");
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }


        private static async Task DownloadMediaAsync(string args, IProgress<double> progress)
        {
            var psi = new ProcessStartInfo
            {
                FileName = Path.Combine(Global.MaterialPath, "yt-dlp.exe"),
                Arguments = args,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            string ffmpegFolder = AppDomain.CurrentDomain.BaseDirectory;
            psi.Environment["PATH"] = ffmpegFolder + ";" + Environment.GetEnvironmentVariable("PATH");

            using var process = new Process { StartInfo = psi };

            string lastError = string.Empty;

            process.OutputDataReceived += (s, e) => ProcessOutputLine(e.Data, progress);
            process.ErrorDataReceived += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(e.Data))
                {
                    lastError += e.Data + "\n";
                }
                ProcessOutputLine(e.Data, progress);
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await process.WaitForExitAsync();

            if (process.ExitCode != 0)
            {
                throw new Exception($"yt-dlp failed with code {process.ExitCode}\nErrors: {lastError}");
            }
        }



        private static void ProcessOutputLine(string line, IProgress<double> progress)
        {
            if (string.IsNullOrWhiteSpace(line)) return;

            var match = Regex.Match(line, @"\[\s*download\]\s+(\d{1,3}\.\d)%");
            if (match.Success && double.TryParse(match.Groups[1].Value, out double percent))
            {
                percent = Math.Max(0, Math.Min(percent, 100));
                double normalized = percent / 100.0;
                progress.Report(normalized);
            }
        }
    }
}
