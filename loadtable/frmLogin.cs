using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadtable
{
    public partial class frmLogin : Form
    {
        public bool fCancel = false;
        public string strUID = "";
        public string strPWD = "";
        public string strHost = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            strUID = txtUID.Text;
            strPWD = txtPassword.Text;
            strHost = txtHost.Text;
            this.Hide();
        }

        private void cmdKo_Click(object sender, EventArgs e)
        {
            fCancel = true;
            this.Hide();
        }
    }
}
