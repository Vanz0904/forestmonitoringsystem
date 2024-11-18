using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_app.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap map = new LiveCharts.WinForms.GeoMap();

            Dictionary<string, double> values = new Dictionary<string, double>();

            values["DZ"] = 30;
            values["US"] = 30;
            values["RU"] = 30;
            values["GB"] = 30;

            map.HeatMap = values;
            map.Source = @"\forest-monitoring-system\desktop-app\assets\World.xml";

            MapDisplay.Controls.Add(map);

            map.Dock = DockStyle.Fill;
            map.Hoverable = true;
        }

        private void BtnUpdates_Click(object sender, EventArgs e)
        {
            Updates updates = new Updates();
            updates.ShowDialog();
        }
    }
}
