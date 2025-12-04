using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting.Hosting;
using MasterWindowsForms;
using AppMultiTool.Utils.GlobalItems;

namespace AppMultiTool.Utils.Controllers
{
    public static class Pype
    {
        public static async Task<ResponseHandler<string>> PythonDownloadVideo(string url, string exitpath) => await PythonYTDownload(url, exitpath, "downloadvideo");

        public static async Task<ResponseHandler<string>> PythonDownloadAudio(string url, string exitpath) => await PythonYTDownload(url, exitpath, "downloadaudio");

        private static Task<ResponseHandler<string>> PythonYTDownload(string url, string exitpath, string funcName)
        {
            return Task.Run(() =>
            {
                ResponseHandler<string> resp = new();

                try
                {
                    ScriptEngine engine = Python.CreateEngine();
                    ScriptScope scope = engine.CreateScope();

                    string pythonScriptPath = Path.Combine(Global.PyModulesPath, "ytdownloader.py");
                    engine.ExecuteFile(pythonScriptPath, scope);

                    dynamic downloader = scope.GetVariable(funcName);

                    string videoTitle = downloader(url, exitpath);

                    resp.IsSuccess(videoTitle);
                }
                catch (Exception ex)
                {
                    resp.IsNotSuccess(ex.Message);
                }

                return resp;
            });
        }
    }
}
