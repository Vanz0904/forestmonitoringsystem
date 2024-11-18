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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            Hide();
        }

        private void LinkSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authentication.PanelLogin.Controls.Clear();

            Login login = new Login()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            login.FormBorderStyle = FormBorderStyle.None;

            Authentication.PanelLogin.Controls.Add(login);

            login.Show();

            Hide();
        }
    }
}
