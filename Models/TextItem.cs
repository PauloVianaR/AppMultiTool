using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterWindowsForms;

namespace AppMultiTool.Models
{
    public class TextItem : MasterItem
    {
        public TextItem(int _id, string _title, string _textbody, int _index = 0)
        {
            ID = _id;
            Title = _title;
            Textbody = _textbody;
            ComboBoxIndex = _index;
        }

        public string Textbody { get; set; }
        public int ComboBoxIndex { get; set; }
    }
}
