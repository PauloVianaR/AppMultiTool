using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiTool.Models
{
    public class SSConverterModel
    {
        public string Command { get; set; }
        public string Path { get; set; }
        public string CellFormat { get; set; }
        public string WorkBookName { get; set; }
        public string WorkSheetName { get; set; }
        public bool WsContainsHeader { get; set; }
        public bool CanGetWorkSheetName { get; set; }
        public bool CanHighLightWords { get; set; }
        public int FontSizeComboBoxIndex { get; set; }
    }
}
