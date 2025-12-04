using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterWindowsForms;

namespace AppMultiTool.Models
{
    public class PlayListItem : MasterItem
    {
        public string ForeColor { get; set; }
        public string Path { get; set; }

        public PlayListItem(MasterItem item) : base(item) => CreateItem();

        private void CreateItem()
        {
            List<string> props = this.Propertys.Split("|").ToList();

            ForeColor = props[0];
            Path = props[1];
        }
    }
}
