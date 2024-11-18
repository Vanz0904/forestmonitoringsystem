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
    public partial class Updates : Form
    {
        public Updates()
        {
            InitializeComponent();
        }

        private void CloseDialog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Updates_Load(object sender, EventArgs e)
        {
            HoveringPanel.SetShadowForm(this);
        }
    }
}
