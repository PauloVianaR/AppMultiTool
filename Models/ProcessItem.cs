using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterWindowsForms;

namespace AppMultiTool.Models
{
    public class ProcessItem : MasterItem
    {
        public string Path { get; set; }
        public string Args { get; set; }
        public bool Using { get; set; }

        public ProcessItem(MasterItem item) : base(item) => CreateItem();

        public ProcessItem(int _id, string processname, string _path, string _args, bool _using = true)
        {
            ID = _id;
            Title = processname;
            Path = _path;
            Args = _args;
            Using = _using;
        }

        private void CreateItem()
        {
            List<string> props = this.Propertys.Split("|").ToList();
            bool usingprop = props[2].ToUpper() == "TRUE" || props[2] == "1";

            Path = props[0];
            Args = props[1];
            Using = usingprop;
        }
    }
}
