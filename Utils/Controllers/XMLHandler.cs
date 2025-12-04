using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MasterWindowsForms;

namespace AppMultiTool.Utils.Controllers
{
    public class XMLHandler
    {
        public string FilePath { get; set; }

        public XMLHandler(string _filepath)
        {
            FilePath = _filepath;
        }

        public XMLHandler(CommonFile file)
        {
            if (file == CommonFile.AppSettings)
                FilePath = @"..\..\..\AppSettings.config";
            else
                FilePath = string.Empty;
        }

        public ResponseHandler<string> GetValueByAddKey(AppKeys tag) => GetValueByAddKey(tag.ToString());
        public ResponseHandler<string> GetValueByAddKey(string keyValue) => GetValueByKey("add", "key", keyValue);
        public ResponseHandler<string> GetValueByKey(string tagName, string keyName, string keyValue)
        {
            ResponseHandler<string> resp = new();

            try
            {
                if (FilePath == string.Empty)
                    throw new Exception("Caminho do arquivo não definido!");

                XDocument configFile = XDocument.Load(FilePath);
                XElement specificElement = configFile.Descendants(tagName).FirstOrDefault(e => (string)e.Attribute(keyName) == keyValue);

                if (specificElement is null)
                    throw new Exception($"Tag <{tagName}> {keyName} não encontrada!");

                string value = specificElement.Attribute("value")?.Value;

                resp.IsSuccess(value);
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }

        public ResponseHandler<bool> SetValueByAddKey(AppKeys tag, string newValue) => SetValueByAddKey(tag.ToString(), newValue);
        public ResponseHandler<bool> SetValueByAddKey(string keyValue, string newValue) => SetValueByKey("add", "key", keyValue, newValue);
        public ResponseHandler<bool> SetValueByKey(string tagName, string keyName, string keyValue, string newValue)
        {
            ResponseHandler<bool> resp = new();

            try
            {
                if (FilePath == string.Empty)
                    throw new Exception("Caminho do arquivo não definido!");

                XDocument configFile = XDocument.Load(FilePath);
                XElement specificElement = configFile.Descendants(tagName).FirstOrDefault(e => (string)e.Attribute(keyName) == keyValue);

                if (specificElement is null)
                    resp.IsNotSuccess($"Tag <{tagName}> {keyName} não encontrada!");

                specificElement.SetAttributeValue("value", newValue);
                configFile.Save(FilePath);

                resp.IsSuccess(true);
            }
            catch (Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }
    }
}
