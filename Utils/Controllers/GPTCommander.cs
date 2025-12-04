using System;
using System.Threading.Tasks;
using System.IO;
using RestSharp;
using MasterWindowsForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.AIPlatform.V1;
using Google.Protobuf.WellKnownTypes;
using System.Net.Http;
using System.Text;

namespace AppMultiTool.Utils.Controllers
{
    public static class GPTCommander
    {
        private const string gpt_apiKey = "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";
        private const string gpt_apiUrl = "https://api.openai.com/v1/chat/completions";
        private const string hugging_face_apiUrl = "https://api-inference.huggingface.co/models/openai-community/gpt2";
        private const string hugging_face_apiKey = "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";
        public const string google_apiKey = "AIzaSyCmF71kqu8wEaTgaT8iGzh2OFyBBBj3uFc";
        private const string vertexAI_project_id = "appmultitool";
        private const string deepseekAPI_KEY = "sk-49ec3d3a72b94c41a52d17d55c299c8e";
        private const string deepseekBaseURL = "https://api.deepseek.com";

        public static async Task<ResponseHandler<string>> GenerateTextAsyncGPT(string prompt, ApiType apitype)
        {
            ResponseHandler<string> resp = new();
            int maxRetries = 5;
            int delay = 1000;
            string model = apitype == ApiType.GPT3_5_Turbo ? "gpt-3.5-turbo" : "gpt-4o-mini";

            for (int attempt = 1; attempt <= maxRetries; attempt++)
            {
                try
                {
                    var client = new RestClient(gpt_apiUrl);

                    var request = new RestRequest()
                        .AddHeader("Authorization", $"Bearer {gpt_apiKey}")
                        .AddHeader("Content-Type", "application/json");

                    var requestBody = new
                    {
                        model,
                        messages = new[]
                        {
                            new { role = "system", content = "Você é um assistente de ajuda." },
                            new { role = "user", content = prompt }
                        }
                    };

                    request.AddJsonBody(requestBody);

                    var response = await client.PostAsync<RestResponse>(request);

                    if (response.IsSuccessful)
                    {
                        dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                        resp.IsSuccess(jsonResponse.choices[0].message.content.ToString());
                        break;
                    }
                    else
                    {
                        if (attempt == maxRetries)
                        {
                            resp.IsNotSuccess($"Error: {response.StatusCode}");
                        }
                        else
                        {
                            await Task.Delay(delay);
                            delay *= 2;
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (attempt == maxRetries)
                    {
                        resp.IsNotSuccess(ex.Message);
                    }
                    else
                    {
                        await Task.Delay(delay);
                        delay *= 2;
                    }
                }
            }

            return resp;
        }

        public static async Task<ResponseHandler<string>> GenerateTextAsyncHuggingFace(string prompt, ApiType apitype)
        {
            ResponseHandler<string> resp = new();

            try
            {
                var client = new RestClient(hugging_face_apiUrl);
                var request = new RestRequest();

                request.AddHeader("Authorization", $"Bearer {hugging_face_apiKey}");
                request.AddHeader("Content-Type", "application/json");

                var requestBody = new { inputs = prompt };

                request.AddJsonBody(requestBody);

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var jsonResponse = JObject.Parse(response.Content);
                    var generatedText = jsonResponse["choices"][0]["text"].ToString();
                    resp.IsSuccess(generatedText);
                }
                else
                {
                    resp.IsNotSuccess($"Request failed with status code {response.StatusCode}: {response.Content}");
                }
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }

        public static async Task<ResponseHandler<string>> GenerateTextAsyncGemini(string prompt, ApiType apitype)
        {
            ResponseHandler<string> resp = new();

            try
            {
                string jsonPath = @"D:\PROJETOS PROG HD\AppMultiTool\AppMultiTool\Material\appmultitool-4ae79b1b4cfe.json";
                const string _location = "southamerica-east1";
                const string _modelId = "gemini-1.5-flash-001";

                string jsonKeyContent = File.ReadAllText(jsonPath);
                var credential = GoogleCredential.FromJson(jsonKeyContent);

                // Constrói o cliente PredictionService com as credenciais JSON
                var client = new PredictionServiceClientBuilder
                {
                    JsonCredentials = jsonKeyContent,
                    Endpoint = $"{_location}-aiplatform.googleapis.com"
                }.Build();

                // Cria o nome do modelo
                var modelName = ModelName.FromProjectLocationModel("appmultitool", _location, _modelId);

                // Configura a requisição PredictRequest
                var request = new PredictRequest
                {
                    Endpoint = modelName.ToString(),
                    Instances =
                    {
                        new Google.Protobuf.WellKnownTypes.Value
                        {
                            StructValue = new Struct
                            {
                                Fields =
                                {
                                    { "prompt", Google.Protobuf.WellKnownTypes.Value.ForString(prompt) }
                                }
                            }
                        }
                    },
                    Parameters = new Google.Protobuf.WellKnownTypes.Value
                    {
                        StructValue = new Struct
                        {
                            Fields =
                            {
                                { "maxOutputTokens", Google.Protobuf.WellKnownTypes.Value.ForNumber(8192) },
                                { "temperature", Google.Protobuf.WellKnownTypes.Value.ForNumber(1.0) },
                                { "topP", Google.Protobuf.WellKnownTypes.Value.ForNumber(0.95) }
                            }
                        }
                    }
                };

                // Faz a requisição e recebe a resposta
                var response = await client.PredictAsync(request);

                // Extrai o texto gerado da resposta
                string generatedText = response.Predictions[0].StructValue.Fields["content"].StringValue;

                resp.IsSuccess(generatedText);
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }

        public static async Task<ResponseHandler<string>> GenerateTextAsyncDeepSeek(string prompt, ApiType apitype)
        {
            ResponseHandler<string> resp = new();

            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {deepseekAPI_KEY}");

                var requestData = new
                {
                    model = "deepseek-chat",
                    messages = new[]
                    {
                        new { role = "system", content = "You are a helpful assistant" },
                        new { role = "user", content = "Hello" }
                    },
                    stream = false
                };

                string jsonData = JsonConvert.SerializeObject(requestData);

                HttpResponseMessage response = await client.PostAsync($"{deepseekBaseURL}/v1/chat/completions", new StringContent(jsonData, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var responseJson = JsonConvert.DeserializeObject<dynamic>(responseContent);

                    resp.IsSuccess(responseJson.choices[0].message.content);
                }
                else
                    throw new Exception($"Erro: {response.StatusCode}");
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }
    }

    public enum ApiType
    {
        GPT3_5_Turbo,
        GPT4_Mini,
        HuggingFace,
        Gemini,
        DeepSeek
    }
}
