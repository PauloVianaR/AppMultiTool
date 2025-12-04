using MasterWindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMultiTool.Utils
{
    public static class CommandLine
    {
        public static void Show(Form callingForm)
        {
            try
            {
                string command = Prompt.ShowDialog("Comando: ", "Linha de Comando Rápido");

                if (string.IsNullOrEmpty(command) || string.IsNullOrWhiteSpace(command))
                    return;

                var type = CommandExecuter<Type>.GetCommandType(command);

                var method = typeof(CommandExecuter<>).MakeGenericType(type).GetMethod("Execute");

                if (method != null)
                {
                    var resp = method.Invoke(null, new object[] { command });

                    if (resp is ResponseHandler<bool> _resp)
                    {
                        if (!_resp.WasSuccessful)
                            throw new Exception(_resp.ResponseErr);
                    }

                    switch (resp)
                    {
                        case ResponseHandler<Form>:
                            var formResponse = (ResponseHandler<Form>)resp;

                            if (!formResponse.WasSuccessful)
                                throw new Exception(formResponse.ResponseErr);

                            var newForm = formResponse.Response;

                            if (newForm.Name == callingForm.Name)
                                return;

                            if (callingForm.Name == "PlaylistMaker")
                                Master.ShowScreen(newForm);
                            else
                                Master.SwitchScreen(newForm, callingForm);

                            break;
                        case ResponseHandler<double>:
                            var result = (ResponseHandler<double>)resp;
                            string _result = string.Concat(CommandExecuter<string>.CommandTarget(command, out string cmd), " = ", result.Response.ToString());

                            Master.ShowInfoMessage(_result, "Resultado");
                            break;
                        case ResponseHandler<string>:
                            var msg = (ResponseHandler<string>)resp;
                            Master.ShowInfoMessage(msg.Response, "App Multi-Tool diz");
                            break;
                    }
                }
                else
                    throw new Exception("Método não encontrado");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }
    }
}
