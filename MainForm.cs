using Newtonsoft.Json;
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

namespace AlbionMT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AlbionOnlineDataProjectAPI aodp = new AlbionOnlineDataProjectAPI();
            AlbionData albionData = new AlbionData();
            List<AlbionData.Models.Item> items = albionData.LoadItems();

            var itemsWithLocalizedNames = items.Where(x => x.LocalizedNames != null);
            //var names = items.Where(i => i.LocalizedNames.PlPl != null).Select(s=>s.LocalizedNames.PlPl).ToList();// search in name domain 
            var names = itemsWithLocalizedNames.Select(d => d.LocalizedNames.PlPl).ToArray();
            var comName = names.Where(n => n.Contains("Koń"));
            var searchQuery = itemsWithLocalizedNames.Where(x => x.LocalizedNames.PlPl.Equals(comName.First().ToString())).WhereNotNull().ToList<AlbionData.Models.Item>(); // find all hits 

            comboBox1.Items.AddRange(names);



        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
