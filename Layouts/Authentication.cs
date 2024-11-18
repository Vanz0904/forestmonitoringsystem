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
    public partial class Authentication : Form
    {
        public static Panel PanelLogin;
        public static Panel PanelRegister;

        public Authentication()
        {
            InitializeComponent();

            PanelLogin = Signin;
            PanelRegister = Signup;

            PanelLogin.Controls.Clear();

            Login login = new Login()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            login.FormBorderStyle = FormBorderStyle.None;

            PanelLogin.Controls.Add(login);

            login.Show();
        }

        private void LoginRegistrationForm_Load(object sender, EventArgs e)
        {
            HoveringForm.SetShadowForm(this);
        }

        private void LinkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signin.Visible = true;

            if (Signin.Visible == true)
            {
                Signup.Visible = false;
            }
        }

        private void LinkSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup.Visible = true;

            if (Signup.Visible == true)
            {
                Signin.Visible = false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            Hide();
        }
    }
}
