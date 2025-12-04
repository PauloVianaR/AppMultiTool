using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using MasterWindowsForms;

namespace AppMultiTool.Utils
{
    public class VirusChecker
    {
        private const string VirusTotalApiKey = "e4fe03ff85aeadc80d9534f4743e74a65deefd330d906f2cc31a5c6957f805ed";
        private const string VirusTotalApiUrl = "https://www.virustotal.com/api/v3/files";

        public async Task<ResponseHandler<bool>> IsFileSafe(string filePath)
        {
            ResponseHandler<bool> resp = new();

            try
            {
                var client = new RestClient(VirusTotalApiUrl);
                var request = new RestRequest("",Method.Post);
                request.AddHeader("x-apikey", VirusTotalApiKey);
                request.AddFile("file", filePath);

                var response = await client.ExecuteAsync<VirusTotalResponse>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var scanResult = response.Data;

                    if (scanResult.data.attributes is null)
                        throw new Exception("Os atributos de scanResult são nulos!");

                    resp.IsSuccess(!scanResult.data.attributes.last_analysis_stats.malicious.HasValue ||
                           scanResult.data.attributes.last_analysis_stats.malicious.Value == 0);

                    return resp;
                }

                resp.IsNotSuccess(string.Concat("Error da API: \n",response.StatusDescription));
                return resp;
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(string.Concat("Falha durante a verificação da existência de vírus no arquivo: \n",ex.Message));
                return resp;
            }
        }

        private class VirusTotalResponse
        {
            public Data data { get; set; }

            public class Data
            {
                public Attributes attributes { get; set; }
            }

            public class Attributes
            {
                public LastAnalysisStats last_analysis_stats { get; set; }
            }

            public class LastAnalysisStats
            {
                public int? malicious { get; set; }
            }
        }
    }
}
