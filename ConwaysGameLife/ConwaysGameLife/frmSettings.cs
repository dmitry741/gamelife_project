using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConwaysGameLife
{
    public partial class frmSettings : Form
    {
        public frmSettings(ref List<ILifeRule> lifeRules, int currentRulesIndex)
        {
            InitializeComponent();

            m_lifeRules = lifeRules;
            m_currentRulesIndex = currentRulesIndex;
        }

        List<ILifeRule> m_lifeRules = new List<ILifeRule>();
        int m_currentRulesIndex = 0;

        public int currentRulesIndex => m_currentRulesIndex;

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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

            cmbNewCellSign1.Items.AddRange(Utility.signs);
            cmbNewCellSign2.Items.AddRange(Utility.signs);
            cmbCellGoOnSign1.Items.AddRange(Utility.signs);
            cmbCellGoOnSign2.Items.AddRange(Utility.signs);

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
                label1.Visible = label3.Visible = false;
            }
        }

        private void checkBoxOR1_CheckedChanged(object sender, EventArgs e)
        {
            lblNewCellOr.Visible = cmbNewCellNumber2.Visible = cmbNewCellSign2.Visible = checkBoxOR1.Checked;

            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.newCellOrEnable = checkBoxOR1.Checked;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRuleDescription dlg = new frmRuleDescription();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                UserLifeRules ulr = new UserLifeRules
                {
                    description = dlg.description
                };

                m_lifeRules.Add(ulr);
                listBox1.Items.Add(ulr);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex < 0)
                return;

            ILifeRule lr = m_lifeRules[selectedIndex];

            if (lr is UserLifeRules)
            {
                if (MessageBox.Show($"Are you sure that you want to remove rule: {lr}", "Game of life", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    m_lifeRules.RemoveAt(selectedIndex);
                    listBox1.Items.RemoveAt(selectedIndex);

                    if (listBox1.Items.Count > 0)
                        listBox1.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("This rule is built-in. Cannot remove it.");
            }
        }

        private void cmbNewCellSign1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.newCellSign1 = cmbNewCellSign1.SelectedIndex;
            }
        }

        private void cmbNewCellNumber1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.newCellNeighbors1 = cmbNewCellNumber1.SelectedIndex + 1;
            }
        }

        private void cmbNewCellSign2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.newCellSign2 = cmbNewCellSign2.SelectedIndex;
            }
        }

        private void cmbNewCellNumber2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.newCellNeighbors2 = cmbNewCellNumber2.SelectedIndex + 1;
            }
        }

        private void cmbCellGoOnSign1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.cellGoOnSign1 = cmbCellGoOnSign1.SelectedIndex;
            }
        }

        private void cmbCellGoOnSign2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.cellGoOnSign2 = cmbCellGoOnSign2.SelectedIndex;
            }
        }

        private void cmbCellGoOnNumber1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.cellGoOnNeighbors1 = cmbCellGoOnNumber1.SelectedIndex + 1;
            }
        }

        private void cmbCellGoOnNumber2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.cellGoOnNeighbors2 = cmbCellGoOnNumber2.SelectedIndex + 1;
            }
        }

        private void checkBoxOR2_CheckedChanged(object sender, EventArgs e)
        {
            lblCellGoOnOr.Visible = cmbCellGoOnSign2.Visible = cmbCellGoOnNumber2.Visible = checkBoxOR2.Checked;

            ILifeRule lr = m_lifeRules[m_currentRulesIndex];

            if (lr is UserLifeRules)
            {
                UserLifeRules ulr = lr as UserLifeRules;
                ulr.cellGoOnOrEnable = checkBoxOR2.Checked;
            }
        }
    }
}
