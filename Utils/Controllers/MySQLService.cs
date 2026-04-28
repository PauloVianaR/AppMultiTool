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
        private static readonly XMLHandler xml;

        static MySQLService()
        {
            xml = new(CommonFile.AppSettings);
        }

        public static string GetConnectString(Databases db)
        {
            string _conecstring = string.Empty;

            switch ((int)db)
            {
                case 0:
                    _conecstring = xml.GetValueByAddKey(AppKeys.ConnectionString).Response;
                    break;
                case 1:
                    _conecstring = "Server=localhost;Database=bancoteste;Uid=root;Pwd=123456";
                    break;
            }

            return _conecstring;
        }
    }

    public enum Databases
    {
        AppMultiTool,
        Other
    }
}
