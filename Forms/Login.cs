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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            Hide();
        }

        private void LinkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authentication.PanelRegister.Controls.Clear();

            Register register = new Register()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            register.FormBorderStyle = FormBorderStyle.None;

            Authentication.PanelRegister.Controls.Add(register);

            register.Show();

            Hide();
        }
    }
}
