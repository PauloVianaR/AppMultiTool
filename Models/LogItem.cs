using MasterWindowsForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiTool.Models
{
    public class LogItem : MasterItem
    {
        public string Log1 { get; set; }
        public string Log2 { get; set; }
        public DateTime Datelog { get; set; }

        public LogItem(MasterItem item) : base(item) => CreateItem();

        private void CreateItem()
        {
            var props = this.Propertys.Split("|").ToList();
            Log1 = props[0];
            Log2 = props[1];
            Datelog = DateTime.TryParse(props[2], out DateTime dt) ? dt : DateTime.Now; 
        }
    }
}
