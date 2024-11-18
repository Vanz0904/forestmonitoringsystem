using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop_app.Forms;

namespace desktop_app
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            DisplayPanel.Controls.Clear();

            Home home = new Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            home.FormBorderStyle = FormBorderStyle.None;

            DisplayPanel.Controls.Add(home);

            home.Show();

            btnHome.ForeColor = Color.FromArgb(16, 255, 0);
            btnHome.Image = Properties.Resources.home_page_primary;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.Show();

            Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();

            Home home = new Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            home.FormBorderStyle = FormBorderStyle.None;

            DisplayPanel.Controls.Add(home);

            home.Show();

            btnHome.ForeColor = Color.FromArgb(16, 255, 0);
            btnHome.Image = Properties.Resources.home_page_primary;
            btnMonitor.ForeColor = Color.White;
            btnMonitor.Image = Properties.Resources.home_office_white;
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = Properties.Resources.tune_white;
        }

        private void BtnMonitor_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();

            Monitoring monitoring = new Monitoring()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            monitoring.FormBorderStyle = FormBorderStyle.None;

            DisplayPanel.Controls.Add(monitoring);

            monitoring.Show();

            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.home_page_white;
            btnMonitor.ForeColor = Color.FromArgb(16, 255, 0);
            btnMonitor.Image = Properties.Resources.home_office_primary;
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = Properties.Resources.tune_white;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();

            Settings settings = new Settings()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            settings.FormBorderStyle = FormBorderStyle.None;

            DisplayPanel.Controls.Add(settings);

            settings.Show();

            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.home_page_white;
            btnMonitor.ForeColor = Color.White;
            btnMonitor.Image = Properties.Resources.home_office_white;
            btnSettings.ForeColor = Color.FromArgb(16, 255, 0);
            btnSettings.Image = Properties.Resources.tune_primary;
        }
    }
}
