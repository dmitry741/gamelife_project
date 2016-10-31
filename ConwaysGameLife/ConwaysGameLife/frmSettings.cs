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

            for (int i = 1; i <= 8; i++)
            {
                cmbNewCellNumber1.Items.Add(i);
                cmbNewCellNumber2.Items.Add(i);
                cmbCellGoOnNumber1.Items.Add(i);
                cmbCellGoOnNumber2.Items.Add(i);
            }

            cmbNewCellSign1.Items.AddRange(Utility.sings);
            cmbNewCellSign2.Items.AddRange(Utility.sings);
            cmbCellGoOnSign1.Items.AddRange(Utility.sings);
            cmbCellGoOnSign2.Items.AddRange(Utility.sings);

            listBox1.SelectedIndex = m_currentRulesIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            m_currentRulesIndex = listBox1.SelectedIndex;

            ILifeRule lr = m_lifeRules[m_currentRulesIndex];
            
            if (lr is UserLifeRules)
            {
                cmbNewCellSign1.Visible = cmbNewCellNumber1.Visible = true;
                cmbCellGoOnSign1.Visible = cmbCellGoOnNumber1.Visible = true;

                UserLifeRules ulr = lr as UserLifeRules;

                cmbNewCellSign1.SelectedIndex = ulr.newCellSign1;
                cmbNewCellNumber1.SelectedIndex = ulr.newCellNeighbors1 - 1;

                cmbCellGoOnSign1.SelectedIndex = ulr.cellGoOnSign1;
                cmbCellGoOnNumber1.SelectedIndex = ulr.cellGoOnNeighbors1 - 1;

                if (ulr.newCellOrEnable)
                {
                    lblNewCellOr.Visible = true;
                    cmbNewCellSign2.Visible = cmbNewCellNumber2.Visible = true;
                    checkBoxOR1.Checked = true;

                    cmbNewCellSign2.SelectedIndex = ulr.newCellSign2;
                    cmbNewCellNumber2.SelectedIndex = ulr.newCellNeighbors2 - 1;
                }
                else
                {
                    lblNewCellOr.Visible = false;
                    cmbNewCellSign2.Visible = cmbNewCellNumber2.Visible = false;
                    checkBoxOR1.Checked = false;

                    cmbNewCellSign2.SelectedIndex = 0;
                    cmbNewCellNumber2.SelectedIndex = 0;
                }

                if (ulr.cellGoOnOrEnable)
                {
                    lblCellGoOnOr.Visible = true;
                    cmbCellGoOnSign2.Visible = cmbCellGoOnNumber2.Visible = true;
                    checkBoxOR2.Checked = true;

                    cmbCellGoOnSign2.SelectedIndex = ulr.cellGoOnSign2;
                    cmbCellGoOnNumber2.SelectedIndex = ulr.cellGoOnNeighbors2 - 1;
                }
                else
                {
                    lblCellGoOnOr.Visible = false;
                    cmbCellGoOnSign2.Visible = cmbCellGoOnNumber2.Visible = false;
                    checkBoxOR2.Checked = false;

                    cmbCellGoOnSign2.SelectedIndex = 0;
                    cmbCellGoOnNumber2.SelectedIndex = 0;
                }

                checkBoxOR1.Visible = checkBoxOR2.Visible = true;
                btnSave.Visible = true;
                label1.Visible = label3.Visible = true;
            }
            else
            {
                cmbNewCellSign1.Visible = cmbNewCellNumber1.Visible = false;
                cmbCellGoOnSign1.Visible = cmbCellGoOnNumber1.Visible = false;

                lblNewCellOr.Visible = false;
                cmbNewCellSign2.Visible = cmbNewCellNumber2.Visible = false;

                lblCellGoOnOr.Visible = false;
                cmbCellGoOnSign2.Visible = cmbCellGoOnNumber2.Visible = false;

                checkBoxOR1.Visible = checkBoxOR2.Visible = false;
                btnSave.Visible = false;

                label1.Visible = label3.Visible = false;
            }

            lblSaveString.Visible = false;
        }

        private void checkBoxOR1_CheckedChanged(object sender, EventArgs e)
        {
            lblNewCellOr.Visible = cmbNewCellNumber2.Visible = cmbNewCellSign2.Visible = checkBoxOR1.Checked;
        }
    }
}
