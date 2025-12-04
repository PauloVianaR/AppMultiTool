using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterWindowsForms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Upload;
using System.Threading;
using System.IO;
using AppMultiTool.Utils.GlobalItems;

namespace AppMultiTool.Utils.Controllers
{
    public static class GoogleManager
    {
        private static readonly string[] Scopes = { DriveService.Scope.DriveFile };
        private static readonly string ApplicationName = "appmultitool";

        [Obsolete]
        public static async Task<ResponseHandler<DriveService>> GetDriveServiceAsync()
        {
            ResponseHandler<DriveService> resp = new();

            try
            {
                UserCredential credential;
                using (var stream = new FileStream(Global.OAuthCredentialPath, FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true));
                }

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                resp.IsSuccess(service);
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }

        public static async Task<bool> FileExistsDrive(DriveService service, string fileName)
        {
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.Q = $"name = '{fileName}' and trashed = false";
            listRequest.Fields = "files(id, name)";

            var fileList = await listRequest.ExecuteAsync();
            IList<Google.Apis.Drive.v3.Data.File> files = fileList.Files;

            return files.Count > 0;
        }

        public static async Task<ResponseHandler<string>> UploadFileGoogleDocs(DriveService service, string filePath)
        {
            ResponseHandler<string> resp = new();

            try
            {
                string fileName = Path.GetFileName(filePath);

                if (await FileExistsDrive(service, fileName))
                    throw new Exception($"Arquivo '{fileName}' já existe no Google Drive. O upload foi cancelado");

                var fileMetadata = new Google.Apis.Drive.v3.Data.File() { Name = fileName };

                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    request = service.Files.Create(fileMetadata, stream, "text/plain");
                    request.Fields = "id";
                    await request.UploadAsync();
                }

                var file = request.ResponseBody;
                resp.IsSuccess(file.Id);
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }
    }
}
