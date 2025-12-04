using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMultiTool.Models;
using AppMultiTool.Utils;
using AppMultiTool.Utils.Controllers;
using AppMultiTool.Utils.GlobalItems;
using MasterWindowsForms;

namespace AppMultiTool.RelatedForms
{
    public partial class TextSearcher : Form
    {
        private readonly MasterMySQLService sql;
        private readonly List<TextItem> textItems;
        private readonly SearcherType stype;
        private readonly string path = string.Empty;
        public event Action<string> SelectedText;

        public TextSearcher(SearcherType st, string _path = "")
        {
            InitializeComponent();
            Global.InactivityMonitor.ResetTimer();
            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));
            textItems = [];
            stype = st;
            path = _path;

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
        }

        private async void TextSearcher_Load(object sender, EventArgs e)
        {
            if (stype == SearcherType.DataBase)
                await this.ConnectDb();
            else if (stype == SearcherType.FilePath)
                this.AddFileItems();
        }

        private void AddFileItems()
        {
            if (Utilix.IsNullOrEmptyOrWhiteSpace(path))
                return;

            var files = Directory.GetFiles(path, "*.txt");

            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                textItems.Add(new TextItem(0,fileName,fileName));
                lsbItems.Items.Add(fileName);
            }
        }

        private async Task ConnectDb()
        {
            try
            {
                string query = "SELECT * FROM textcopies ORDER BY title";

                var resp = await sql.ReadQuery(query);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                var listItems = resp.Response;

                if (listItems.Count > 1)
                {
                    listItems.ForEach(item =>
                    {
                        TextItem textitem = new(item.ID, item.Title, item.Propertys);
                        textItems.Add(textitem);
                        lsbItems.Items.Add(textitem.Title);
                    });
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e) => this.Hide();

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchText.Text.ToLower();

            var filteredTexts = string.IsNullOrWhiteSpace(searchText)
                ? textItems
                : textItems.Where(text => text.Title.Contains(searchText, StringComparison.CurrentCultureIgnoreCase)).ToList();

            lsbItems.Items.Clear();

            filteredTexts.ForEach(text => lsbItems.Items.Add(text.Title));
        }

        private void lsbItems_DoubleClick(object sender, EventArgs e)
        {
            SelectedText?.Invoke(lsbItems.SelectedItem.ToString());
            this.Close();
        }
    }
}
