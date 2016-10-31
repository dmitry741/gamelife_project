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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        List<ILifeRule> m_lifeRules = new List<ILifeRule>();
        int m_currentRulesIndex = 2;

        public void SetListLifeRules(ref List<ILifeRule> lifeRules)
        {
            m_lifeRules = lifeRules;
        }

        public int currentRulesIndex
        {
            get { return m_currentRulesIndex; }
            set { m_currentRulesIndex = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(m_lifeRules.ToArray());
            listBox1.SelectedIndex = m_currentRulesIndex;

            for (int i = 1; i <= 8; i++)
            {
                cmbNewCellNumber1.Items.Add(i);
                cmbNewCellNumber2.Items.Add(i);
            }

            cmbNewCellSign1.Items.AddRange(Utility.Sings);
            cmbNewCellSign2.Items.AddRange(Utility.Sings);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            m_currentRulesIndex = listBox1.SelectedIndex;

            ILifeRule lr = m_lifeRules[m_currentRulesIndex];
            // TODO:

        }

        private void checkBoxOR1_CheckedChanged(object sender, EventArgs e)
        {
            lblNewCellOr.Visible = cmbNewCellNumber2.Visible = cmbNewCellSign2.Visible = checkBoxOR1.Checked;
        }
    }
}
