using System;
using System.Windows.Forms;

namespace ConwaysGameLife
{
    public partial class frmRuleDescription : Form
    {
        string m_description = "New Rules";

        public frmRuleDescription()
        {
            InitializeComponent();
        }

        public string description
        {
            get { return m_description; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
