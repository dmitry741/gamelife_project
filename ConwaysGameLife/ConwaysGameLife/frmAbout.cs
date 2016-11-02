using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConwaysGameLife
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            txtGitHub.Text = Properties.Resources.GitHubLink;
            txtEmail.Text = Properties.Resources.MyEmail;
            textBox1.Text = Properties.Resources.About_description;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
