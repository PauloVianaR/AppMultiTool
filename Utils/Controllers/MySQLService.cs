using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterWindowsForms;
using MySql.Data.MySqlClient;

namespace AppMultiTool.Utils.Controllers
{
    public static class MySQLService
    {
        public static string GetConnectString(Databases db)
        {
            string _conecstring = string.Empty;

            switch ((int)db)
            {
                case 0:
                    _conecstring = "Server=localhost;Database=appmultitool;Uid=root;Pwd=Relapa123635241987$;";
                    break;
                case 1:
                    _conecstring = "Server=localhost;Database=bancoteste;Uid=root;Pwd=Relapa123635241987$;";
                    break;
            }

            return _conecstring;
        }
    }

    public enum Databases
    {
        AppMultiTool,
        BancoTeste
    }
}
